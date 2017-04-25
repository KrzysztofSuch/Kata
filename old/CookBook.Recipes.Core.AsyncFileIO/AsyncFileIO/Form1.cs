using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookBook.Recipes.Core.AsyncFileIO;

namespace AsyncFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) { textBox1.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)) {
                Console.WriteLine( Utils.CopyDirectoryAsyncTask(textBox1.Text, textBox2.Text));
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) { textBox2.Text = folderBrowserDialog1.SelectedPath; }
        }
    }
}
