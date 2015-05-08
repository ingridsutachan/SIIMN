using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace App.Forms.Contable
{
    public partial class Form_ProgresBar : Form
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Image Picture { get; set; }
        public Action ActionToExecute { get; set; } 

        public Form_ProgresBar()
        {
            this.InitializeComponent();
            this.Shown += fSplashScreen_Shown;
        }

        void fSplashScreen_Shown(object sender, EventArgs e)
        {
            titleLabel.Text = Title;
            messageLabel.Text = Message;
           pictureBox.Image = Picture;
            Task.Factory.StartNew(ActionToExecute).ContinueWith((t) => taskCompleted());
        }

        private void taskCompleted()
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }
    }
}
