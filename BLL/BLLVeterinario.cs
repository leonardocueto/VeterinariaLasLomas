using BE;
using BE.DTO;
using DAL;
using Mapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class BLLVeterinario
    {
        private DALVeterinario dalVeterinario = new DALVeterinario();

        public List<BEVeterinario> GetAll()
        {
            return dalVeterinario.GetAll();
        }
        public List<DTOVeterinario> GetAllDTO()
        {
            return MapperVeterinario.Map(dalVeterinario.GetAll());
        }

        public BEVeterinario GetById(int id)
        {
            return dalVeterinario.GetById(id);
        }

        private void validarVeterinario(BEVeterinario veterinario)
        {
            if (veterinario.Nombre == null || veterinario.Nombre.Trim().Length < 2)
                throw new Exception("El nombre debe tener al menos 2 caracteres.");

            if (veterinario.Apellido == null || veterinario.Apellido.Trim().Length < 2)
                throw new Exception("El apellido debe tener al menos 2 caracteres.");

            if (veterinario.Matricula == null || veterinario.Matricula.Trim().Length < 3)
                throw new Exception("La matrícula es obligatoria.");

            if (veterinario.Especialidades == null || veterinario.Especialidades.Count == 0)
                throw new Exception("El veterinario debe tener al menos una especialidad.");
            BEVeterinario existente = dalVeterinario.GetByMatricula(veterinario.Matricula);
            if (existente != null && existente.IdVeterinario != veterinario.IdVeterinario)
            {
                throw new Exception("Ya existe un veterinario con esa matrícula.");
            }

        }

        public void Guardar(BEVeterinario veterinario)
        {
            try
            {
                validarVeterinario(veterinario);
                veterinario.Activo = true;
                using (TransactionScope trx = new TransactionScope())
                {

                    dalVeterinario.Add(veterinario);
                    trx.Complete();
                }
            }
            catch
            {
                throw;
            }
        }

        public void Modificar(BEVeterinario veterinario)
        {
            BEVeterinario existente = dalVeterinario.GetById(veterinario.IdVeterinario);
            if (existente == null)
                throw new Exception("El veterinario con el ID ingresado no existe.");

            validarVeterinario(veterinario);

            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    dalVeterinario.Update(veterinario);
                    trx.Complete();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DarDeBaja(int id)
        {
            BEVeterinario existente = dalVeterinario.GetById(id);
            if (existente == null)
                throw new Exception("El veterinario con el ID ingresado no existe.");

            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    dalVeterinario.Delete(id);
                    trx.Complete();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
