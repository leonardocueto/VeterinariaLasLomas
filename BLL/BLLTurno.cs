using BE;
using BE.DTO;
using DAL;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace BLL
{
    public class BLLTurno
    {
        private DALTurno dalTurno = new DALTurno();

        private const int ESTADO_PENDIENTE = 1;
        private const int ESTADO_ATENDIDO = 2;
        private const int ESTADO_CANCELADO = 3;

        public List<BETurno> GetAll()
        {
            return dalTurno.GetAll();
        }
        public List<DTOTurno> GetAllDTO()
        {
            return MapperTurno.Map(dalTurno.GetAll());
        }

        public BETurno GetById(int id)
        {
            return dalTurno.GetById(id);
        }

        public List<BETurno> GetHistorialPorMascota(int idMascota)
        {
            return dalTurno.GetHistorialPorMascota(idMascota);
        }

        private void validarSolapamiento(BETurno turno)
        {
            DateTime inicioNuevo = turno.FechaHora;
            DateTime finNuevo = turno.FechaHora.AddMinutes(turno.TipoConsulta.DuracionMinutos);

            List<BETurno> turnosDelDia = dalTurno.GetByVeterinarioYFecha(
                turno.Veterinario.IdVeterinario, turno.FechaHora);

            foreach (BETurno existente in turnosDelDia)
            {
                if (existente.IdTurno != turno.IdTurno)
                {
                    DateTime inicioExistente = existente.FechaHora;
                    DateTime finExistente = existente.FechaHora.AddMinutes(existente.TipoConsulta.DuracionMinutos);

                    if (inicioNuevo < finExistente && inicioExistente < finNuevo)
                    {
                        throw new Exception("El veterinario ya tiene un turno que se superpone en ese horario.");
                    }
                }
            }
        }

        private void validarTurno(BETurno turno)
        {
            if (turno.Mascota == null)
                throw new Exception("Debe seleccionar una mascota.");

            if (turno.Veterinario == null)
                throw new Exception("Debe seleccionar un veterinario.");

            if (turno.TipoConsulta == null)
                throw new Exception("Debe seleccionar un tipo de consulta.");

            if (turno.FechaHora < DateTime.Now)
                throw new Exception("No se pueden asignar turnos en el pasado.");
        }

        public void Guardar(BETurno turno)
        {
            validarTurno(turno);
            validarSolapamiento(turno);

            BEEstadoTurno pendiente = new BEEstadoTurno();
            pendiente.IdEstadoTurno = ESTADO_PENDIENTE;
            turno.Estado = pendiente;

            using (TransactionScope trx = new TransactionScope())
            {
                dalTurno.Add(turno);
                trx.Complete();
            }
        }

        public void Modificar(BETurno turno)
        {
            BETurno existente = dalTurno.GetById(turno.IdTurno);
            if (existente == null)
                throw new Exception("El turno no existe.");

            if (existente.Estado.IdEstadoTurno != ESTADO_PENDIENTE)
                throw new Exception("Solo se pueden modificar turnos pendientes.");

            validarTurno(turno);
            validarSolapamiento(turno);

            using (TransactionScope trx = new TransactionScope())
            {
                dalTurno.Update(turno);
                trx.Complete();
            }
        }

        public void Cancelar(int idTurno)
        {
            BETurno existente = dalTurno.GetById(idTurno);
            if (existente == null)
                throw new Exception("El turno no existe.");

            if (existente.Estado.IdEstadoTurno != ESTADO_PENDIENTE)
                throw new Exception("Solo se pueden cancelar turnos pendientes.");

            using (TransactionScope trx = new TransactionScope())
            {
                dalTurno.CambiarEstado(idTurno, ESTADO_CANCELADO);
                trx.Complete();
            }
        }
        public void CerrarAtencion(int idTurno, string diagnostico)
        {
            BETurno existente = dalTurno.GetById(idTurno);
            if (existente == null)
                throw new Exception("El turno no existe.");

            if (existente.Estado.IdEstadoTurno != ESTADO_PENDIENTE)
                throw new Exception("Solo se pueden cerrar turnos pendientes.");

            if (diagnostico == null || diagnostico.Trim().Length < 10)
                throw new Exception("El diagnóstico debe tener al menos 10 caracteres.");

            using (TransactionScope trx = new TransactionScope())
            {
                dalTurno.GuardarDiagnostico(idTurno, diagnostico);
                dalTurno.CambiarEstado(idTurno, ESTADO_ATENDIDO);
                trx.Complete();
            }
        }


    }
}