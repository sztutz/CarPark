using System.Text;
using System.Text;
using System.IO;

namespace VehicleRegistrationStation
{
    public partial class Form1 : Form
    {
        // Create a list of VehicleRegistrations
        List<Vehicle> vehicles = new List<Vehicle>();
        // The location of where the file will be saved
        string path = @"c:\Users\TEMP\demo_01.txt";
        public Form1()
        {
            InitializeComponent();
        }



        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:/Users/Utente/source/repos";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void ButtonEnterRego_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTag_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLinearSearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteRego_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEditRego_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string regNum = TextBoxInput.Text;
            vehicles.Add(new Vehicle(regNum));

        }
    }
}