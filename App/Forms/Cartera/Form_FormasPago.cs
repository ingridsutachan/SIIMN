namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Cartera;

    public partial class Form_FormasPago : Form
    {
        private FormasPagoN negocioFormas;

        private string butonclick;

        private bool usrClose;

        public Form_FormasPago()
        {
            this.negocioFormas = new FormasPagoN();

            this.InitializeComponent();

            this.CargarFormas();
        }

        #region VISUALIZACION

        private void CargarFormas()
        {
            List<FormasPagoDataSource> tablaformas = new List<FormasPagoDataSource>();
            tablaformas = this.negocioFormas.CargarFormas();
            dgv_formas.DataSource = tablaformas;
            dgv_formas.Columns[0].HeaderText = "Código";
            dgv_formas.Columns[1].HeaderText = "Nombre";
            dgv_formas.Columns[2].HeaderText = "Pide Vencimiento";
            dgv_formas.Columns[1].Width = 150;
        }

        private void CamposActivos()
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            check_vence.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            check_vence.Enabled = false;
            btn_guardar.Enabled = false;
        }

        private void CamposLimpios()
        {
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            check_vence.Checked = false;
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
            FormasPagoDataSource formas = new FormasPagoDataSource();
            string id = dgv_formas.CurrentRow.Cells[0].Value.ToString();
            formas = this.negocioFormas.DevolverFomras(id);
            txt_codigo.Text = formas.CodigoFormas;
            this.CamposActivos();
            txt_codigo.Enabled = false;
            txt_nombre.Text = formas.NombreFormas;
            check_vence.Checked = formas.PideVencimiento;
            this.butonclick = "editar";
            btn_guardar.Enabled = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.CamposInactivos();
            this.CamposLimpios();
            string id = dgv_formas.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioFormas.EliminarForma(id))
                    {
                        MessageBox.Show("Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarFormas();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            List<FormasPagoDataSource> formas = new List<FormasPagoDataSource>();
            try
            {
                formas = this.negocioFormas.BuscarFormas(txt_buscar.Text);
                if (formas.Count > 0)
                {
                    dgv_formas.DataSource = formas;
                    dgv_formas.Columns[0].HeaderText = "Código";
                    dgv_formas.Columns[1].HeaderText = "Nombre";
                    dgv_formas.Columns[2].HeaderText = "Pide Vencimiento";
                    dgv_formas.Columns[1].Width = 150;
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
            if (!txt_codigo.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty))
            {
                FormasPagoDataSource formas = new FormasPagoDataSource();
                formas.CodigoFormas = txt_codigo.Text;
                formas.NombreFormas = txt_nombre.Text;
                formas.PideVencimiento = check_vence.Checked;

                if (this.butonclick.Equals("agregar"))
                {
                    bool existe = this.negocioFormas.ExisteFormas(txt_codigo.Text);

                    if (!existe)
                    {
                        bool guardo = this.negocioFormas.GuardoForma(formas);
                        if (guardo)
                        {
                            MessageBox.Show("El concepto ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                            this.CamposInactivos();
                            this.CamposLimpios();
                            this.CargarFormas();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El concepto ya existe", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else if (this.butonclick.Equals("editar"))
                {
                    bool guardo = this.negocioFormas.ActualizarForma(formas);
                    if (guardo)
                    {
                        MessageBox.Show("El concepto ha sido actualizado", "GUARDAR", MessageBoxButtons.OK);
                        this.CamposInactivos();
                        this.CamposLimpios();
                        this.CargarFormas();
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

        private void Dgv_formas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_formas.SelectedCells.Count > 0)
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
                    this.CargarFormas();
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

        private void Check_vence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_guardar_Click(sender, eve);
            }
        }

        #endregion

        #region SALIR FORMULARIO

        private void Form_FormasPago_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Salircuent_Click(object sender, EventArgs e)
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
