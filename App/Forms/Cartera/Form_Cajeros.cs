using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Types;
using Negocios.Cartera;

namespace App.Forms.Cartera
{
    public partial class Form_Cajeros : Form
    {
        private CajeroN negocioCajero;

        private string botonclick;

        public Form_Cajeros()
        {
            this.negocioCajero = new CajeroN();
            this.InitializeComponent();
            this.CargarCajero();
        }

        #region VISUALIZACION

        private void CargarCajero()
        {
            List<CajeroDataSource> tablacajero = new List<CajeroDataSource>();
            tablacajero = this.negocioCajero.CargarCajero();
            dgv_cajero.DataSource = tablacajero;
            dgv_cajero.Columns[0].HeaderText = "Código";
            dgv_cajero.Columns[1].HeaderText = "Nombre";
            dgv_cajero.Columns[2].Visible = false;
            dgv_cajero.Columns[3].Visible = false;
            dgv_cajero.Columns[1].Width = 250;
        }

        private void CamposActivos()
        {
            txt_nombre.Enabled = true;
            txt_user.Enabled = true;
            txt_contra.Enabled = true;
            txt_clave2.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_nombre.Enabled = false;
            txt_user.Enabled = false;
            txt_contra.Enabled = false;
            txt_clave2.Enabled = false;
        }

        private void CamposLimpios()
        {
            txt_nombre.Text = string.Empty;
            txt_user.Text = string.Empty;
            txt_contra.Text = string.Empty;
            txt_clave2.Text = string.Empty;
        }

        #endregion

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            this.botonclick = "agregar";
            this.btn_guardar.Enabled = true;
            txt_codigo.Text = Convert.ToString(this.negocioCajero.ObtenerCodigo());
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool valida = this.ValidarCampos();
            if (valida)
            {
                CajeroDataSource cajer = new CajeroDataSource();
                cajer = this.GuardarDatos();
                bool existe = this.negocioCajero.ExisteCajero(cajer.UsuarioCajero);
                if (!existe)
                {
                    bool guardo = this.negocioCajero.GuardarCajero(cajer);
                    if (guardo)
                    {
                        MessageBox.Show("El cajero ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                        this.CamposLimpios();
                        this.CargarCajero();
                        this.CamposInactivos();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya se encuentra registrado", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        private CajeroDataSource GuardarDatos()
        {
            if (this.botonclick.Equals("editar"))
            {
            }
            CajeroDataSource cajero = new CajeroDataSource();
            cajero.CodigoCajero = int.Parse(txt_codigo.Text);
            cajero.NombreCajero = txt_nombre.Text;
            cajero.UsuarioCajero = txt_user.Text;
            cajero.ClaveCajero = txt_contra.Text;
            return cajero;
        }

        private bool ValidarCampos()
        {
            bool valida = false;
            if (!txt_nombre.Text.Equals(string.Empty) && !txt_user.Text.Equals(string.Empty) && !txt_contra.Text.Equals(string.Empty)
                && !txt_clave2.Text.Equals(string.Empty))
            {
                if (txt_contra.Text.Equals(txt_clave2.Text))
                {
                    valida = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir", "ERROR", MessageBoxButtons.OK);
                    valida = false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos", "ERROR", MessageBoxButtons.OK);
                valida = false;
            }

            return valida;
        }

        private void dgv_cajero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_cajero.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.botonclick = "editar";
        }
    }
}
