using CuoreUI.Components;
using SotoAyu.view;

namespace SotoAyu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadControl(new UCLogin(this));
            //LoadControl(new UCDasboardAdmin(this));

        }

        public void LoadControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

    }
}
