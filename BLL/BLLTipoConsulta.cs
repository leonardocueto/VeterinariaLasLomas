using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class BLLTipoConsulta
    {
        private DALTipoConsulta dalTipoConsulta = new DALTipoConsulta();

        public List<BETipoConsulta> GetAll()
        {
            return dalTipoConsulta.GetAll();
        }

        public BETipoConsulta GetById(int id)
        {
            return dalTipoConsulta.GetById(id);
        }
    }
}
