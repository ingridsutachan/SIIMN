﻿////*********************************************************
//
//    <copyright file="usuarion.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace Negocios.General
{
    using System;
    using System.Collections.Generic;
    using Datos.General;
    using Entities;
    using Entities.Types;

    /// <summary>
    /// Clase de usuario
    /// </summary>
    public class Usuarion
    {
        /// <summary>
        /// instancia capa de datos
        /// </summary>
        private Usuarioc persistencia;

        /// <summary>
        /// Initializes a new instance of the <see cref="Usuarion"/> class.
        /// </summary>
        public Usuarion()
        {
            this.persistencia = new Usuarioc();
        }

        /// <summary>
        /// Cargar usuarios
        /// </summary>
        /// <returns>lista de usuarios que se encuentran en la tabla </returns>
        public List<UsuarioDataSource> CargarUsuarios()
        {
            List<UsuarioDataSource> user = new List<UsuarioDataSource>();
            try
            {
                var items = this.persistencia.CargarUsuarios();
                foreach (var item in items)
                {
                    UsuarioDataSource ud = new UsuarioDataSource();
                    ud.Iduser = item.idusuario;
                    ud.User = item.user;
                    ud.Contrasena = item.contrasena;
                    ud.Fechaultimaconex = item.fechaulticonex;
                    ud.Ultimobloqueo = item.ultimobloqueo;
                    ud.Intentosfallidos = item.intentosfallidos;
                    ud.Bloqueado = item.bloqueado;
                    user.Add(ud);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// Verificar el usuario existe y si la contraseña coincide
        /// </summary>
        /// <param name="user">usuario a verificar</param>
        /// <param name="pass">contraseña a verificar</param>
        /// <returns>booleano respectivo si coincide o no la contraseña</returns>
        public bool Verificar(string user, string pass)
        {
            bool result = false;
            try
            {
                result = this.persistencia.Existe(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Verificar si el usuario existe
        /// </summary>
        /// <param name="user">usuario a verificar</param>
        /// <returns>booleano que rectifica si existe o no el usuario</returns>
        public bool VerificarUsuario(string user)
        {
            bool result = false;

            try
            {
                result = this.persistencia.ExisteUsuario(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// guarda el usuario.
        /// </summary>
        /// <param name="usuar">usuario a guardar</param>
        /// <returns>usuario que ha sido guardado</returns>
        public UsuarioDataSource SaveUsuario(usuario usuar)
        {
            UsuarioDataSource user = new UsuarioDataSource();
            try
            {
                var item = this.persistencia.CreateUsuario(usuar);
                user.Iduser = item.idusuario;
                user.User = item.user;
                user.Contrasena = item.contrasena;
                user.Fechaultimaconex = item.fechaulticonex;
                user.Ultimobloqueo = item.ultimobloqueo;
                user.Intentosfallidos = item.intentosfallidos;
                user.Bloqueado = item.bloqueado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// Actualiza usuario
        /// </summary>
        /// <param name="usuar">usuario a actualizar</param>
        /// <returns>usuario que se actualizo</returns>
        public UsuarioDataSource ActualizarUsuario(usuario usuar)
        {
            UsuarioDataSource user = new UsuarioDataSource();
            try
            {
                var item = this.persistencia.UpdateUsuario(usuar);
                user.Iduser = item.idusuario;
                user.User = item.user;
                user.Contrasena = item.contrasena;
                user.Fechaultimaconex = item.fechaulticonex;
                user.Ultimobloqueo = item.ultimobloqueo;
                user.Intentosfallidos = item.intentosfallidos;
                user.Bloqueado = item.bloqueado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// Devolver  usuario.
        /// </summary>
        /// <param name="usuario">usuario a devolver</param>
        /// <returns>id del usuario </returns>
        public int DevolverUsuario(string usuario)
        {
            int idusuario = 0;
            try
            {
                idusuario = this.persistencia.DevolverUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return idusuario;
        }

        /// <summary>
        /// Actualiza contador
        /// </summary>
        /// <param name="contador">contador a actualizar</param>
        /// <param name="user">usuario a actualizar el contador</param>
        public void ActualizaContador(int contador, string user)
        {
            try
            {
                this.persistencia.ActualizaCont(contador, user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
