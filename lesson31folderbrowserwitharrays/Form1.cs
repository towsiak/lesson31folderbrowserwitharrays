using System;
using System.Windows.Forms;
using System.IO;//allows using Directory class so we can get the all the files in a folder

namespace lesson31folderbrowserwitharrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFolderPath_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();//when user double clicks in box, a folder browser shows
            txtFolderPath.Text = folderBrowserDialog1.SelectedPath;//puts selected path in text box
            btnListFiles.Enabled = true;//this makes our button enabled
        }

        private void btnListFiles_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//clear text box on each button click so output does not accumulate
            //we're going to create an array
            //an array is a collection of items
            //array values can be examined one at a time using a foreach loop
            //Directory.GetFiles returns an array of file names, which is then saved to the files array
            string[] files = Directory.GetFiles(txtFolderPath.Text);
            foreach (string file in files)//grab each file name, store it to the variable file
                richTextBox1.Text += $"{file}\n";//display the files in the rich text
        }

    }
}
