using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_texto
{
    public partial class Anotes : Form
    {
        public Anotes()
        {
            InitializeComponent();
        }

        private void eDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            String r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void Archivo_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionartodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
        private void formato_Click(object sender, EventArgs e)
        {
            var font = fontDialog1.ShowDialog();
            if (font == DialogResult.OK)
            {

                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void Seleccionar_tamaño(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(ComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);            
            }
        }
    }
}
