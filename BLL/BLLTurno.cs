using BE;
using BE.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BLLTurno
    {
        private readonly DALTurno dalTurno =
            new DALTurno();

        public List<DTOHistorial> GetHistorialPorMascota(
    int idMascota)
        {
            List<BETurno> turnos =
                dalTurno.GetAll();

            return turnos
                .Where(t =>
                    t.Mascota != null &&
                    t.Mascota.IdMascota == idMascota)
                .Select(t => new DTOHistorial(
                    t.Mascota.Nombre,

                    t.Mascota.Cliente.Apellido + ", " +
                    t.Mascota.Cliente.Nombre,

                    t.FechaHora,

                    t.Veterinario.Apellido + ", " +
                    t.Veterinario.Nombre,

                    t.TipoConsulta.NombreTipo,

                    t.Diagnostico
                ))
                .ToList();
        }
    }
}