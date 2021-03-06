﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Types;
using Negocios.Factura;

namespace App.Forms.Factura
{
    public partial class Form_Vendedores : Form
    {

        private Funciones funtions;

        private VendedorN negocioVendedor;

        public Form_Vendedores()
        {
            InitializeComponent();
            this.Visual();
            this.funtions = new Funciones();
            this.negocioVendedor = new VendedorN();
        }

        private void Visual()
        {
            combo_tipo.SelectedIndex = 0;
        }

        private void Habilitar()
        {
            combo_tipo.Enabled = true;
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            check_activo.Enabled = true;
            txt_cedula.Enabled = true;
            txt_direcc.Enabled = true;
            txt_telefono.Enabled = true;
            txt_email.Enabled = true;
            check_comixrango.Enabled = true;
            txt_comision.Enabled = true;
            btn_guardar.Enabled = true;
            btn_nuevo.Enabled = false;
        }

        private void Inhabilitar()
        {
            combo_tipo.Enabled = false;
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            check_activo.Enabled = false;
            txt_cedula.Enabled = false;
            txt_direcc.Enabled = false;
            txt_telefono.Enabled = false;
            txt_email.Enabled = false;
            check_comixrango.Enabled = false;
            txt_comision.Enabled = false;
            btn_guardar.Enabled = false;
            combo_tipo.SelectedIndex = 0;
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            check_activo.Checked = false;
            txt_cedula.Text = string.Empty;
            txt_direcc.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_email.Text = string.Empty;
            check_comixrango.Checked = false;
            txt_comision.Text = string.Empty;
            btn_guardar.Enabled = false;
            combo_tipo.SelectedIndex = 0;
            btn_buscar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_nuevo.Enabled = true;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Habilitar();
            combo_tipo.Focus();
        }

        private void enterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void enterTabVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionNumerico(e).Handled;
            }
        }

        private void enterTabDecim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = this.funtions.ValidacionDecimal(e).Handled;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Inhabilitar();
        }
        private void BotonesInhab()
        {
            btn_buscar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Form_VisualFactura frm = new Form_VisualFactura("vendedor", "buscar", this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool valida = this.Validar();
            if (valida)
            {
                VendedorDataSource vend = new VendedorDataSource();
                vend = this.GuardarDatos();
                bool guardo = false;

                if (txt_codigo.ReadOnly == false)
                {
                    try
                    {
                        guardo = this.negocioVendedor.Guardar(vend);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se presento un error. " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        guardo = this.negocioVendedor.Editar(vend);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se presento un error. " + ex.Message);
                    }
                }
                if (guardo)
                {
                    MessageBox.Show("EL REGISTRO FUE GUARDADO", "ERROR", MessageBoxButtons.OK);
                    this.Inhabilitar();
                }
            }
        }

        private bool Validar()
        {
            bool valid = false;
            if (!txt_codigo.Text.Equals(string.Empty) && !txt_cedula.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty)
                && !txt_telefono.Text.Equals(string.Empty))
            {
                bool codrep = false;
                try
                {
                    codrep = this.negocioVendedor.CodigoExiste(int.Parse(txt_codigo.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }
                if (codrep)
                {
                    if (!txt_email.Text.Equals(string.Empty))
                    {
                        if (txt_email.Text.Contains("@") && txt_email.Text.Contains("."))
                        {
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("EL CORREO INGRESADO NO ES VALIDO", "ERROR", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        valid = true;
                    }
                }
                else
                {
                    if (txt_codigo.ReadOnly == false)
                    {
                        MessageBox.Show("EL CODIGO INGRESADO YA EXISTE", "ERROR", MessageBoxButtons.OK);
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("INGRESE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK);
            }

            return valid;
        }

        private VendedorDataSource GuardarDatos()
        {
            VendedorDataSource vend = new VendedorDataSource();
            vend.Compania = Program.compa;
            vend.Codigo = int.Parse(txt_codigo.Text);
            vend.Tipo = combo_tipo.SelectedIndex.ToString();
            vend.Cedula = txt_cedula.Text;
            vend.Nombre = txt_nombre.Text;
            vend.Telefono = txt_telefono.Text;
            vend.Email = txt_email.Text;
            vend.Direccion = txt_direcc.Text;
            vend.Activo = check_activo.Checked;
            vend.ComisionR = check_comixrango.Checked;
            vend.Comision = Convert.ToDecimal(txt_comision.Text);
            return vend;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            Form_VisualFactura frm = new Form_VisualFactura("vendedor", "editar", this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Form_VisualFactura frm = new Form_VisualFactura("vendedor", "eliminar", this);
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.BotonesInhab();
        }
        public void HabilitarBot()
        {
            btn_nuevo.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_buscar.Enabled = true;
        }
        public void CargarDatos(int codigvend)
        {
            VendedorDataSource vendedor = new VendedorDataSource();
            try
            {
                vendedor = this.negocioVendedor.DevolverVendedor(codigvend);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error", ex.Message, MessageBoxButtons.OK);
            }
            txt_codigo.Text = Convert.ToString(vendedor.Codigo);
            txt_cedula.Text = vendedor.Cedula;
            txt_nombre.Text = vendedor.Nombre;
            txt_telefono.Text = vendedor.Telefono;
            txt_direcc.Text = vendedor.Direccion;
            txt_email.Text = vendedor.Email;
            combo_tipo.SelectedIndex = vendedor.Tipo == "0" ? 0 : 1;
            check_activo.Checked = vendedor.Activo;
            check_comixrango.Checked = vendedor.ComisionR;
            txt_comision.Text = Convert.ToString(vendedor.Comision);
            this.Habilitar();
            txt_codigo.ReadOnly = true;
            combo_tipo.Focus();

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Reportes.FormReportesVend form = new Reportes.FormReportesVend();
            form.MdiParent = this.MdiParent;
            form.Show();
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}
