
namespace Projekat2
{
    partial class Racuni
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.kolicinaTxb = new System.Windows.Forms.TextBox();
            this.cenaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.racunLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.listaKnjiga = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.autorTxt = new System.Windows.Forms.TextBox();
            this.sacuvajRacBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.racunZbirLbl = new System.Windows.Forms.Label();
            this.brisanjeStavkeBtn = new System.Windows.Forms.Button();
            this.ukloniSveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaKnjiga)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 731);
            this.panel1.TabIndex = 0;
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
            // nazivTxt
            // 
            this.nazivTxt.Enabled = false;
            this.nazivTxt.Location = new System.Drawing.Point(306, 172);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(100, 20);
            this.nazivTxt.TabIndex = 1;
            // 
            // kolicinaTxb
            // 
            this.kolicinaTxb.Location = new System.Drawing.Point(525, 172);
            this.kolicinaTxb.Name = "kolicinaTxb";
            this.kolicinaTxb.Size = new System.Drawing.Size(100, 20);
            this.kolicinaTxb.TabIndex = 2;
            this.kolicinaTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolicinaBroj);
            // 
            // cenaTxt
            // 
            this.cenaTxt.Enabled = false;
            this.cenaTxt.Location = new System.Drawing.Point(419, 172);
            this.cenaTxt.Name = "cenaTxt";
            this.cenaTxt.Size = new System.Drawing.Size(100, 20);
            this.cenaTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(521, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kolicina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(415, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(332, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista knjiga";
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.Maroon;
            this.dodajBtn.FlatAppearance.BorderSize = 0;
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajBtn.Location = new System.Drawing.Point(267, 212);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(123, 35);
            this.dodajBtn.TabIndex = 10;
            this.dodajBtn.Text = "Dodaj na račun";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Maroon;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetBtn.Location = new System.Drawing.Point(428, 212);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(91, 35);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // racunLista
            // 
            this.racunLista.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.racunLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racunLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.racunLista.Location = new System.Drawing.Point(644, 172);
            this.racunLista.Name = "racunLista";
            this.racunLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.racunLista.Size = new System.Drawing.Size(608, 211);
            this.racunLista.TabIndex = 12;
            this.racunLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.racunLista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Naziv knjige";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cena";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kolicina";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ukupna cena";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "datum";
            this.Column6.Name = "Column6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(865, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Racun knjiga";
            // 
            // listaKnjiga
            // 
            this.listaKnjiga.AllowUserToOrderColumns = true;
            this.listaKnjiga.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.listaKnjiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaKnjiga.Location = new System.Drawing.Point(189, 315);
            this.listaKnjiga.Name = "listaKnjiga";
            this.listaKnjiga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaKnjiga.Size = new System.Drawing.Size(449, 172);
            this.listaKnjiga.TabIndex = 16;
            this.listaKnjiga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaKnjiga_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(187, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Autor";
            // 
            // autorTxt
            // 
            this.autorTxt.Enabled = false;
            this.autorTxt.Location = new System.Drawing.Point(191, 172);
            this.autorTxt.Name = "autorTxt";
            this.autorTxt.Size = new System.Drawing.Size(100, 20);
            this.autorTxt.TabIndex = 17;
            // 
            // sacuvajRacBtn
            // 
            this.sacuvajRacBtn.BackColor = System.Drawing.Color.Maroon;
            this.sacuvajRacBtn.FlatAppearance.BorderSize = 0;
            this.sacuvajRacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvajRacBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sacuvajRacBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sacuvajRacBtn.Location = new System.Drawing.Point(735, 449);
            this.sacuvajRacBtn.Name = "sacuvajRacBtn";
            this.sacuvajRacBtn.Size = new System.Drawing.Size(134, 38);
            this.sacuvajRacBtn.TabIndex = 19;
            this.sacuvajRacBtn.Text = "Napravi račun";
            this.sacuvajRacBtn.UseVisualStyleBackColor = false;
            this.sacuvajRacBtn.Click += new System.EventHandler(this.sacuvajRacBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(882, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ukupno:";
            // 
            // racunZbirLbl
            // 
            this.racunZbirLbl.AutoSize = true;
            this.racunZbirLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.racunZbirLbl.Location = new System.Drawing.Point(935, 401);
            this.racunZbirLbl.Name = "racunZbirLbl";
            this.racunZbirLbl.Size = new System.Drawing.Size(0, 19);
            this.racunZbirLbl.TabIndex = 21;
            // 
            // brisanjeStavkeBtn
            // 
            this.brisanjeStavkeBtn.BackColor = System.Drawing.Color.Maroon;
            this.brisanjeStavkeBtn.FlatAppearance.BorderSize = 0;
            this.brisanjeStavkeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brisanjeStavkeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brisanjeStavkeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.brisanjeStavkeBtn.Location = new System.Drawing.Point(904, 449);
            this.brisanjeStavkeBtn.Name = "brisanjeStavkeBtn";
            this.brisanjeStavkeBtn.Size = new System.Drawing.Size(134, 38);
            this.brisanjeStavkeBtn.TabIndex = 22;
            this.brisanjeStavkeBtn.Text = "Izbriši pojedinačno";
            this.brisanjeStavkeBtn.UseVisualStyleBackColor = false;
            this.brisanjeStavkeBtn.Click += new System.EventHandler(this.brisanjeStavkeBtn_Click);
            // 
            // ukloniSveBtn
            // 
            this.ukloniSveBtn.BackColor = System.Drawing.Color.Maroon;
            this.ukloniSveBtn.FlatAppearance.BorderSize = 0;
            this.ukloniSveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ukloniSveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ukloniSveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ukloniSveBtn.Location = new System.Drawing.Point(1068, 449);
            this.ukloniSveBtn.Name = "ukloniSveBtn";
            this.ukloniSveBtn.Size = new System.Drawing.Size(134, 38);
            this.ukloniSveBtn.TabIndex = 23;
            this.ukloniSveBtn.Text = "Ukloni sve";
            this.ukloniSveBtn.UseVisualStyleBackColor = false;
            this.ukloniSveBtn.Click += new System.EventHandler(this.ukloniSveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(566, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 40);
            this.label8.TabIndex = 24;
            this.label8.Text = "KUPOVINA KNJIGA";
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
            // Racuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ukloniSveBtn);
            this.Controls.Add(this.brisanjeStavkeBtn);
            this.Controls.Add(this.racunZbirLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sacuvajRacBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.autorTxt);
            this.Controls.Add(this.listaKnjiga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.racunLista);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cenaTxt);
            this.Controls.Add(this.kolicinaTxb);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Racuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Racuni";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaKnjiga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.TextBox kolicinaTxb;
        private System.Windows.Forms.TextBox cenaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView racunLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView listaKnjiga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox autorTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button sacuvajRacBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label racunZbirLbl;
        private System.Windows.Forms.Button brisanjeStavkeBtn;
        private System.Windows.Forms.Button ukloniSveBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label exit;
    }
}