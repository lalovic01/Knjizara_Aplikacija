using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat2
{
    public partial class statistika : Form
    {
        Thread t;
        public statistika()
        {
            InitializeComponent();
            myTimer.Interval = 15000;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
        }
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Pocetna\Knjizara.mdf;Integrated Security=True;Connect Timeout=60");
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            this.listaRacuna.Visible = false;
            spisakRacunaLbl.Visible = false;
        }
        private void populate()
        {

            Con.Open();
            string query = "select autor, naziv, kolicina from Knjiga order by kolicina DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            listaKnjiga.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void listaKnjiga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kolicina.Text= listaKnjiga.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void statistika_Load(object sender, EventArgs e)
        {
            populate();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(kolicina) from Knjiga", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ukupnoKnjiga.Text = dt.Rows[0][0].ToString();
            Con.Close();
            label5.Text = "Na 1 mestu knjiga: "+ " "+ listaKnjiga.Rows[0].Cells[1].Value.ToString() +" "+ "autor je: " + "" + listaKnjiga.Rows[0].Cells[0].Value.ToString();
            label6.Text = "Na 2 mestu knjiga: " + " " + listaKnjiga.Rows[1].Cells[1].Value.ToString() + " " + "autor je: " + "" + listaKnjiga.Rows[1].Cells[0].Value.ToString();
            label7.Text = "Na 3 mestu knjiga: " + " " + listaKnjiga.Rows[2].Cells[1].Value.ToString() + " " + "autor je: " + "" + listaKnjiga.Rows[2].Cells[0].Value.ToString();
            t = new Thread(menjanjeBoja);
            t.IsBackground = true;
            t.Start();

            Con.Open();
            string query = "select Id_racun, datum, ukupna_cena from Racun";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda1);
            var ds1 = new DataSet();
            sda1.Fill(ds1);
            listaRacuna.DataSource = ds1.Tables[0];
            myTimer.Start();
            Con.Close();
        }
        bool dodato = true;
        private void crtaj(object sender, PaintEventArgs e)
        {
            if (Int32.TryParse(kolicina.Text, out int procenat))
            {
                Int32.TryParse(ukupnoKnjiga.Text, out int ukupno);
                if (procenat >= 1 && procenat <= ukupno)
                {
                    Rectangle r = new Rectangle(900, 120, 250, 250);
                    e.Graphics.FillEllipse(Brushes.Maroon, r);
                    e.Graphics.FillPie(Brushes.Yellow, r, 0, 360f * procenat / ukupno );
                }
            }
        }
        Random rnd = new Random();
        public void menjanjeBoja()
        {
            while (true)
            {
                if (label5.Text!="")
                {
                    label5.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                    label6.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                    label7.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                }
                Invalidate();
                Thread.Sleep(500);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(kolicina.Text!="")
            {
                if (dodato)
                {
                    dodato = false;
                    Paint += crtaj;
                }
            }
            else
            {
                MessageBox.Show("Morate izabrati knjigu!");
            }
            Invalidate();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Racuni f2 = new Racuni();
            f2.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            statistika f3 = new statistika();
            f3.Show();
            this.Hide();
        }

        private void najviseTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
