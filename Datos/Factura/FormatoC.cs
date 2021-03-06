﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace Datos.Factura
{
    public class FormatoC
    {
        public FormatoC()
        {
        }

        public bool Existe(int codigofor, int tipofor)
        {
            bool exist = false;
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.formato
                                .Where(frm => frm.codigofor == codigofor && frm.codigotipo == tipofor).Count();
                    if (query > 0)
                    {
                        exist = true;
                    }
                    else
                    {
                        exist = false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return exist;
        }

        public List<tipoformato> CargarCampos(int tipoform)
        {
            List<tipoformato> tipo = new List<tipoformato>();
            using (siimnEntities bd = new siimnEntities())
            {
                try
                {
                    var query = bd.tipoformato.Where(frm => frm.codigotipo == tipoform);
                    if (query.Count() > 0)
                    {
                        tipo = query.ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tipo;
        }
    }
}
