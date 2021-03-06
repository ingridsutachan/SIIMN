﻿////*********************************************************
//
//    <copyright file="frmlogin.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using Entities;
    using Negocios.General;

    /// <summary>
    /// Clase de formulario login
    /// </summary>
    public partial class Frmlogin : Form
    {
        /// <summary>
        /// contador para las entradas del usuario
        /// </summary>
        private int contcontr = 0;

        /// <summary>
        /// instacia el usuario de la capa negocios
        /// </summary>
        private Usuarion negocioUser;

        /// <summary>
        /// instacia la empresa de la capa negocios
        /// </summary>
        private Empresan negocioEmpresa;

        /// <summary>
        /// instacia la conexion de la capa negocios
        /// </summary>
        private Conexionn negocioConexion;

        /// <summary>
        /// Initializes a new instance of the <see cref="Frmlogin"/> class.
        /// </summary>
        public Frmlogin()
        {
            this.InitializeComponent();
            this.negocioUser = new Usuarion();
            this.negocioEmpresa = new Empresan();
            this.negocioConexion = new Conexionn();
        }

        /// <summary>
        /// Handles the Click event of the Entrar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                this.Txtuser_Validating(sender, new CancelEventArgs());
            }
            else
            {
                if (string.IsNullOrEmpty(txtpwd.Text))
                {
                    this.Txtpwd_Validating(sender, new CancelEventArgs());
                }
                else
                {
                    txtuser.Text = txtuser.Text.Trim();
                    bool result1 = false;
                    try
                    {
                        result1 = this.negocioUser.VerificarUsuario(txtuser.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se presento un error. " + ex.Message);
                    }

                    if (result1)
                    {
                        bool result = false;

                        try
                        {
                            result = this.negocioUser.Verificar(txtuser.Text, txtpwd.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se presento un error. " + ex.Message);
                        }

                        if (result)
                        {
                            Forms.Frmmenu menuall = new Forms.Frmmenu();
                            this.contcontr = 0;
                            int id = 0;
                            int idempre = 0;
                            try
                            {
                                id = this.negocioUser.DevolverUsuario(txtuser.Text);
                                idempre = this.negocioEmpresa.DevolverEmpresa(empresacbx.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Se presento un error. " + ex.Message);
                            }

                            Program.iduser = id;
                            Program.compa = idempre;

                            conexuser conex = new conexuser();
                            conex.idusuario = id;
                            conex.idcompania = idempre;
                            conex.fechaconex = DateTime.Now;
                            usuario usuariogua = new usuario();
                            usuariogua.idusuario = id;
                            usuariogua.fechaulticonex = DateTime.Now;
                            usuariogua.intentosfallidos = this.contcontr;
                            usuariogua.bloqueado = false;
                            try
                            {
                                this.negocioUser.ActualizarUsuario(usuariogua);
                                this.negocioConexion.GuardarConexion(conex);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }

                            MessageBox.Show("BIENVENIDO A SIIMN", "Titulo", MessageBoxButtons.OK);
                            menuall.Show();
                            this.Hide();
                        }
                        else
                        {
                            this.contcontr++;
                            try
                            {
                                this.negocioUser.ActualizaContador(this.contcontr, txtuser.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Se presento un error. " + ex.Message);
                            }

                            MessageBox.Show("La contraseña es incorrecta,intentelo de nuevo", "Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe,intentelo de nuevo");
                    }
                }
            }
        }

        /// <summary>
        /// Cargar empresa en combobox
        /// </summary>
        private void CargarEmpresa()
        {
            empresacbx.DataSource = this.negocioEmpresa.CargarEmpresa();
            empresacbx.ValueMember = "idcompania";
            empresacbx.DisplayMember = "nombrecia";
        }

        /// <summary>
        /// Handles the Load event of the Login control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Login_Load(object sender, EventArgs e)
        {
            this.CargarEmpresa();
        }

        /// <summary>
        /// Handles the FormClosing event of the Frmlogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro que Desea Salir?", "SIIMN", MessageBoxButtons.YesNo))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Handles the Validating event of the Txtuser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void Txtuser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                e.Cancel = true;
                MessageBox.Show("El usuario es necesario", "ERROR", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Handles the Validating event of the Txtpwd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void Txtpwd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpwd.Text))
            {
                e.Cancel = true;
                MessageBox.Show("La contraseña es necesaria", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}