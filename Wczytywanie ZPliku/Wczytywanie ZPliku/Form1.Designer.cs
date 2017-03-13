namespace Wczytywanie_ZPliku
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
            this.WybierzSystem = new System.Windows.Forms.Button();
            this.tbSciezka = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WczytanySystem = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KoncowaSelekcja = new System.Windows.Forms.RichTextBox();
            this.Generuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IloscAtrybutow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.wyczysc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IloscAtrybutow)).BeginInit();
            this.SuspendLayout();
            // 
            // WybierzSystem
            // 
            this.WybierzSystem.Location = new System.Drawing.Point(13, 39);
            this.WybierzSystem.Margin = new System.Windows.Forms.Padding(2);
            this.WybierzSystem.Name = "WybierzSystem";
            this.WybierzSystem.Size = new System.Drawing.Size(83, 53);
            this.WybierzSystem.TabIndex = 0;
            this.WybierzSystem.Text = "Wczytaj System Decyzyjny";
            this.WybierzSystem.UseVisualStyleBackColor = true;
            this.WybierzSystem.Click += new System.EventHandler(this.WybierzSystem_Click);
            // 
            // tbSciezka
            // 
            this.tbSciezka.Enabled = false;
            this.tbSciezka.Location = new System.Drawing.Point(110, 39);
            this.tbSciezka.Margin = new System.Windows.Forms.Padding(2);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.ReadOnly = true;
            this.tbSciezka.Size = new System.Drawing.Size(294, 20);
            this.tbSciezka.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WczytanySystem);
            this.groupBox1.Location = new System.Drawing.Point(147, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wczytany System decyzyjny:";
            // 
            // WczytanySystem
            // 
            this.WczytanySystem.Enabled = false;
            this.WczytanySystem.Location = new System.Drawing.Point(6, 39);
            this.WczytanySystem.Name = "WczytanySystem";
            this.WczytanySystem.Size = new System.Drawing.Size(133, 109);
            this.WczytanySystem.TabIndex = 0;
            this.WczytanySystem.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KoncowaSelekcja);
            this.groupBox2.Location = new System.Drawing.Point(147, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System decyzyjny po selekcji cech:";
            // 
            // KoncowaSelekcja
            // 
            this.KoncowaSelekcja.Enabled = false;
            this.KoncowaSelekcja.Location = new System.Drawing.Point(24, 34);
            this.KoncowaSelekcja.Name = "KoncowaSelekcja";
            this.KoncowaSelekcja.Size = new System.Drawing.Size(121, 121);
            this.KoncowaSelekcja.TabIndex = 1;
            this.KoncowaSelekcja.Text = "";
            this.KoncowaSelekcja.TextChanged += new System.EventHandler(this.KoncowaSelekcja_TextChanged);
            // 
            // Generuj
            // 
            this.Generuj.AllowDrop = true;
            this.Generuj.Location = new System.Drawing.Point(289, 219);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(78, 26);
            this.Generuj.TabIndex = 4;
            this.Generuj.Text = "Generuj";
            this.Generuj.UseVisualStyleBackColor = true;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IloscAtrybutow
            // 
            this.IloscAtrybutow.Location = new System.Drawing.Point(147, 219);
            this.IloscAtrybutow.Name = "IloscAtrybutow";
            this.IloscAtrybutow.Size = new System.Drawing.Size(78, 20);
            this.IloscAtrybutow.TabIndex = 5;
            this.IloscAtrybutow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IloscAtrybutow.ValueChanged += new System.EventHandler(this.IloscAtrybutow_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selekcja atrybutów systemu decyzyjnego metodą Fishera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wybierz Liczbę atrybutów";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(22, 294);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 112);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "Pamiętaj!          Liczba wybranych atrybutów nie może być większa od wczytanej l" +
    "iczby atrybutów";
            // 
            // wyczysc
            // 
            this.wyczysc.BackColor = System.Drawing.Color.Yellow;
            this.wyczysc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyczysc.Location = new System.Drawing.Point(304, 383);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(75, 23);
            this.wyczysc.TabIndex = 11;
            this.wyczysc.Text = "Wyczyść";
            this.wyczysc.UseVisualStyleBackColor = false;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(304, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.zamknij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(426, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IloscAtrybutow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generuj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSciezka);
            this.Controls.Add(this.WybierzSystem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Selekcja atrybutów metodą Fishera";
            this.Load += new System.EventHandler(this.WczytanySystem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IloscAtrybutow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WybierzSystem;
        private System.Windows.Forms.TextBox tbSciezka;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.RichTextBox WczytanySystem;
        private System.Windows.Forms.RichTextBox KoncowaSelekcja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IloscAtrybutow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button wyczysc;
        private System.Windows.Forms.Button button2;
    }
}

