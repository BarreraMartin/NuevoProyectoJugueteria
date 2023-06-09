﻿using Articulo.DataAccess;
using Articulo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class EstadoBL
    {
        private static EstadoBL _instance;

        public static EstadoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoBL();

                return _instance;
            }
        }

        public List<Estado> SelectAll()
        {
            List<Estado> result;
            try
            {
                result = EstadoDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Insert(Estado entity)
        {
            bool result = false;
            try
            {
                result = EstadoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

        public bool Update(Estado entity)
        {
            bool result = false;
            try
            {
                result = EstadoDAL.Instance.Update(entity);
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
                result = EstadoDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {

                throw new Exception("Error. " + ex.Message);
            }

            return result;
        }
    }
}
