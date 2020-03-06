namespace Dealer_Auto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Utilizator = new System.Windows.Forms.Label();
            this.textBox_Utilizator = new System.Windows.Forms.TextBox();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.label_Parola = new System.Windows.Forms.Label();
            this.button_Logare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Utilizator
            // 
            this.label_Utilizator.AutoSize = true;
            this.label_Utilizator.Location = new System.Drawing.Point(94, 64);
            this.label_Utilizator.Name = "label_Utilizator";
            this.label_Utilizator.Size = new System.Drawing.Size(79, 20);
            this.label_Utilizator.TabIndex = 0;
            this.label_Utilizator.Text = "Utilizator :";
            // 
            // textBox_Utilizator
            // 
            this.textBox_Utilizator.Location = new System.Drawing.Point(179, 64);
            this.textBox_Utilizator.Name = "textBox_Utilizator";
            this.textBox_Utilizator.Size = new System.Drawing.Size(317, 26);
            this.textBox_Utilizator.TabIndex = 1;
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.Location = new System.Drawing.Point(179, 105);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.Size = new System.Drawing.Size(317, 26);
            this.textBox_Parola.TabIndex = 3;
            // 
            // label_Parola
            // 
            this.label_Parola.AutoSize = true;
            this.label_Parola.Location = new System.Drawing.Point(94, 105);
            this.label_Parola.Name = "label_Parola";
            this.label_Parola.Size = new System.Drawing.Size(62, 20);
            this.label_Parola.TabIndex = 2;
            this.label_Parola.Text = "Parola :";
            // 
            // button_Logare
            // 
            this.button_Logare.Location = new System.Drawing.Point(331, 171);
            this.button_Logare.Name = "button_Logare";
            this.button_Logare.Size = new System.Drawing.Size(165, 38);
            this.button_Logare.TabIndex = 4;
            this.button_Logare.Text = "Logheaza-te";
            this.button_Logare.UseVisualStyleBackColor = true;
            this.button_Logare.Click += new System.EventHandler(this.button_Logare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Logare);
            this.Controls.Add(this.textBox_Parola);
            this.Controls.Add(this.label_Parola);
            this.Controls.Add(this.textBox_Utilizator);
            this.Controls.Add(this.label_Utilizator);
            this.Name = "Form1";
            this.Text = "Fereastra Logare";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Utilizator;
        private System.Windows.Forms.TextBox textBox_Utilizator;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.Label label_Parola;
        private System.Windows.Forms.Button button_Logare;
    }
}

