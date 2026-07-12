using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BLL
{
    public class BLLCliente
    {
        private DALCliente dalCliente = new DALCliente();

        private void validarCliente(BECliente cliente)
        {
            if (cliente.Nombre == null || cliente.Nombre.Trim().Length < 2)
            {
                throw new Exception("El nombre debe tener al menos 2 caracteres.");
            }

            if (cliente.Apellido == null || cliente.Apellido.Trim().Length < 2)
            {
                throw new Exception("El apellido debe tener al menos 2 caracteres.");
            }

            if (cliente.Dni == null || cliente.Dni.Length < 7 || cliente.Dni.Length > 8)
            {
                throw new Exception("El DNI debe tener entre 7 y 8 dígitos.");
            }

            if (!cliente.Dni.All(char.IsDigit))
            {
                throw new Exception("El DNI debe contener solo números.");
            }

            if (!string.IsNullOrEmpty(cliente.Email) && !cliente.Email.Contains("@"))
            {
                throw new Exception("El email no tiene un formato válido.");
            }
        }
        public List<BECliente> GetAll()
        {
            try
            {

            return dalCliente.GetAll();
            }
            catch
            {
                throw;
            }
        }
        public BECliente GetById(int id)
        {
            return dalCliente.GetById(id);
        }

        public void Guardar(BECliente cliente) 
        {
            cliente.Activo = true;
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    validarCliente(cliente);
                    dalCliente.Add(cliente);
                    trx.Complete();
                }
            }
            catch
            {
                throw;
            }
        }

        public void Modificar(BECliente cliente)
        {
            try
            {
                BECliente existe = dalCliente.GetById(cliente.IdCliente);
                if (existe == null)
                {
                    throw new Exception("El cliente no existe.");
                }
                using(TransactionScope trx = new TransactionScope())
                {
                    dalCliente.Update(cliente);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DarDeBaja(int id)
        {
            BECliente existente = dalCliente.GetById(id);
            if (existente == null)
                throw new Exception("El cliente con el ID ingresado no existe.");
            try
            {

            using (TransactionScope trx = new TransactionScope())
            {
                dalCliente.Delete(id);
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
