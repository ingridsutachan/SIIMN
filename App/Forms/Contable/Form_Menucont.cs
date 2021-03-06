﻿////*********************************************************
//
//    <copyright file="frmmenucont.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App.Forms.Contable
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Clase formulario del menu contable
    /// </summary>
    public partial class Frmmenucont : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frmmenucont"/> class.
        /// </summary>
        public Frmmenucont()
        {
            this.InitializeComponent();
        }

        #region TECLAS DE ACCESO

        /// <summary>
        /// Teclas de Acceso a los botones
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />mensaje del proceso</param>
        /// <param name="keyData">un <see cref="T:System.Windows.Forms.Keys" /> valor tecla que recibe.</param>
        /// <returns>
        /// true si las teclas correspondiente son ingresadas
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.D1))
            {
                menu_tablas.ShowDropDown();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.D2))
            {
                menu_movimiento.ShowDropDown();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.D3))
            {
                menu_informes.ShowDropDown();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.D4))
            {
                menu_consulta.ShowDropDown();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.D5))
            {
                menu_especial.ShowDropDown();
                return true;
            }


            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        /// <summary>
        /// Handles the Click event of the Salirmencon control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// 

        private void Salirmencon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        /// <summary>
        /// Handles the Click event of the menu_comprobantes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Menu_comprobantes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frmcomprobantes frm = new Frmcomprobantes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Menu_nits_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frmnits frm = new Frmnits();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Menu_presupuesto_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frmpresupuesto frm = new Frmpresupuesto();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Menu_cuentas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Cuenta frmcuenta = new Form_Cuenta();
                frmcuenta.MdiParent = this;
                frmcuenta.Show();
            }
        }

        private void menu_grabarasiento_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Asientos frmasiento = new Form_Asientos();
                frmasiento.MdiParent = this;
                frmasiento.Show();
            }
        }

        private void menui_centrocostos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frmcentro frm = new Frmcentro();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_codtribut_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmTributario frm = new FrmTributario();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_formatos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Formatos frm = new Form_Formatos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_porajustes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Inflacion frm = new Form_Inflacion();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_comprobcierre_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Comprobantecierre frm = new Form_Comprobantecierre();
                frm.MdiParent = this;
                frm.Show();
            }
        }


        private void menu_movsinact_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_MovsinAct frm = new Form_MovsinAct();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_ajustesinfla_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_AjusInflacion frm = new Form_AjusInflacion();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_certificados_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frm_certificados frm = new frm_certificados();
                frm.MdiParent = this;
                frm.Show();
            }
        }



        private void menu_numerarlibros_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_LibrosOficiales frm = new Form_LibrosOficiales();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_acttodos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Actualizar frm = new Form_Actualizar(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_actualizaruno_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Actualizar frm = new Form_Actualizar(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_desactodos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Desactualizar frm = new Form_Desactualizar(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_desactuno_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Desactualizar frm = new Form_Desactualizar(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_libroresum_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_LibroDiario frm = new Form_LibroDiario(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_librodet_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_LibroDiario frm = new Form_LibroDiario(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_listadomedios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_MediosMag frm = new Frm_MediosMag();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_generarmedios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_MediosMag frm = new Frm_MediosMag();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balancemes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Balance frm = new Form_Balance(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balanceanual_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Balance frm = new Form_Balance(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_invbalanc_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Balance frm = new Form_Balance(3);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_libromayor_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_LibroMayor frm = new Form_LibroMayor();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_auxanio_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Auxiliar frm = new Form_Auxiliar(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_auxanual_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Auxiliar frm = new Form_Auxiliar(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_auxasientos_Click(object sender, EventArgs e)
        {
            Form_Auxiliar frm = new Form_Auxiliar(3);
            frm.MdiParent = this;
            frm.Show();
        }

        private void menu_pygacum_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Pyg frm = new Form_Pyg(1,"acumu");
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_pygmes_Click(object sender, EventArgs e)
        {
            Form_Pyg frm = new Form_Pyg(1,"mes");
            frm.MdiParent = this;
            frm.Show();
        }

        private void menu_compames_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Pyg frm = new Form_Pyg(2,"anterior");
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_presup_Click(object sender, EventArgs e)
        {
            Form_Pyg frm = new Form_Pyg(3,"presup");
            frm.MdiParent = this;
            frm.Show();
        }
        private void menu_varcomacum_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Pyg frm = new Form_Pyg(3,"variacumu");
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_comvarmes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Pyg frm = new Form_Pyg(3,"variames");
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_pygacuymes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Pyg frm = new Form_Pyg(1,"acumuymes");
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balanacum_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balanmes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_compmes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balpresup_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(3);
                frm.MdiParent = this;
                frm.Show();
            }
        }
        private void menu_balvariacum_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(3);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balvarmes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(3);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_balacumes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_BalanceGeneral frm = new Frm_BalanceGeneral(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_compcuent_Click(object sender, EventArgs e)
        {
            Frm_comprodiario frm = new Frm_comprodiario(1);
            frm.MdiParent = this;
            frm.Show();
        }

        private void menu_detaasinto_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_comprodiario frm = new Frm_comprodiario(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_centcuent_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_centrosimpr frm = new Frm_centrosimpr();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_cuentcentro_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_centrosimpr frm = new Frm_centrosimpr();
                frm.MdiParent = this;
                frm.Show();
            }
        }


        private void menu_cuencent_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_varpresup frm = new Frm_varpresup(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_centroycuent_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_varpresup frm = new Frm_varpresup(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_certreten_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_certifireten frm = new Frm_certifireten();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_nitcuent_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_Saldosnit frm = new Frm_Saldosnit();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_cuentnit_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Frm_Saldosnit frm = new Frm_Saldosnit();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_saldocuenta_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_Saldocuenta frm = new Form_Saldocuenta();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_saldonit_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_SaldoNit frm = new Form_SaldoNit();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_auxicuenta_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frm_auxcuenta frm = new frm_auxcuenta();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_comproasien_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frm_comproasien frm = new frm_comproasien();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_estadomes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frm_estadosmes frm = new frm_estadosmes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menu_asientnumero_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frm_asientosxnumero frm = new frm_asientosxnumero();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Frmmenucont_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Menu_cierrecuentasresultado_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_CierreCuentas frm = new Form_CierreCuentas(1);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Menu_cierrecuentasimpuestos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Form_CierreCuentas frm = new Form_CierreCuentas(2);
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
