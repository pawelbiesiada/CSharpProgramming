using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class FrmFileManager : Form
    {
        public FrmFileManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = txtFilePath.Text;
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Plik nie istnieje", "Ostrzeżenie");
                    return;
                }

                var content = File.ReadAllText(path);
                txtContent.Text = content;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var path = txtFilePath.Text;
            try
            {
                var overrideFile = true;
                if(File.Exists(path))
                {
                    var result = MessageBox.Show("Plik istnieje, czy chcesz go nadpisać?",
                        "Ostrzeżenie", MessageBoxButtons.YesNo);

                    overrideFile = result == DialogResult.Yes;
                }

                if (overrideFile)
                {
                    File.WriteAllText(path, txtContent.Text);
                    txtContent.Text = String.Empty;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
        }
    }
}
