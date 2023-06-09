﻿using Articulo.DataAccess;
using Articulo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.BusinessLogic
{
    public class CategoriaBL
    {
        private static CategoriaBL _instance;

        public static CategoriaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoriaBL();

                return _instance;
            }
        }

        public List<Categoria> SelectAll()
        {
            
            List<Categoria> result;
            try
            {
                var query = UsuarioDAL.Instance.SelectAll();
                result = CategoriaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Insert(Categoria entity)
        {
            bool result=false;
            try
            {
                result = CategoriaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(Categoria entity)
        {
            bool result = false;
            try
            {
                result = CategoriaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
