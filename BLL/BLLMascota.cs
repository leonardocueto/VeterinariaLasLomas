using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace BLL
{
    public class BLLMascota
    {
        private readonly DALMascota dalMascota =
            new DALMascota();

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

            mascota.Nombre = mascota.Nombre.Trim();

            if (mascota.Nombre.Length < 2)
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

            mascota.Especie = mascota.Especie.Trim();

            if (string.IsNullOrWhiteSpace(mascota.Raza))
            {
                throw new Exception(
                    "Debe ingresar la raza."
                );
            }

            mascota.Raza = mascota.Raza.Trim();

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

            if (mascota.Cliente.IdCliente <= 0)
            {
                throw new Exception(
                    "El dueño seleccionado no es válido."
                );
            }
        }

        public List<BEMascota> GetAll()
        {
            try
            {
                return dalMascota.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo obtener la lista de mascotas. " +
                    ex.Message,
                    ex
                );
            }
        }

        public void Guardar(BEMascota mascota)
        {
            try
            {
                ValidarMascota(mascota);

                mascota.Activo = true;

                using (TransactionScope trx =
                    new TransactionScope())
                {
                    dalMascota.Add(mascota);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo guardar la mascota. " +
                    ex.Message,
                    ex
                );
            }
        }

        public void Modificar(BEMascota mascota)
        {
            try
            {
                ValidarMascota(mascota);

                if (mascota.IdMascota <= 0)
                {
                    throw new Exception(
                        "El identificador de la mascota no es válido."
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

                using (TransactionScope trx =
                    new TransactionScope())
                {
                    dalMascota.Update(mascota);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo modificar la mascota. " +
                    ex.Message,
                    ex
                );
            }
        }

        public void DarDeBaja(BEMascota mascota)
        {
            try
            {
                if (mascota == null)
                {
                    throw new Exception(
                        "Debe seleccionar una mascota."
                    );
                }

                if (mascota.IdMascota <= 0)
                {
                    throw new Exception(
                        "El identificador de la mascota no es válido."
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

                using (TransactionScope trx =
                    new TransactionScope())
                {
                    dalMascota.Delete(mascota.IdMascota);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo dar de baja la mascota. " +
                    ex.Message,
                    ex
                );
            }
        }
    }
}