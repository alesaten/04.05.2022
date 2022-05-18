using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04._05._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ImportText_textBox.Enabled = false;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            openFileDialog.Filter = "Text files(*.txt)|*.txt";

            ImportText_textBox.Validating += ImportText_textBox_Validating;
            Author_textBox.Validating += Author_textBox_Validating;
            ClearTextBox_button.Click += ClearTextBox_button_Click;
            ImportText_button.Click += ImportText_button_Click;
            Output_button.Click += Output_button_Click;
        }

        private void ClearTextBox_button_Click(object sender, EventArgs e)
        {
            DialogResult ClearProcess = MessageBox.Show("Очистить текстовое поле?", "Предупреждение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (ClearProcess == DialogResult.Yes)
                ImportText_textBox.Text = "";
        }

        void ImportText_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            string imported_file = openFileDialog.FileName;
            string imported_fileText = System.IO.File.ReadAllText(imported_file);

            ImportText_textBox.Text = imported_fileText;
        }

        void Output_button_Click(object sender, EventArgs e)
        {
            DialogResult ClearProcess = MessageBox.Show("'" + ImportText_textBox.Text + "'\nАвтор: " + Author_textBox.Text, "Текст");
        }

        private void ImportText_textBox_Validating(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ImportText_textBox.Text))
            {
                errorProvider.SetError(ImportText_textBox, "Импортируйте текст");
                Output_button.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                Output_button.Enabled = true;
            }
        }

        private void Author_textBox_Validating(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Author_textBox.Text))
            {
                errorProvider.SetError(Author_textBox, "Введите автора");
                Output_button.Enabled = false;
            }
            else if (Author_textBox.Text.Length < 6)
            {
                errorProvider.SetError(Author_textBox, "Короткое наименоване автора (менее 6 символов)");
                Output_button.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                Output_button.Enabled = true;
            }
        }
    }
}
