using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ForgetMeNot
{
    public partial class AddPlantForm : Form
    {
        public AddPlantForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbFilePath.Text = openFileDialog1.FileName;
            }
        }
    }
}