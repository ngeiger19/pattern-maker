using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace pattern_maker
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            /*
            SettingsForm newSettingsForm = new SettingsForm();
            newSettingsForm.ShowDialog();
             */
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewProject newProjectForm = new NewProject();
            newProjectForm.Show();
            Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadProj = new OpenFileDialog();
            if (loadProj.ShowDialog() == DialogResult.OK)
            {
                // 1. Extract project info from file
                // 2. Open workspace with project info
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
