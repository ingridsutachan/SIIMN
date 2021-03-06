﻿// -----------------------------------------------------------------------
// <copyright file="Funciones.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Contable;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Funciones
    {
        private Cuentan negocioCuenta;

        public Funciones()
        {
            this.negocioCuenta = new Cuentan();
        }

        public KeyPressEventArgs ValidacionNumerico(KeyPressEventArgs e)
        {
            KeyPressEventArgs e_other = new KeyPressEventArgs(e.KeyChar);
            e_other.Handled = true;
            if (e.Handled = char.IsDigit(e.KeyChar))
            {
                e_other.Handled = false;
            }
            else if (e.Handled = char.IsControl(e.KeyChar))
            {
                e_other.Handled = e.KeyChar == (char)8 ? false : true;
            }

            return e_other;
        }

        public KeyPressEventArgs ValidacionLetra(KeyPressEventArgs e)
        {
            KeyPressEventArgs e_other = new KeyPressEventArgs(e.KeyChar);
            e_other.Handled = true;
            if (e.Handled = char.IsLetter(e.KeyChar))
            {
                e_other.Handled = false;
            }
            else if (e.Handled = char.IsControl(e.KeyChar))
            {
                e_other.Handled = e.KeyChar == (char)8 ? false : true;
            }

            return e_other;
        }

        public string ValidaCuentaoNombre(string cuenta)
        {
            string dato = string.Empty;
            bool existe = this.negocioCuenta.ExisteCuenta(cuenta);
            if (existe)
            {
                CuentaDataSource cuentax = new CuentaDataSource();
                cuentax = this.negocioCuenta.DevolverDatos(cuenta);
                if (cuentax.Tipocta.Equals("MAYOR"))
                {
                    dato = "CUENTA MAYOR";
                }
                else
                {
                    int valor = 0;
                    dato = !int.TryParse(cuenta, out valor) ? cuentax.Cuenta : cuentax.Nombre;
                }
            }
            else
            {
                dato = "CUENTA NO EXISTENTE";
            }

            return dato;
        }
        public KeyPressEventArgs ValidacionDecimal(KeyPressEventArgs e)
        {
            KeyPressEventArgs e_other = new KeyPressEventArgs(e.KeyChar);
            e_other.Handled = true;


            if (e.Handled = char.IsDigit(e.KeyChar))
            {
                e_other.Handled = false;
            }
            else if (e.Handled = char.IsPunctuation(e.KeyChar))
            {
                e_other.KeyChar = e.KeyChar == (46) ? (char)44 : e.KeyChar;
                e.KeyChar = e_other.KeyChar;
                e_other.Handled = e.KeyChar == (char)44 ? false : true;
            }
            else if (e.Handled = char.IsControl(e.KeyChar))
            {
                e_other.Handled = e.KeyChar == (char)8 ? false : true;
            }

            return e_other;
        }

        public KeyPressEventArgs ValidacionNumeroAsterisco(KeyPressEventArgs e)
        {
            KeyPressEventArgs e_other = new KeyPressEventArgs(e.KeyChar);
            e_other.Handled = true;
            if (e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == (char)42)
            {
                e_other.Handled = false;
            }
            else if (e.Handled = char.IsControl(e.KeyChar))
            {
                e_other.Handled = e.KeyChar == (char)8 ? false : true;
            }

            return e_other;
        }

        public string ValidarOtraCuenta(string cuenta)
        {
            string mensaje;
            bool result = false;
            try
            {
                result = this.negocioCuenta.ExisteCuenta(cuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            if (result)
            {
                bool simayor = false;
                try
                {
                    simayor = this.negocioCuenta.DevuelveTipoCuenta(cuenta).Equals("M");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                }
                if (simayor)
                {
                    mensaje = "CUENTA MAYOR";
                }
                else
                {
                    mensaje = string.Empty;
                }
            }
            else
            {
                mensaje = "CUENTA NO EXISTENTE";
            }

            return mensaje;
        }

        public string ValidarCuentaExista(string cuenta)
        {
            bool result = false;
            try
            {
                result = this.negocioCuenta.ExisteCuenta(cuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
            if (result)
            {
                return string.Empty;
            }
            else
            {
                return "CUENTA NO EXISTENTE";
            }

        }
         }
}
