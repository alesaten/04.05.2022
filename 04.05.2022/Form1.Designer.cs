
namespace _04._05._2022
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImportText_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImportText_button = new System.Windows.Forms.Button();
            this.ClearTextBox_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Author_textBox = new System.Windows.Forms.TextBox();
            this.Output_button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportText_textBox
            // 
            this.ImportText_textBox.Location = new System.Drawing.Point(12, 12);
            this.ImportText_textBox.Multiline = true;
            this.ImportText_textBox.Name = "ImportText_textBox";
            this.ImportText_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ImportText_textBox.Size = new System.Drawing.Size(227, 175);
            this.ImportText_textBox.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ImportText_button
            // 
            this.ImportText_button.Location = new System.Drawing.Point(12, 193);
            this.ImportText_button.Name = "ImportText_button";
            this.ImportText_button.Size = new System.Drawing.Size(227, 23);
            this.ImportText_button.TabIndex = 1;
            this.ImportText_button.Text = "Импорт текста";
            this.ImportText_button.UseVisualStyleBackColor = true;
            // 
            // ClearTextBox_button
            // 
            this.ClearTextBox_button.Location = new System.Drawing.Point(12, 222);
            this.ClearTextBox_button.Name = "ClearTextBox_button";
            this.ClearTextBox_button.Size = new System.Drawing.Size(227, 23);
            this.ClearTextBox_button.TabIndex = 2;
            this.ClearTextBox_button.Text = "Очистить";
            this.ClearTextBox_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите автора:";
            // 
            // Author_textBox
            // 
            this.Author_textBox.Location = new System.Drawing.Point(108, 271);
            this.Author_textBox.Name = "Author_textBox";
            this.Author_textBox.Size = new System.Drawing.Size(131, 20);
            this.Author_textBox.TabIndex = 4;
            // 
            // Output_button
            // 
            this.Output_button.Location = new System.Drawing.Point(15, 297);
            this.Output_button.Name = "Output_button";
            this.Output_button.Size = new System.Drawing.Size(224, 23);
            this.Output_button.TabIndex = 5;
            this.Output_button.Text = "Вывод";
            this.Output_button.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 330);
            this.Controls.Add(this.Output_button);
            this.Controls.Add(this.Author_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearTextBox_button);
            this.Controls.Add(this.ImportText_button);
            this.Controls.Add(this.ImportText_textBox);
            this.Name = "Form1";
            this.Text = "Импортирование текста";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImportText_textBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button ClearTextBox_button;
        private System.Windows.Forms.Button ImportText_button;
        private System.Windows.Forms.TextBox Author_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Output_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

