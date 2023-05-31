using Articulo.Entities;
using Articulo.Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.DataAccess
{
    public class UsuarioDAL
    {
        private static UsuarioDAL _instance;

        public static UsuarioDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsuarioDAL();
                }
                return _instance;

            }


        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;
            using (AppDBContext _context = new AppDBContext())
            {               
               

                return null;
                //_context.Set<Usuario>().FromSql("");
                //result = _context.Usuarios.ToList();
            }

            //return result;


        }

        public Usuario SellectById(int id)
        {
            Usuario result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Usuarios
                    .FirstOrDefault(x => x.UsuarioId == id);
            }

            return result;


        }
        public bool Insert(Usuario entity)
        {
            
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Usuarios
                    .FirstOrDefault(x => x.Email.Equals(entity.Email));
                if (query == null)
                {
                    var cmd = _context.Database.Connection.CreateCommand();
                    cmd.CommandText = "sp_UsuarioInsert";
                    var param1 = cmd.CreateParameter();
                    param1.ParameterName = "Email";
                    param1.Value = entity.Email;
                    var param2 = cmd.CreateParameter();
                    param2.ParameterName = "Password";
                    param2.Value = entity.Password;

                    var param3 = cmd.CreateParameter();
                    param3.ParameterName = "RolId";
                    param3.Value = entity.RolId;

                    var param4 = cmd.CreateParameter();
                    param4.ParameterName = "EstadoId";
                    param4.Value = entity.EstadoId;

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);
                    _context.Database.Connection.Open();

                    result = cmd.ExecuteNonQuery() > 0;

                }

                return result;

            }

        }


        public Usuario ComprobarUsuario(string email, string pwd)
        {
            Usuario result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                var cmd = _context.Database.Connection.CreateCommand();
                cmd.CommandText = "spLogin";
                var param1 = cmd.CreateParameter();
                param1.ParameterName = "Email";
                param1.Value = email;
                var param2 = cmd.CreateParameter();
                param2.ParameterName = "Password";
                param2.Value = pwd;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                _context.Database.Connection.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        result = new Usuario();
                        result.UsuarioId = reader.GetInt32(0);
                        result.Email = reader.GetString(1);
                        result.RolId = reader.GetInt32(2);                        
                    }
                }
            }

            return result;


        }
    }
}

