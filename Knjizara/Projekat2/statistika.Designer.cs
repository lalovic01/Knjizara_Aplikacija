
namespace Projekat2
{
    partial class statistika
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
            this.listaKnjiga = new System.Windows.Forms.DataGridView();
            this.kolicina = new System.Windows.Forms.Label();
            this.ukupnoKnjiga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.spisakRacunaLbl = new System.Windows.Forms.Label();
            this.listaRacuna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaKnjiga)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // listaKnjiga
            // 
            this.listaKnjiga.AllowUserToOrderColumns = true;
            this.listaKnjiga.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listaKnjiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaKnjiga.Location = new System.Drawing.Point(264, 213);
            this.listaKnjiga.Name = "listaKnjiga";
            this.listaKnjiga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaKnjiga.Size = new System.Drawing.Size(370, 138);
            this.listaKnjiga.TabIndex = 16;
            this.listaKnjiga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaKnjiga_CellContentClick);
            // 
            // kolicina
            // 
            this.kolicina.AutoSize = true;
            this.kolicina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolicina.Location = new System.Drawing.Point(761, 232);
            this.kolicina.Name = "kolicina";
            this.kolicina.Size = new System.Drawing.Size(0, 19);
            this.kolicina.TabIndex = 17;
            // 
            // ukupnoKnjiga
            // 
            this.ukupnoKnjiga.AutoSize = true;
            this.ukupnoKnjiga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ukupnoKnjiga.Location = new System.Drawing.Point(761, 276);
            this.ukupnoKnjiga.Name = "ukupnoKnjiga";
            this.ukupnoKnjiga.Size = new System.Drawing.Size(45, 19);
            this.ukupnoKnjiga.TabIndex = 18;
            this.ukupnoKnjiga.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(687, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Prikaži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 731);
            this.panel1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "Statistika";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Kupovina";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Knjige";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(197, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Izaberite knjigu za statistički prikaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(653, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Količina knjige:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(653, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ukupno knjiga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(583, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 40);
            this.label4.TabIndex = 24;
            this.label4.Text = "STATISTIKA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(10, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "label7";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(264, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 112);
            this.panel2.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(354, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 36);
            this.label8.TabIndex = 31;
            this.label8.Text = "Top 3 knjige";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(1224, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 25);
            this.exit.TabIndex = 32;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // spisakRacunaLbl
            // 
            this.spisakRacunaLbl.AutoSize = true;
            this.spisakRacunaLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spisakRacunaLbl.Location = new System.Drawing.Point(890, 413);
            this.spisakRacunaLbl.Name = "spisakRacunaLbl";
            this.spisakRacunaLbl.Size = new System.Drawing.Size(272, 36);
            this.spisakRacunaLbl.TabIndex = 34;
            this.spisakRacunaLbl.Text = "Spisak svih računa";
            // 
            // listaRacuna
            // 
            this.listaRacuna.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listaRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRacuna.GridColor = System.Drawing.SystemColors.ControlLight;
            this.listaRacuna.Location = new System.Drawing.Point(847, 452);
            this.listaRacuna.Name = "listaRacuna";
            this.listaRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaRacuna.Size = new System.Drawing.Size(355, 172);
            this.listaRacuna.TabIndex = 33;
            // 
            // statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.spisakRacunaLbl);
            this.Controls.Add(this.listaRacuna);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ukupnoKnjiga);
            this.Controls.Add(this.kolicina);
            this.Controls.Add(this.listaKnjiga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statistika";
            this.Load += new System.EventHandler(this.statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaKnjiga)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaKnjiga;
        private System.Windows.Forms.Label kolicina;
        private System.Windows.Forms.Label ukupnoKnjiga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label spisakRacunaLbl;
        private System.Windows.Forms.DataGridView listaRacuna;
    }
}