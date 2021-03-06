﻿// -----------------------------------------------------------------------
// <copyright file="CajeroD.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Datos.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Entities;
    using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class CajeroD
    {
        public CajeroD()
        {
        }

        public List<cajero> CargarDatos()
        {
            List<cajero> caje = new List<cajero>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    caje = bd.cajero.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return caje;
        }

        public int ObtenerCodigo()
        {
            int codigo = 0;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.cajero.Count();
                    if (query > 0)
                    {
                        var query1 = bd.cajero.ToList().OrderByDescending(c => c.idcajero).First();
                        codigo = query1.idcajero + 1;
                    }
                    else
                    {
                        codigo = 1;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return codigo;
        }

        public bool GuardarCajero(cajero cajer)
        {
            bool guardo = false;
            using (siimnEntities bd = new siimnEntities())
            {
                string pwencrypt = Encryp.EncryptStringAES(cajer.clave, "85321495kbM1m9");
                cajer.clave = pwencrypt;
                bd.cajero.Add(cajer);
                bd.SaveChanges();
                guardo = true;
            }
            return guardo;
        }

        public string MD5Hash(string text)
        {

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }

        public bool ExisteCajero(string user)
        {
            bool existe = true;
            using (siimnEntities bd = new siimnEntities())
            {
                var query = bd.cajero.Where(ca => ca.usuariocaje == user).Count();
                existe = query > 0 ? true : false;
            }

            return existe;
        }
    }

}
