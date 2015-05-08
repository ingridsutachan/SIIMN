////*********************************************************
//
//    <copyright file="MyTabPage.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public class MyTabPage : TabPage
    {
        private Form frm;

        //public int contadorpestana;

        public MyTabPage(MyFormPage frm_contenido)
        {
            this.frm = frm_contenido;
            this.Controls.Add(frm_contenido.pnl);
            this.Text = frm_contenido.Text;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
    public class MyFormPage : Form
    {
        public Panel pnl;

    }
}
