using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace BLL
{
    public class BLLMascota
    {
        private DALMascota dalMascota = new DALMascota();

        private void ValidarMascota(BEMascota mascota)
        {
            if (mascota == null)
            {
                throw new Exception(
                    "Los datos de la mascota son obligatorios."
                );
            }

            if (string.IsNullOrWhiteSpace(mascota.Nombre))
            {
                throw new Exception(
                    "Debe ingresar el nombre de la mascota."
                );
            }

            if (mascota.Nombre.Trim().Length < 2)
            {
                throw new Exception(
                    "El nombre debe tener al menos 2 caracteres."
                );
            }

            if (string.IsNullOrWhiteSpace(mascota.Especie))
            {
                throw new Exception(
                    "Debe ingresar la especie."
                );
            }

            if (string.IsNullOrWhiteSpace(mascota.Raza))
            {
                throw new Exception(
                    "Debe ingresar la raza."
                );
            }

            if (mascota.FechaNacimiento > DateTime.Today)
            {
                throw new Exception(
                    "La fecha de nacimiento no puede ser futura."
                );
            }

            if (mascota.Cliente == null)
            {
                throw new Exception(
                    "Debe seleccionar un dueño."
                );
            }
        }

        public List<BEMascota> GetAll()
        {
            return dalMascota.GetAll();
        }

        public void Guardar(BEMascota mascota)
        {
            ValidarMascota(mascota);
            mascota.Activo = true;

            using (TransactionScope trx = new TransactionScope())
            {
                dalMascota.Add(mascota);
                trx.Complete();
            }
        }

        public void Modificar(BEMascota mascota)
        {
            ValidarMascota(mascota);

            BEMascota existente =
                dalMascota.GetById(mascota.IdMascota);

            if (existente == null)
            {
                throw new Exception(
                    "La mascota no existe."
                );
            }

            using (TransactionScope trx = new TransactionScope())
            {
                dalMascota.Update(mascota);
                trx.Complete();
            }
        }

        public void DarDeBaja(BEMascota mascota)
        {
            if (mascota == null)
            {
                throw new Exception(
                    "Debe seleccionar una mascota."
                );
            }

            BEMascota existente =
                dalMascota.GetById(mascota.IdMascota);

            if (existente == null)
            {
                throw new Exception(
                    "La mascota no existe."
                );
            }

            if (!existente.Activo)
            {
                throw new Exception(
                    "La mascota ya se encuentra inactiva."
                );
            }

            using (TransactionScope trx = new TransactionScope())
            {
                dalMascota.Delete(mascota.IdMascota);
                trx.Complete();
            }
        }
    }
}