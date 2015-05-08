////*********************************************************
//
//    <copyright file="frmmenu.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Cartera;
    using Contable;
    using Factura;
    using Inventario;
    using Nomina;

    /// <summary>
    /// Clase de formulario menu 
    /// </summary>
    public partial class Frmmenu : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frmmenu"/> class.
        /// </summary>
        public Frmmenu()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Btn_contabilidad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Btn_contabilidad_Click(object sender, System.EventArgs e)
        {
            Frmmenucont form = Application.OpenForms["Frmmenucont"] as Frmmenucont;
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                Frmmenucont frm = new Frmmenucont();
                frm.Show();
                frm.TopMost = true;
            }

        }

        private void btncartera_Click(object sender, EventArgs e)
        {
            FormCarteraMenu form = Application.OpenForms["FormCarteraMenu"] as FormCarteraMenu;
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                FormCarteraMenu frm = new FormCarteraMenu();
                frm.Show();
                frm.TopMost = true;
            }
        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            Form_FacturaMenu form = Application.OpenForms["Form_FacturaMenu"] as Form_FacturaMenu;
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                Form_FacturaMenu frm = new Form_FacturaMenu();
                frm.Show();
                frm.TopMost = true;
            }
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Form_InventarioMenu form = Application.OpenForms["Form_InventarioMenu"] as Form_InventarioMenu;
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                Form_InventarioMenu frm = new Form_InventarioMenu();
                frm.Show();
                frm.TopMost = true;
            }
        }

        private void btn_nomina_Click(object sender, EventArgs e)
        {
            Form_NominaMenu form = Application.OpenForms["Form_NominaMenu"] as Form_NominaMenu;
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                Form_NominaMenu frm = new Form_NominaMenu();
                frm.Show();
                frm.TopMost = true;
            }
        }
    }
}
