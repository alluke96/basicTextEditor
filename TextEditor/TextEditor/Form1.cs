using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Editor_de_texto : Form
    {
        public Editor_de_texto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            StreamReader leitor = new StreamReader(openFileDialog1.FileName);
            while (!leitor.EndOfStream)
            {
                textBox1.Text += leitor.ReadLine();
            }
            leitor.Close();
            leitor.Dispose();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter escritor = new StreamWriter(saveFileDialog1.FileName);
            escritor.Write(textBox1.Text);
            escritor.Flush();
            escritor.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa feito por Allyson Dunke\n\nhttps://github.com/alluke96");
        }
    }
}
