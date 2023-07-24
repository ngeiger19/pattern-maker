using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            /*
             * SettingsForm newSettingsForm = new SettingsForm();
             * newSettingsForm.ShowDialog();
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
            // Open selected file and read project info.
            OpenFileDialog openFileDialogLoad = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Load Project",

                DefaultExt = "txt",
                Filter = "Text Files|*.txt"
            };

            // test
            if (openFileDialogLoad.ShowDialog() == DialogResult.OK)
            {
                lblHeading.Text = openFileDialogLoad.FileName;
            }

            /* Workspace newWorkspace = new Workspace();
             * newWorkspace.Show();
             * Hide();
             */
        }

        private void openFileDialogLoad_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
