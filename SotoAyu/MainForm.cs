using CuoreUI.Components;
using SotoAyu.view;

namespace SotoAyu
{
    public partial class MainForm : Form
    {
        public MainForm(string login)
        {
            InitializeComponent();
            if(login == "admin")
            {
                LoadControl(new UCDasboardAdmin());
            }
            else
            {
                LoadControl(new UCDasboardKasir());
            }
        }

        private void LoadControl(UserControl uc)
        {
            this.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }



    }
}
