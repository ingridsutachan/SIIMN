﻿namespace App.Forms.Cartera
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Entities.Types;
    using Negocios.Cartera;
    using Negocios.Contable;

    public partial class Frm_Clientes : Form
    {
        private ClientesN negocioClientes;

        private Ubicacionn negociosUbicacion;

        private Cuentan negocioCuenta;

        private Funciones funtions;

        private VendedorN negocioVendedor;

        private string botonClick = "0";

        private bool usrClose = false;

        public Frm_Clientes()
        {
            this.negocioClientes = new ClientesN();
            this.negociosUbicacion = new Ubicacionn();
            this.negocioCuenta = new Cuentan();
            this.funtions = new Funciones();
            this.negocioVendedor = new VendedorN();
            this.InitializeComponent();
            this.CargarPaises();
            this.CargarClientes();
            this.AutoCompletar();
        }

        #region VISUALIZACION

        private void CargarClientes()
        {
            List<ClientesDataSource> tablaClientes = new List<ClientesDataSource>();
            tablaClientes = this.negocioClientes.CargarClientes();
            dgvcliente.DataSource = tablaClientes;
            this.NombresTabla();
        }

        private void NombresTabla()
        {
            dgvcliente.Columns[0].HeaderText = "Código";
            dgvcliente.Columns[1].HeaderText = "NIT";
            dgvcliente.Columns[2].HeaderText = "Digito";
            dgvcliente.Columns[3].HeaderText = "Nombre";
            dgvcliente.Columns[4].HeaderText = "Factura a Nombre";
            dgvcliente.Columns[5].HeaderText = "Bloqueado";
            dgvcliente.Columns[7].HeaderText = "País";
            dgvcliente.Columns[9].HeaderText = "Departamento";
            dgvcliente.Columns[11].HeaderText = "Ciudad";
            dgvcliente.Columns[12].HeaderText = "Dirección";
            dgvcliente.Columns[13].HeaderText = "Dirección de envio";
            dgvcliente.Columns[14].HeaderText = "Telefono";
            dgvcliente.Columns[15].HeaderText = "Celular";
            dgvcliente.Columns[16].HeaderText = "Fax";
            dgvcliente.Columns[17].HeaderText = "Email";
            dgvcliente.Columns[18].HeaderText = "Plazo";
            dgvcliente.Columns[19].HeaderText = "Cupo Mes";
            dgvcliente.Columns[20].HeaderText = "Descuento";
            dgvcliente.Columns[21].HeaderText = "Regimen";
            dgvcliente.Columns[23].HeaderText = "Vendedor";
            dgvcliente.Columns[24].HeaderText = "Gran Contribuyente";
            dgvcliente.Columns[25].HeaderText = "Causa Retención I.C.A";
            dgvcliente.Columns[26].HeaderText = "Aplicar Retención I.C.A";
            dgvcliente.Columns[27].HeaderText = "Causa RETEIVA";
            dgvcliente.Columns[28].HeaderText = "Descuenta RETEIVA";
            dgvcliente.Columns[29].HeaderText = "Retención por comprar";
            dgvcliente.Columns[30].HeaderText = "Descontar retención";
            dgvcliente.Columns[31].HeaderText = "% Retencón";
            dgvcliente.Columns[32].HeaderText = "Jefe de Compras";
            dgvcliente.Columns[33].HeaderText = "Comprador";
            dgvcliente.Columns[34].HeaderText = "Cuenta";
            dgvcliente.Columns[2].Width = 70;
            dgvcliente.Columns[6].Visible = false;
            dgvcliente.Columns[8].Visible = false;
            dgvcliente.Columns[10].Visible = false;
            dgvcliente.Columns[22].Visible = false;
            dgvcliente.Columns[35].Visible = false;
            dgvcliente.Columns[0].Width = 50;
            dgvcliente.Columns[1].Width = 90;
            dgvcliente.Columns[2].Width = 50;
            dgvcliente.Columns[3].Width = 150;
            dgvcliente.Columns[4].Width = 150;
            dgvcliente.Columns[5].Width = 70;
        }

        private void CamposActivos()
        {
            txt_codigo.Enabled = true;
            txt_numeronit.Enabled = true;
            txt_digito.Enabled = true;
            txt_nombre.Enabled = true;
            txt_facturanom.Enabled = true;
            combo_pais.Enabled = true;
            combo_dpto.Enabled = true;
            combo_ciudad.Enabled = true;
            txt_direccion.Enabled = true;
            txt_direnvio.Enabled = true;
            txt_telefono.Enabled = true;
            txt_celular.Enabled = true;
            txt_fax.Enabled = true;
            txt_email.Enabled = true;
            txt_plazo.Enabled = true;
            txt_cupo.Enabled = true;
            txt_dto.Enabled = true;
            radio_comun.Enabled = true;
            radio_simpi.Enabled = true;
            txt_vendedor.Enabled = true;
            check_grancontri.Enabled = true;
            check_causretica.Enabled = true;
            check_apliretica.Enabled = true;
            check_desreteiva.Enabled = true;
            check_causreteiva.Enabled = true;
            check_retexcomprar.Enabled = true;
            check_descreten.Enabled = true;
            txt_jefecompras.Enabled = true;
            txt_comprador.Enabled = true;
            txt_cuenta.Enabled = true;
        }

        private void CamposInactivos()
        {
            txt_codigo.Enabled = false;
            txt_numeronit.Enabled = false;
            txt_digito.Enabled = false;
            txt_nombre.Enabled = false;
            txt_facturanom.Enabled = false;
            combo_pais.Enabled = false;
            combo_dpto.Enabled = false;
            combo_ciudad.Enabled = false;
            txt_direccion.Enabled = false;
            txt_direnvio.Enabled = false;
            txt_telefono.Enabled = false;
            txt_celular.Enabled = false;
            txt_fax.Enabled = false;
            txt_email.Enabled = false;
            txt_plazo.Enabled = false;
            txt_cupo.Enabled = false;
            txt_dto.Enabled = false;
            radio_comun.Enabled = false;
            radio_simpi.Enabled = false;
            txt_vendedor.Enabled = false;
            check_grancontri.Enabled = false;
            check_causretica.Enabled = false;
            check_apliretica.Enabled = false;
            check_desreteiva.Enabled = false;
            check_causreteiva.Enabled = false;
            check_retexcomprar.Enabled = false;
            check_descreten.Enabled = false;
            radio_por15.Enabled = false;
            radio_por35.Enabled = false;
            txt_jefecompras.Enabled = false;
            txt_comprador.Enabled = false;
            txt_cuenta.Enabled = false;
        }

        private void CamposLimpios()
        {
            txt_codigo.Text = string.Empty;
            txt_numeronit.Text = string.Empty;
            txt_digito.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_facturanom.Text = string.Empty;
            combo_pais.Text = string.Empty;
            combo_dpto.Text = string.Empty;
            combo_ciudad.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_direnvio.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_celular.Text = string.Empty;
            txt_fax.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_plazo.Text = string.Empty;
            txt_cupo.Text = string.Empty;
            txt_dto.Text = string.Empty;
            radio_comun.Checked = false;
            radio_simpi.Checked = false;
            txt_vendedor.Text = string.Empty;
            check_grancontri.Checked = false;
            check_causretica.Checked = false;
            check_apliretica.Checked = false;
            check_desreteiva.Checked = false;
            check_causreteiva.Checked = false;
            check_retexcomprar.Checked = false;
            check_descreten.Checked = false;
            radio_por15.Checked = false;
            radio_por35.Checked = false;
            txt_jefecompras.Text = string.Empty;
            txt_comprador.Text = string.Empty;
            txt_cuenta.Text = string.Empty;
            txt_nombrevend.Text = string.Empty;
            txt_cuenta.Text = string.Empty;
            txt_nombrecuenta.Text = string.Empty;
        }

        private void AutoCompletar()
        {
            CuentaDataSource cuenta = new CuentaDataSource();
            var items = this.negocioCuenta.CargarCuenta();
            AutoCompleteStringCollection cuentas = new AutoCompleteStringCollection();
            foreach (var item in items)
            {
                cuentas.Add(item.Cuenta);
                cuentas.Add(item.Nombre);
            }

            txt_cuenta.AutoCompleteCustomSource = cuentas;
        }

        /// <summary>
        /// Cargar los paises en el combobox
        /// </summary>
        private void CargarPaises()
        {
            try
            {
                combo_pais.DataSource = this.negociosUbicacion.CargarPais();
                combo_pais.ValueMember = "idpais";
                combo_pais.DisplayMember = "nombrepais";
                if (!this.botonClick.Equals("editar"))
                {
                    combo_pais.SelectedIndex = 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }

        /// <summary>
        /// Cargar los departamentos en el combobox
        /// </summary>
        /// <param name="idpais">The idpais.</param>
        private void CargarDeptos(int idpais)
        {
            try
            {
                combo_dpto.DataSource = this.negociosUbicacion.CargarDeptos(idpais);
                combo_dpto.ValueMember = "iddpto";
                combo_dpto.DisplayMember = "nombredpto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }
        }

        /// <summary>
        /// Cargar las ciudades en el combobox
        /// </summary>
        /// <param name="iddepto">The iddepto.</param>
        private void CargarCiudades(int iddepto)
        {
            try
            {
                combo_ciudad.DataSource = this.negociosUbicacion.CargarCiudad(iddepto);
                combo_ciudad.ValueMember = "idciudad";
                combo_ciudad.DisplayMember = "nombreciudad";
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
            ClientesDataSource clientes = new ClientesDataSource();
            bool valida = this.ValidarGuardar();
            if (valida)
            {
                clientes = this.GuardarDatos();
                if (this.botonClick.Equals("agregar"))
                {
                    bool guardo = this.negocioClientes.GuardarCliente(clientes);
                    if (guardo)
                    {
                        MessageBox.Show("El Cliente ha sido guardado", "GUARDAR", MessageBoxButtons.OK);
                    }
                }

                if (this.botonClick.Equals("editar"))
                {
                    bool guardo = this.negocioClientes.ActualizarCliente(clientes);
                    if (guardo)
                    {
                        MessageBox.Show("El Cliente se ha actualizado", "GUARDAR", MessageBoxButtons.OK);
                    }
                }

                this.CargarClientes();
                this.CamposLimpios();
                this.CamposInactivos();
            }
        }

        private bool ValidarGuardar()
        {
            bool valida = false;
            if (!txt_numeronit.Text.Equals(string.Empty) && !txt_digito.Text.Equals(string.Empty) && !txt_nombre.Text.Equals(string.Empty) && !txt_facturanom.Text.Equals(string.Empty)
                && !txt_direccion.Text.Equals(string.Empty) && !txt_direnvio.Text.Equals(string.Empty) && !txt_comprador.Text.Equals(string.Empty) && !txt_celular.Text.Equals(string.Empty)
                && !txt_plazo.Text.Equals(string.Empty) && !txt_cupo.Text.Equals(string.Empty) && !txt_dto.Text.Equals(string.Empty)
                && (radio_comun.Checked == true || radio_simpi.Checked == true) && !txt_vendedor.Text.Equals(string.Empty) && !txt_jefecompras.Text.Equals(string.Empty)
                && !txt_comprador.Text.Equals(string.Empty) && !txt_cuenta.Text.Equals(string.Empty) && !txt_nombrecuenta.Text.Equals("Cuenta General") && !txt_nombrecuenta.Text.Equals("Cuenta no Existente"))
            {
                if (!txt_nombrevend.Text.Equals("No Existe"))
                {
                    if (!txt_email.Text.Equals(string.Empty))
                    {
                        if (txt_email.Text.Contains(".") && txt_email.Text.Contains("@"))
                        {
                            valida = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una cuenta de correo valida", "ERROR", MessageBoxButtons.OK);
                            valida = false;
                        }
                    }
                    else
                    {
                        valida = true;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un vendedor valido", "ERROR", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos", "INCOMPLETO", MessageBoxButtons.OK);
                valida = false;
            }

            return valida;
        }

        private ClientesDataSource GuardarDatos()
        {
            ClientesDataSource cliente = new ClientesDataSource();
            cliente.CodigoCliente = int.Parse(txt_codigo.Text);
            cliente.NitCliente = txt_numeronit.Text;
            cliente.DigitoCliente = txt_digito.Text;
            cliente.NombreCliente = txt_nombre.Text;
            cliente.FacturaNombre = txt_facturanom.Text;
            cliente.IdPais = combo_pais.SelectedValue.ToString();
            cliente.IdCiudad = int.Parse(combo_ciudad.SelectedValue.ToString());
            cliente.IdDpto = int.Parse(combo_dpto.SelectedValue.ToString());
            cliente.Direccion = txt_direccion.Text;
            cliente.DirEnvio = txt_direnvio.Text;
            cliente.Telefono = txt_telefono.Text;
            cliente.Celular = txt_celular.Text;
            cliente.Fax = txt_fax.Text;
            cliente.Email = txt_email.Text;
            cliente.Plazo = int.Parse(txt_plazo.Text);
            cliente.CupoMes = int.Parse(txt_cupo.Text);
            cliente.Descuento = Convert.ToDecimal(txt_dto.Text);
            cliente.Regimen = radio_comun.Checked == true ? "1" : "2";
            cliente.IdVendedor = int.Parse(txt_vendedor.Text);
            cliente.GranContrib = check_grancontri.Checked;
            cliente.CausaReteIca = check_causretica.Checked;
            cliente.AplicaReteIca = check_apliretica.Checked;
            cliente.CausaReteIva = check_causreteiva.Checked;
            cliente.DescReteIva = check_desreteiva.Checked;
            cliente.ReteXComprar = check_retexcomprar.Checked;
            cliente.DesconReteVendedor = check_descreten.Checked;
            cliente.PorRetencion = check_descreten.Checked == false ? 0 : radio_por15.Checked == true ? Convert.ToDecimal(1.5) : Convert.ToDecimal(3.5);
            cliente.JefeCompras = txt_jefecompras.Text;
            cliente.Comprador = txt_comprador.Text;
            int valor = 0;
            string cuenta = !int.TryParse(txt_cuenta.Text, out valor) ? txt_nombrecuenta.Text : txt_cuenta.Text;
            cliente.Cuenta = cuenta;
            return cliente;
        }

        #endregion

        #region BOTONES CLICK

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.CamposActivos();
            txt_codigo.Text = Convert.ToString(this.negocioClientes.ObtenerCodigo());
            btn_guardar.Enabled = true;
            this.botonClick = "agregar";
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvcliente.CurrentRow.Cells[0].Value.ToString());
            ClientesDataSource cliente = new ClientesDataSource();
            btn_guardar.Enabled = true;
            this.botonClick = "editar";
            try
            {
                cliente = this.negocioClientes.DevolverCliente(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un error. " + ex.Message);
            }

            this.CamposActivos();
            this.CargarPaises();
           // this.CargarDeptos(cliente.IdPais);
            this.CargarCiudades(cliente.IdDpto);
            txt_codigo.Text = Convert.ToString(cliente.CodigoCliente);
            txt_numeronit.Text = cliente.NitCliente;
            txt_digito.Text = cliente.DigitoCliente;
            txt_nombre.Text = cliente.NombreCliente;
            txt_facturanom.Text = cliente.FacturaNombre;
            combo_pais.SelectedValue = cliente.IdPais;
            combo_ciudad.SelectedValue = cliente.IdCiudad;
            combo_dpto.SelectedValue = cliente.IdDpto;
            txt_direccion.Text = cliente.Direccion;
            txt_direnvio.Text = cliente.DirEnvio;
            txt_telefono.Text = cliente.Telefono;
            txt_celular.Text = cliente.Celular;
            txt_fax.Text = cliente.Fax;
            txt_email.Text = cliente.Email;
            txt_plazo.Text = Convert.ToString(cliente.Plazo);
            txt_cupo.Text = Convert.ToString(cliente.CupoMes);
            txt_dto.Text = Convert.ToString(cliente.Descuento);
            radio_comun.Checked = cliente.Regimen == "1" ? true : false;
            txt_vendedor.Text = Convert.ToString(cliente.IdVendedor);
            txt_nombrevend.Text = cliente.NombreVendedor;
            check_grancontri.Checked = cliente.GranContrib;
            check_causretica.Checked = cliente.CausaReteIca;
            check_apliretica.Checked = cliente.AplicaReteIca;
            check_causreteiva.Checked = cliente.CausaReteIva;
            check_desreteiva.Checked = cliente.DescReteIva;
            check_retexcomprar.Checked = cliente.ReteXComprar;
            check_descreten.Checked = cliente.DesconReteVendedor;
            radio_por15.Checked = cliente.PorRetencion == Convert.ToDecimal(1.5) ? true : false;
            radio_por35.Checked = cliente.PorRetencion == Convert.ToDecimal(3.5) ? true : false;
            txt_jefecompras.Text = cliente.JefeCompras;
            txt_comprador.Text = cliente.Comprador;
            txt_cuenta.Text = cliente.Cuenta;
            txt_nombrecuenta.Text = cliente.NombreCuenta;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.CamposLimpios();
            this.CamposInactivos();
            int idcli_eliminar = int.Parse(dgvcliente.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.negocioClientes.EliminarCliente(idcli_eliminar))
                    {
                        MessageBox.Show("Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se presento un error. " + ex.Message);
                }

                this.CargarClientes();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            List<ClientesDataSource> clientes = new List<ClientesDataSource>();
            try
            {
                clientes = this.negocioClientes.BuscarCliente(txt_buscar.Text);
                if (clientes.Count > 0)
                {
                    dgvcliente.DataSource = clientes;
                    this.NombresTabla();
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

        #region ENTERTAB

        private void EnterTabVal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EnterTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Txt_cuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string result = this.funtions.ValidaCuentaoNombre(txt_cuenta.Text);
                txt_nombrecuenta.Text = result;
                if (result.Equals("Cuenta General") || result.Equals("Cuenta no Existente"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void Txt_dto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NombreClienteEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            txt_facturanom.Text = txt_nombre.Text;
        }

        private void DireccionEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            txt_direnvio.Text = txt_direccion.Text;
        }

        private void Txt_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!txt_vendedor.Text.Equals(string.Empty))
                {
                    string nombreven = this.negocioVendedor.DevolverNombre(int.Parse(txt_vendedor.Text));
                    if (nombreven.Equals("NoExiste"))
                    {
                        e.Handled = true;
                        txt_nombrevend.Text = "No Existe";
                    }
                    else
                    {
                        e.Handled = false;
                        SendKeys.Send("{TAB}");
                        txt_nombrevend.Text = nombreven;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region EVENTOS

        private void Check_descreten_CheckStateChanged(object sender, EventArgs e)
        {
            if (check_descreten.Checked == true)
            {
                radio_por15.Enabled = true;
                radio_por35.Enabled = true;
            }
            else
            {
                radio_por15.Enabled = false;
                radio_por35.Enabled = false;
            }
        }

        private void Combo_pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idpais = int.Parse(combo_pais.SelectedValue.ToString());
            this.CargarDeptos(idpais);
        }

        private void Combo_dpto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idepto = int.Parse(combo_dpto.SelectedValue.ToString());
            this.CargarCiudades(idepto);
        }

        private void Dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcliente.SelectedCells.Count > 0)
            {
                btn_editar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }
        #endregion

        #region SALIR FORMULARIO

        private void Salircuent_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.usrClose = true;
                this.Close();
            }
        }

        private void Frm_Clientes_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                EventArgs eve = new EventArgs();
                this.btn_buscar_Click(sender, eve);
                if (txt_buscar.Text.Equals(string.Empty))
                {
                    this.CargarClientes();
                }
            }
        }

        #endregion

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
