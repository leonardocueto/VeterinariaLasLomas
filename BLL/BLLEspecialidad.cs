using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class BLLEspecialidad
    {
        private DALEspecialidad dalEspecialidad = new DALEspecialidad();

        public List<BEEspecialidad> GetAll()
        {
            return dalEspecialidad.GetAll();
        }

        public BEEspecialidad GetById(int id)
        {
            return dalEspecialidad.GetById(id);
        }

        private void validarEspecialidad(BEEspecialidad especialidad)
        {
            if (especialidad.NombreEspecialidad == null || especialidad.NombreEspecialidad.Trim().Length < 3)
                throw new Exception("El nombre de la especialidad debe tener al menos 3 caracteres.");
        }

        public void Guardar(BEEspecialidad especialidad)
        {
            try
            {
            using (TransactionScope trx = new TransactionScope())
            {
                validarEspecialidad(especialidad);
                dalEspecialidad.Add(especialidad);
                trx.Complete();
            }

            }
            catch
            {
                throw;
            }
        }

        public void Modificar(BEEspecialidad especialidad)
        {
            BEEspecialidad existente = dalEspecialidad.GetById(especialidad.IdEspecialidad);
            if (existente == null)
                throw new Exception("La especialidad con el ID ingresado no existe.");

            validarEspecialidad(especialidad);
            try
            {
            using (TransactionScope trx = new TransactionScope())
            {
                dalEspecialidad.Update(especialidad);
                trx.Complete();
            }

            }
            catch
            {
                throw;
            }
        }

        public void Eliminar(int id)
        {
            BEEspecialidad existente = dalEspecialidad.GetById(id);
            if (existente == null)
                throw new Exception("La especialidad con el ID ingresado no existe.");

            if (dalEspecialidad.ContarVeterinarios(id) > 0)
                throw new Exception("No se puede eliminar: hay veterinarios que tienen esta especialidad asignada.");
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    dalEspecialidad.Delete(id);
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
