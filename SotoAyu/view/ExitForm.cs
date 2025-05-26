using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotoAyu.view
{
    public partial class ExitForm : Form
    {
        MainForm MainForm;
        public ExitForm(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void cuiButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButtonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.LoadControl(new UCLogin(MainForm));
            
        }
    }
}
