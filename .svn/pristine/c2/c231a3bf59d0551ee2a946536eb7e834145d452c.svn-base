////*********************************************************
//
//    <copyright file="usuarioc.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Datos.General
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;

    /// <summary>
    /// Clase usuario capa de Datos
    /// </summary>
    public class Usuarioc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usuarioc"/> class.
        /// </summary>
        public Usuarioc()
        {
        }

        /// <summary>
        /// Cargar usuarios
        /// </summary>
        /// <returns>lista de usuarios en la tabla</returns>
        public List<usuario> CargarUsuarios()
        {
            List<usuario> user = new List<usuario>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    user = bd.usuario.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return user;
        }

        /// <summary>
        /// Existe usuario
        /// </summary>
        /// <param name="user">nombre de usuarip</param>
        /// <param name="pwd">contraseña de usuario</param>
        /// <returns>booleano que verifica si la contraseña y usuario coinciden</returns>
        public bool Existe(string user, string pwd)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                bool result = false;

                var query = 0;

                try
                {
                    query = (from us in bd.usuario where us.user == user && us.contrasena == pwd select us).Count();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (query == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                return result;
            }
        }

        /// <summary>
        /// Existe usuario
        /// </summary>
        /// <param name="user">nombre de usuario</param>
        /// <returns>boleano que rectifica si el usuario existe en la bd</returns>
        public bool ExisteUsuario(string user)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                bool result = false;

                var query = 0;
                try
                {
                    query = (from us in bd.usuario where us.user == user select us).Count();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (query == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                return result;
            }
        }

        /// <summary>
        /// Crea usuario
        /// </summary>
        /// <param name="usuar">usuario a crear</param>
        /// <returns>usuario que se ha creado</returns>
        public usuario CreateUsuario(usuario usuar)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    usuario us = new usuario();
                    us.idusuario = usuar.idusuario;
                    us.user = usuar.user;
                    us.contrasena = usuar.contrasena;
                    us.bloqueado = usuar.bloqueado;
                    bd.usuario.Add(us);
                    bd.SaveChanges();
                    usuar.user = us.user;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return usuar;
        }

        /// <summary>
        /// Actualiza el usuario
        /// </summary>
        /// <param name="usuar">usuario a actualizar</param>
        /// <returns>usuario que se ha actualizado</returns>
        public usuario UpdateUsuario(usuario usuar)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.usuario.Where(usu => usu.idusuario == usuar.idusuario).First();
                    query.fechaulticonex = usuar.fechaulticonex;
                    query.ultimobloqueo = usuar.ultimobloqueo;
                    query.intentosfallidos = usuar.intentosfallidos;
                    query.bloqueado = usuar.bloqueado;
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return usuar;
        }

        /// <summary>
        /// Devolver usuario
        /// </summary>
        /// <param name="user">nombre de usuario</param>
        /// <returns>identificador del usuario</returns>
        public int DevolverUsuario(string user)
        {
            int iduser = 0;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.usuario.Where(usu => usu.user == user).First();
                    iduser = query.idusuario;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return iduser;
        }

        /// <summary>
        /// Actualiza el contador
        /// </summary>
        /// <param name="contador">contador actual</param>
        /// <param name="user">usuario al cual se debe actualizar</param>
        public void ActualizaCont(int contador, string user)
        {
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.usuario.Where(usu => usu.user == user).First();
                    query.intentosfallidos = contador > 0 ? query.intentosfallidos + contador : 0;
                    bd.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
