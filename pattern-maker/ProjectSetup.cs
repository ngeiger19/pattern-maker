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
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text;
            string yarn = txtYarn.Text;
            
            string unit;
            if (radInches.Checked) { unit = "Inches"; }
            else { unit = "Centimeters"; }
            string gaugeMeasurement = numGaugeMeasurementW.Value + " x " + numGaugeMeasurementH.Value + " " + unit;
            string gaugeStites = numGaugeStitchesW.Value + " x " + numGaugeStitchesH.Value + " Stitches";

            // Displays a SaveFileDialog to save project info
            SaveFileDialog saveFileDialogNewProject = new SaveFileDialog();
            saveFileDialogNewProject.Filter = "Text File|*.txt";
            saveFileDialogNewProject.Title = "Save Project File";
            saveFileDialogNewProject.FileName = txtProjectName.Text;
            saveFileDialogNewProject.ShowDialog();

            // If the file name is not an empty, open to write and save
            if (saveFileDialogNewProject.FileName != "")
            {
                // Saves the file by opening with OpenFile() and writes project info to the file
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialogNewProject.OpenFile());
                writer.Write(
                    "Project Name: " + txtProjectName.Text
                    + "\nYarn: " + txtYarn.Text
                    + "\nGauge: " + gaugeStites + " in " + gaugeMeasurement
                    + "\nCreated: " + DateTime.Now
                    );
                writer.Close();
                writer.Dispose();
            }
        }

        private void saveFileDialogNewProject_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
