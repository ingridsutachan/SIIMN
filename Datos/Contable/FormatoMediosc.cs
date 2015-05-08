using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.Contable
{
    public class FormatoMediosc
    {
        public FormatoMediosc()
        {
        }

        public int? DevolverId(string formato)
        {
            try
            {
                using (siimnEntities bd = new siimnEntities())
                {
                    var query = bd.formatomedios.Where(fom => fom.numeroformatos == formato);
                    if (query.Count() > 0)
                    {
                        return query.First().idformatomedios;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
