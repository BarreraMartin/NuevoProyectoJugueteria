﻿using Articulo.DataAccess;
using Articulo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class ClienteBL
    {
        private static ClienteBL _instance;

        public static ClienteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteBL();

                return _instance;
            }
        }

        public List<Cliente> SelectAll()
        {
            List<Cliente> result;
            try
            {
                result = ClienteDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;
            try
            {
                result = ClienteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

        public bool Update(Cliente entity)
        {
            bool result = false;
            try
            {
                result = ClienteDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }


        public bool Delete(int id)
        {

            bool result = false;
            try
            {
                result = ClienteDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {

                throw new Exception("Error. " + ex.Message);
            }

            return result;
        }
    }
}
