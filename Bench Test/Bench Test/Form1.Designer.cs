namespace Bench_Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.input_date = new System.Windows.Forms.TextBox();
            this.input_ref = new System.Windows.Forms.TextBox();
            this.input_serial = new System.Windows.Forms.TextBox();
            this.list_Baud = new System.Windows.Forms.ComboBox();
            this.list_size = new System.Windows.Forms.ComboBox();
            this.input_color = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.serrage1 = new System.Windows.Forms.TextBox();
            this.serrage2 = new System.Windows.Forms.TextBox();
            this.serrage3 = new System.Windows.Forms.TextBox();
            this.serrage4 = new System.Windows.Forms.TextBox();
            this.serrage5 = new System.Windows.Forms.TextBox();
            this.serrage6 = new System.Windows.Forms.TextBox();
            this.serrage7 = new System.Windows.Forms.TextBox();
            this.serrage8 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.m_test_bench = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Tests = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Date";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(591, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Référence";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(591, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "N° de lot";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(591, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(64, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Buad Rate";
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(591, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(64, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Taille";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(591, 141);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(64, 20);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Couleur";
            // 
            // input_date
            // 
            this.input_date.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_date.Location = new System.Drawing.Point(661, 12);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(92, 20);
            this.input_date.TabIndex = 9;
            this.input_date.TextChanged += new System.EventHandler(this.TextBox7_TextChanged);
            // 
            // input_ref
            // 
            this.input_ref.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_ref.Location = new System.Drawing.Point(661, 38);
            this.input_ref.Name = "input_ref";
            this.input_ref.Size = new System.Drawing.Size(92, 20);
            this.input_ref.TabIndex = 10;
            this.input_ref.Text = "Ref";
            // 
            // input_serial
            // 
            this.input_serial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_serial.Location = new System.Drawing.Point(661, 64);
            this.input_serial.Name = "input_serial";
            this.input_serial.Size = new System.Drawing.Size(92, 20);
            this.input_serial.TabIndex = 11;
            this.input_serial.Text = "Entrer numéro";
            // 
            // list_Baud
            // 
            this.list_Baud.ForeColor = System.Drawing.SystemColors.WindowText;
            this.list_Baud.FormattingEnabled = true;
            this.list_Baud.Items.AddRange(new object[] {
            "9600",
            "10",
            "115200"});
            this.list_Baud.Location = new System.Drawing.Point(661, 89);
            this.list_Baud.Name = "list_Baud";
            this.list_Baud.Size = new System.Drawing.Size(92, 21);
            this.list_Baud.TabIndex = 16;
            this.list_Baud.Text = "Choisir un rate";
            this.list_Baud.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // list_size
            // 
            this.list_size.FormattingEnabled = true;
            this.list_size.Location = new System.Drawing.Point(661, 116);
            this.list_size.Name = "list_size";
            this.list_size.Size = new System.Drawing.Size(92, 21);
            this.list_size.TabIndex = 17;
            this.list_size.Text = "Choisir taille";
            this.list_size.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // input_color
            // 
            this.input_color.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_color.Location = new System.Drawing.Point(661, 142);
            this.input_color.Name = "input_color";
            this.input_color.Size = new System.Drawing.Size(92, 20);
            this.input_color.TabIndex = 18;
            this.input_color.Text = "Entrer couleur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 427);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // serrage1
            // 
            this.serrage1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage1.Location = new System.Drawing.Point(523, 255);
            this.serrage1.Name = "serrage1";
            this.serrage1.Size = new System.Drawing.Size(113, 20);
            this.serrage1.TabIndex = 20;
            this.serrage1.TextChanged += new System.EventHandler(this.Serrage1_TextChanged);
            // 
            // serrage2
            // 
            this.serrage2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage2.Location = new System.Drawing.Point(523, 284);
            this.serrage2.Name = "serrage2";
            this.serrage2.Size = new System.Drawing.Size(113, 20);
            this.serrage2.TabIndex = 21;
            this.serrage2.TextChanged += new System.EventHandler(this.Serrage2_TextChanged);
            // 
            // serrage3
            // 
            this.serrage3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage3.Location = new System.Drawing.Point(523, 319);
            this.serrage3.Name = "serrage3";
            this.serrage3.Size = new System.Drawing.Size(113, 20);
            this.serrage3.TabIndex = 22;
            this.serrage3.TextChanged += new System.EventHandler(this.Serrage3_TextChanged);
            // 
            // serrage4
            // 
            this.serrage4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage4.Location = new System.Drawing.Point(523, 373);
            this.serrage4.Name = "serrage4";
            this.serrage4.Size = new System.Drawing.Size(113, 20);
            this.serrage4.TabIndex = 23;
            this.serrage4.TextChanged += new System.EventHandler(this.Serrage4_TextChanged);
            // 
            // serrage5
            // 
            this.serrage5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage5.Location = new System.Drawing.Point(523, 437);
            this.serrage5.Name = "serrage5";
            this.serrage5.Size = new System.Drawing.Size(113, 20);
            this.serrage5.TabIndex = 24;
            this.serrage5.TextChanged += new System.EventHandler(this.Serrage5_TextChanged);
            // 
            // serrage6
            // 
            this.serrage6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage6.Location = new System.Drawing.Point(523, 463);
            this.serrage6.Name = "serrage6";
            this.serrage6.Size = new System.Drawing.Size(113, 20);
            this.serrage6.TabIndex = 25;
            this.serrage6.TextChanged += new System.EventHandler(this.Serrage6_TextChanged);
            // 
            // serrage7
            // 
            this.serrage7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage7.Location = new System.Drawing.Point(523, 511);
            this.serrage7.Name = "serrage7";
            this.serrage7.Size = new System.Drawing.Size(113, 20);
            this.serrage7.TabIndex = 26;
            this.serrage7.TextChanged += new System.EventHandler(this.Serrage7_TextChanged);
            // 
            // serrage8
            // 
            this.serrage8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.serrage8.Location = new System.Drawing.Point(523, 537);
            this.serrage8.Name = "serrage8";
            this.serrage8.Size = new System.Drawing.Size(113, 20);
            this.serrage8.TabIndex = 27;
            this.serrage8.TextChanged += new System.EventHandler(this.Serrage8_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, -21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 704);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // m_test_bench
            // 
            this.m_test_bench.BackColor = System.Drawing.SystemColors.Window;
            this.m_test_bench.Image = ((System.Drawing.Image)(resources.GetObject("m_test_bench.Image")));
            this.m_test_bench.Location = new System.Drawing.Point(679, 563);
            this.m_test_bench.Name = "m_test_bench";
            this.m_test_bench.Size = new System.Drawing.Size(74, 65);
            this.m_test_bench.TabIndex = 0;
            this.m_test_bench.UseVisualStyleBackColor = false;
            this.m_test_bench.Click += new System.EventHandler(this.M_test_bench_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(147, 34);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 29;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Tests
            // 
            this.Tests.Location = new System.Drawing.Point(228, 34);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(75, 23);
            this.Tests.TabIndex = 30;
            this.Tests.Text = "Tests";
            this.Tests.UseVisualStyleBackColor = true;
            this.Tests.Click += new System.EventHandler(this.Tests_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(642, 255);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(27, 20);
            this.textBox7.TabIndex = 31;
            this.textBox7.Text = "HPa";
            this.textBox7.TextChanged += new System.EventHandler(this.TextBox7_TextChanged_1);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(642, 284);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(27, 20);
            this.textBox8.TabIndex = 32;
            this.textBox8.Text = "HPa";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(642, 319);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(27, 20);
            this.textBox9.TabIndex = 33;
            this.textBox9.Text = "HPa";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(642, 373);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(27, 20);
            this.textBox10.TabIndex = 34;
            this.textBox10.Text = "HPa";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(642, 437);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(27, 20);
            this.textBox11.TabIndex = 35;
            this.textBox11.Text = "HPa";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(642, 463);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(27, 20);
            this.textBox12.TabIndex = 36;
            this.textBox12.Text = "HPa";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(642, 511);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(27, 20);
            this.textBox13.TabIndex = 37;
            this.textBox13.Text = "HPa";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(642, 537);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(27, 20);
            this.textBox14.TabIndex = 38;
            this.textBox14.Text = "HPa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Tests);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.serrage8);
            this.Controls.Add(this.serrage7);
            this.Controls.Add(this.serrage6);
            this.Controls.Add(this.serrage5);
            this.Controls.Add(this.serrage4);
            this.Controls.Add(this.serrage3);
            this.Controls.Add(this.serrage2);
            this.Controls.Add(this.serrage1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.input_color);
            this.Controls.Add(this.list_size);
            this.Controls.Add(this.list_Baud);
            this.Controls.Add(this.input_serial);
            this.Controls.Add(this.input_ref);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_test_bench);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox input_date;
        private System.Windows.Forms.TextBox input_ref;
        private System.Windows.Forms.TextBox input_serial;
        private System.Windows.Forms.ComboBox list_Baud;
        private System.Windows.Forms.ComboBox list_size;
        private System.Windows.Forms.TextBox input_color;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox serrage1;
        private System.Windows.Forms.TextBox serrage2;
        private System.Windows.Forms.TextBox serrage3;
        private System.Windows.Forms.TextBox serrage4;
        private System.Windows.Forms.TextBox serrage5;
        private System.Windows.Forms.TextBox serrage6;
        private System.Windows.Forms.TextBox serrage7;
        private System.Windows.Forms.TextBox serrage8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button m_test_bench;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Tests;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
    }
}

