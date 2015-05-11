namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Cartera;

    public partial class Form_Concep_ing : Form
    {
        private ConceptosN negocioConcepto;

        private string butonclick;

        private bool usrClose;

        private Funciones funtions;

        public Form_Concep_ing()
        {
            this.negocioConcepto = new ConceptosN();
            this.funtions = new Funciones();
            this.InitializeComponent();
            this.CargarConceptos();
        }

        #region VISUALIZACION

        private void CargarConceptos()
        {
            List<ConceptosDataSource> tablaConceptos = new List<ConceptosDataSource>();
            tablaConceptos = this.negocioConcepto.CargarConceptos();
            dgv_concepto.DataSource = tablaConceptos;
            dgv_concepto.Columns[0].HeaderText = "Código";
            dgv_concepto.Columns[1].HeaderText = "Nombre";
            dgv_concepto.Columns[1].Width = 150;
        }

        #endregion

        #region GUARDAR

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (!txt_codigo.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty))
            {
                ConceptosDataSource concepto = new ConceptosDataSource();
                concepto.CodigoConcepto = int.Parse(txt_codigo.Text);
                concepto.NombreConcepto = txt_nombre.Text;

                if (this.butonclick.Equals("agregar"))
                {
                    bool existe = this.negocioConcepto.ExisteConcepto(int.Parse(txt_codigo.Text));
                    if (!existe)
                    {
                        bool guardo = this.negocioConcepto.GuardoConcepto(concepto);
                        if (guardo)
                        {
                            MessageBox.Show("El concepto ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                            txt_codigo.Enabled = false;
                            txt_nombre.Enabled = false;
                            txt_codigo.Text = string.Empty;
                            txt_nombre.Text = string.Empty;
                            this.CargarConceptos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El concepto ya existe", "ERROR", MessageBoxButtons.OK);
                    }
                }
                else if (this.butonclick.Equals("editar"))
                {
                    bool guardo = this.negocioConcepto.ActualizarConcepto(concepto);
                    if (guardo)
                    {
                        MessageBox.Show("El concepto ha sido actualizado", "GUARDAR", MessageBoxButtons.OK);
                        txt_codigo.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_codigo.Text = string.Empty;
                        txt_nombre.Text = string.Empty;
                        this.CargarConceptos();
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

        private void Dgv_concepto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_concepto.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }

        private void Txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.Btn_guardar_Click(sender, eve);
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
                    this.CargarConceptos();
                }
            }
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            txt_nombre.Enabled = true;
            btn_guardar.Enabled = true;
            this.butonclick = "agregar";
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            ConceptosDataSource concepto = new ConceptosDataSource();
            int id = int.Parse(dgv_concepto.CurrentRow.Cells[0].Value.ToString());
            concepto = this.negocioConcepto.DevolverConcepto(id);
            txt_codigo.Text = Convert.ToString(concepto.CodigoConcepto);
            txt_codigo.Enabled = false;
            txt_nombre.Text = concepto.NombreConcepto;
            txt_nombre.Enabled = true;
            this.butonclick = "editar";
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_codigo.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            int id = int.Parse(dgv_concepto.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioConcepto.EliminarConcepto(id))
                    {
                        MessageBox.Show("Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarConceptos();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            List<ConceptosDataSource> concepto = new List<ConceptosDataSource>();
            try
            {
                concepto = this.negocioConcepto.BuscarConcepto(txt_buscar.Text);
                if (concepto.Count > 0)
                {
                    dgv_concepto.DataSource = concepto;
                    dgv_concepto.Columns[0].HeaderText = "Código";
                    dgv_concepto.Columns[1].HeaderText = "Nombre";
                    dgv_concepto.Columns[1].Width = 150;
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

        #region SALIR FORMULARIO

        private void Form_Concep_ing_FormClosing(object sender, FormClosingEventArgs e)
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
