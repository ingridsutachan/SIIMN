namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Cartera;

    public partial class Form_Bantar : Form
    {
        private BantarN negocioBantar;

        private string butonclick;

        private bool usrClose;

        public Form_Bantar()
        {
            this.negocioBantar = new BantarN();

            this.InitializeComponent();
            this.CargarBantar();
        }

        #region VISUALIZACION

        private void CargarBantar()
        {
            List<BantarDataSource> tablabantar = new List<BantarDataSource>();
            tablabantar = this.negocioBantar.CargarBantar();
            dgv_bantar.DataSource = tablabantar;
            dgv_bantar.Columns[0].HeaderText = "Código";
            dgv_bantar.Columns[1].HeaderText = "Nombre";
            dgv_bantar.Columns[2].HeaderText = "Tipo";
            dgv_bantar.Columns[1].Width = 150;
        }

        private void CamposActivos()
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            check_banco.Enabled = true;
            check_tarjeta.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            check_banco.Enabled = false;
            check_tarjeta.Enabled = false;
            btn_guardar.Enabled = false;
        }

        private void CamposLimpios()
        {
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            check_banco.Checked = false;
            check_tarjeta.Checked = false;
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            this.CamposLimpios();
            btn_guardar.Enabled = true;
            this.butonclick = "agregar";
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            BantarDataSource bantar = new BantarDataSource();
            string id = dgv_bantar.CurrentRow.Cells[0].Value.ToString();
            bantar = this.negocioBantar.DevolverBantar(id);
            txt_codigo.Text = bantar.CodigoBantar;
            this.CamposActivos();
            txt_codigo.Enabled = false;
            txt_nombre.Text = bantar.NombreBantar;
            check_banco.Checked = bantar.TipoBantar == "B" ? true : false;
            check_tarjeta.Checked = bantar.TipoBantar == "T" ? true : false;
            this.butonclick = "editar";
            btn_guardar.Enabled = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.CamposInactivos();
            this.CamposLimpios();
            string id = dgv_bantar.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioBantar.EliminarBantar(id))
                    {
                        MessageBox.Show("Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarBantar();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            List<BantarDataSource> bantar = new List<BantarDataSource>();
            try
            {
                bantar = this.negocioBantar.BuscarBantar(txt_buscar.Text);
                if (bantar.Count > 0)
                {
                    dgv_bantar.DataSource = bantar;
                    dgv_bantar.Columns[0].HeaderText = "Código";
                    dgv_bantar.Columns[1].HeaderText = "Nombre";
                    dgv_bantar.Columns[2].HeaderText = "Tipo";
                    dgv_bantar.Columns[1].Width = 150;
                }
                else
                {
                    MessageBox.Show("No se encuentra algún resultado", "BUSQUEDA", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }

        #endregion

        #region GUARDAR

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!txt_codigo.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty) && (check_banco.Checked == true ||
    check_tarjeta.Checked == true))
            {
                BantarDataSource bantar = new BantarDataSource();
                bantar.CodigoBantar = txt_codigo.Text;
                bantar.NombreBantar = txt_nombre.Text;
                bantar.TipoBantar = check_banco.Checked == true ? "B" : "T";

                if (this.butonclick.Equals("agregar"))
                {
                    bool existe = this.negocioBantar.ExisteBantar(txt_codigo.Text);

                    if (!existe)
                    {
                        bool guardo = this.negocioBantar.GuardoBantar(bantar);
                        if (guardo)
                        {
                            MessageBox.Show("El concepto ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                            this.CamposInactivos();
                            this.CamposLimpios();
                            this.CargarBantar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El concepto ya existe", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else if (this.butonclick.Equals("editar"))
                {
                    bool guardo = this.negocioBantar.ActualizarBantar(bantar);
                    if (guardo)
                    {
                        MessageBox.Show("El concepto ha sido actualizado", "GUARDAR", MessageBoxButtons.OK);
                        this.CamposInactivos();
                        this.CamposLimpios();
                        this.CargarBantar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos", "ERROR", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region EVENTOS

        private void Dgv_bantar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_bantar.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }

        private void Txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_buscar_Click(sender, eve);
                if (txt_buscar.Text.Equals(string.Empty))
                {
                    this.CargarBantar();
                }
            }
        }

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Check_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_guardar_Click(sender, eve);
            }
        }
        
        private void Check_banco_CheckStateChanged(object sender, EventArgs e)
        {
            check_tarjeta.Checked = check_banco.Checked == true ? false : true;
        }

        private void Check_tarjeta_CheckStateChanged(object sender, EventArgs e)
        {
            check_banco.Checked = check_tarjeta.Checked == true ? false : true;
        }
        #endregion

        #region SALIR FORMULARIO

        private void Form_Bantar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.usrClose)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Salircuent_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }

        #endregion
    }
}
