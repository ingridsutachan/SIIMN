﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos.Factura;
using Entities.Types;
using Entities;

namespace Negocios.Factura
{
    public class FormatoN
    {
        private FormatoC persistencia;

        public FormatoN()
        {
            this.persistencia = new FormatoC();
        }


        public bool Existe(int codigofor, int tipofor)
        {
            bool exist = false;
            try
            {
                exist = this.persistencia.Existe(codigofor, tipofor);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return exist;
        }

        public List<FormatosDataSource> CargarCampos(int tipoform)
        {
            List<FormatosDataSource> format = new List<FormatosDataSource>();
            try
            {
                var items = this.persistencia.CargarCampos(tipoform);
                foreach (var item in items)
                {
                    FormatosDataSource fot = new FormatosDataSource();
                    fot.Item = item.nombretipo;
                    fot.Activo = true;
                    format.Add(fot);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return format;
        }
    }
}
