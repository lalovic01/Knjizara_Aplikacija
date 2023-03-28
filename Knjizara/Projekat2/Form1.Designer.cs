
namespace Projekat2
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
            this.autorTxt = new System.Windows.Forms.TextBox();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.cenaTxt = new System.Windows.Forms.TextBox();
            this.popustTxt = new System.Windows.Forms.TextBox();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.zanrCmb = new System.Windows.Forms.ComboBox();
            this.brStranaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listaKnjiga = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.filtriranjeCmb = new System.Windows.Forms.ComboBox();
            this.refresujBtn = new System.Windows.Forms.Button();
            this.izmeniBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.resetujBtn = new System.Windows.Forms.Button();
            this.kolicinaTxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listaRacuna = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.spisakRacunaLbl = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaKnjiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRacuna)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autorTxt
            // 
            this.autorTxt.Location = new System.Drawing.Point(267, 159);
            this.autorTxt.Name = "autorTxt";
            this.autorTxt.Size = new System.Drawing.Size(100, 20);
            this.autorTxt.TabIndex = 0;
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(373, 159);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(100, 20);
            this.nazivTxt.TabIndex = 1;
            // 
            // cenaTxt
            // 
            this.cenaTxt.Location = new System.Drawing.Point(479, 159);
            this.cenaTxt.Name = "cenaTxt";
            this.cenaTxt.Size = new System.Drawing.Size(100, 20);
            this.cenaTxt.TabIndex = 2;
            this.cenaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cenaBroj);
            // 
            // popustTxt
            // 
            this.popustTxt.Location = new System.Drawing.Point(584, 159);
            this.popustTxt.Name = "popustTxt";
            this.popustTxt.Size = new System.Drawing.Size(100, 20);
            this.popustTxt.TabIndex = 3;
            this.popustTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.popustBroj);
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.BackColor = System.Drawing.Color.Maroon;
            this.sacuvajBtn.FlatAppearance.BorderSize = 0;
            this.sacuvajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvajBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sacuvajBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sacuvajBtn.Location = new System.Drawing.Point(479, 184);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(84, 32);
            this.sacuvajBtn.TabIndex = 4;
            this.sacuvajBtn.Text = "Sačuvaj";
            this.sacuvajBtn.UseVisualStyleBackColor = false;
            this.sacuvajBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // zanrCmb
            // 
            this.zanrCmb.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zanrCmb.FormattingEnabled = true;
            this.zanrCmb.Items.AddRange(new object[] {
            "Misterija",
            "Roman",
            "Triler",
            "Romantika",
            "Fantastika"});
            this.zanrCmb.Location = new System.Drawing.Point(797, 155);
            this.zanrCmb.Name = "zanrCmb";
            this.zanrCmb.Size = new System.Drawing.Size(121, 24);
            this.zanrCmb.TabIndex = 5;
            this.zanrCmb.Text = "Izaberite žanr";
            // 
            // brStranaTxt
            // 
            this.brStranaTxt.Location = new System.Drawing.Point(691, 159);
            this.brStranaTxt.Name = "brStranaTxt";
            this.brStranaTxt.Size = new System.Drawing.Size(100, 20);
            this.brStranaTxt.TabIndex = 6;
            this.brStranaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stranaBroj);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(259, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(471, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(365, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naziv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(577, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Popust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(683, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "brStrana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(793, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Zanr";
            // 
            // listaKnjiga
            // 
            this.listaKnjiga.AllowUserToOrderColumns = true;
            this.listaKnjiga.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listaKnjiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaKnjiga.Location = new System.Drawing.Point(225, 284);
            this.listaKnjiga.Name = "listaKnjiga";
            this.listaKnjiga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaKnjiga.Size = new System.Drawing.Size(851, 172);
            this.listaKnjiga.TabIndex = 15;
            this.listaKnjiga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaKnjiga_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(475, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista knjiga";
            // 
            // filtriranjeCmb
            // 
            this.filtriranjeCmb.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtriranjeCmb.FormattingEnabled = true;
            this.filtriranjeCmb.ItemHeight = 16;
            this.filtriranjeCmb.Items.AddRange(new object[] {
            "Misterija",
            "Roman",
            "Triler",
            "Romantika",
            "Fantastika"});
            this.filtriranjeCmb.Location = new System.Drawing.Point(479, 252);
            this.filtriranjeCmb.Name = "filtriranjeCmb";
            this.filtriranjeCmb.Size = new System.Drawing.Size(139, 24);
            this.filtriranjeCmb.TabIndex = 17;
            this.filtriranjeCmb.Text = "Filtriranje po žanru";
            this.filtriranjeCmb.SelectionChangeCommitted += new System.EventHandler(this.filtriranjeKnjiga);
            // 
            // refresujBtn
            // 
            this.refresujBtn.BackColor = System.Drawing.Color.Maroon;
            this.refresujBtn.FlatAppearance.BorderSize = 0;
            this.refresujBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresujBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresujBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresujBtn.Location = new System.Drawing.Point(642, 246);
            this.refresujBtn.Name = "refresujBtn";
            this.refresujBtn.Size = new System.Drawing.Size(84, 32);
            this.refresujBtn.TabIndex = 18;
            this.refresujBtn.Text = "Refrešuj";
            this.refresujBtn.UseVisualStyleBackColor = false;
            this.refresujBtn.Click += new System.EventHandler(this.refresujBtn_Click);
            // 
            // izmeniBtn
            // 
            this.izmeniBtn.BackColor = System.Drawing.Color.Maroon;
            this.izmeniBtn.FlatAppearance.BorderSize = 0;
            this.izmeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izmeniBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izmeniBtn.Location = new System.Drawing.Point(585, 184);
            this.izmeniBtn.Name = "izmeniBtn";
            this.izmeniBtn.Size = new System.Drawing.Size(84, 32);
            this.izmeniBtn.TabIndex = 19;
            this.izmeniBtn.Text = "Izmeni";
            this.izmeniBtn.UseVisualStyleBackColor = false;
            this.izmeniBtn.Click += new System.EventHandler(this.izmeniBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.BackColor = System.Drawing.Color.Maroon;
            this.izbrisiBtn.FlatAppearance.BorderSize = 0;
            this.izbrisiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izbrisiBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izbrisiBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.izbrisiBtn.Location = new System.Drawing.Point(691, 184);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(84, 32);
            this.izbrisiBtn.TabIndex = 20;
            this.izbrisiBtn.Text = "Izbriši";
            this.izbrisiBtn.UseVisualStyleBackColor = false;
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // resetujBtn
            // 
            this.resetujBtn.BackColor = System.Drawing.Color.Maroon;
            this.resetujBtn.FlatAppearance.BorderSize = 0;
            this.resetujBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetujBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetujBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetujBtn.Location = new System.Drawing.Point(797, 185);
            this.resetujBtn.Name = "resetujBtn";
            this.resetujBtn.Size = new System.Drawing.Size(84, 32);
            this.resetujBtn.TabIndex = 21;
            this.resetujBtn.Text = "Resetuj";
            this.resetujBtn.UseVisualStyleBackColor = false;
            this.resetujBtn.Click += new System.EventHandler(this.resetujBtn_Click);
            // 
            // kolicinaTxb
            // 
            this.kolicinaTxb.Location = new System.Drawing.Point(924, 159);
            this.kolicinaTxb.Name = "kolicinaTxb";
            this.kolicinaTxb.Size = new System.Drawing.Size(100, 20);
            this.kolicinaTxb.TabIndex = 22;
            this.kolicinaTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolicinaBroj);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(920, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kolicina";
            // 
            // listaRacuna
            // 
            this.listaRacuna.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listaRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRacuna.GridColor = System.Drawing.SystemColors.ControlLight;
            this.listaRacuna.Location = new System.Drawing.Point(460, 515);
            this.listaRacuna.Name = "listaRacuna";
            this.listaRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaRacuna.Size = new System.Drawing.Size(355, 172);
            this.listaRacuna.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 732);
            this.panel1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 32);
            this.label11.TabIndex = 2;
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
            this.label10.TabIndex = 1;
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
            this.label9.TabIndex = 0;
            this.label9.Text = "Knjige";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(554, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 40);
            this.label12.TabIndex = 26;
            this.label12.Text = "KNJIGE";
            // 
            // spisakRacunaLbl
            // 
            this.spisakRacunaLbl.AutoSize = true;
            this.spisakRacunaLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spisakRacunaLbl.Location = new System.Drawing.Point(503, 476);
            this.spisakRacunaLbl.Name = "spisakRacunaLbl";
            this.spisakRacunaLbl.Size = new System.Drawing.Size(272, 36);
            this.spisakRacunaLbl.TabIndex = 27;
            this.spisakRacunaLbl.Text = "Spisak svih računa";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(1224, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 25);
            this.exit.TabIndex = 33;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.spisakRacunaLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaRacuna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kolicinaTxb);
            this.Controls.Add(this.resetujBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.izmeniBtn);
            this.Controls.Add(this.refresujBtn);
            this.Controls.Add(this.filtriranjeCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaKnjiga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brStranaTxt);
            this.Controls.Add(this.zanrCmb);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.popustTxt);
            this.Controls.Add(this.cenaTxt);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.autorTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaKnjiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRacuna)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox autorTxt;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.TextBox cenaTxt;
        private System.Windows.Forms.TextBox popustTxt;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.ComboBox zanrCmb;
        private System.Windows.Forms.TextBox brStranaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView listaKnjiga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filtriranjeCmb;
        private System.Windows.Forms.Button refresujBtn;
        private System.Windows.Forms.Button izmeniBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button resetujBtn;
        private System.Windows.Forms.TextBox kolicinaTxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView listaRacuna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label spisakRacunaLbl;
        private System.Windows.Forms.Label exit;
    }
}

