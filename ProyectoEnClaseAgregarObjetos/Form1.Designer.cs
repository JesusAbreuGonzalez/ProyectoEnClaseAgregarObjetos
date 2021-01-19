
namespace ProyectoEnClaseAgregarObjetos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDLabel = new System.Windows.Forms.Label();
            this.AliasLabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(39, 36);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 20);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(39, 79);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(41, 20);
            this.AliasLabel.TabIndex = 1;
            this.AliasLabel.Text = "Alias";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(39, 122);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(70, 20);
            this.NombresLabel.TabIndex = 2;
            this.NombresLabel.Text = "Nombres";
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(39, 170);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(45, 20);
            this.ClaveLabel.TabIndex = 3;
            this.ClaveLabel.Text = "Clave";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDTextBox.Location = new System.Drawing.Point(124, 36);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(85, 27);
            this.IDTextBox.TabIndex = 4;
            this.IDTextBox.Text = "20180616";
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Location = new System.Drawing.Point(124, 79);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(129, 27);
            this.AliasTextBox.TabIndex = 5;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(124, 122);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(206, 27);
            this.NombresTextBox.TabIndex = 6;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(124, 163);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(125, 27);
            this.ClaveTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirmar Clave";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.AliasTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.AliasLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label AliasLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        internal System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

