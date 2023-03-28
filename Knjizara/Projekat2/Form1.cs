using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projekat2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
            myTimer.Interval = 15000;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
        }
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Pocetna\Knjizara.mdf;Integrated Security=True;Connect Timeout=60");
        private void populate()
        {
            
            Con.Open();
            string query = "select * from Knjiga order by naziv ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            listaKnjiga.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Filter()
        {
            Con.Open();
            string query = "select * from Knjiga where zanr='" + filtriranjeCmb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            listaKnjiga.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            autorTxt.Text = "";
            nazivTxt.Text = "";
            cenaTxt.Text = "";
            popustTxt.Text = "";
            brStranaTxt.Text = "";
            zanrCmb.SelectedIndex = -1;
            kolicinaTxb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(autorTxt.Text=="" || nazivTxt.Text=="" || cenaTxt.Text=="" || popustTxt.Text=="" || brStranaTxt.Text=="" ||  zanrCmb.SelectedIndex==-1 || kolicinaTxb.Text=="")
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Knjiga values('" + autorTxt.Text + "','" + nazivTxt.Text + "','" + cenaTxt.Text + "','" + popustTxt.Text + "','" + brStranaTxt.Text + "', '" + zanrCmb.SelectedItem.ToString() + "','" + kolicinaTxb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Knjiga uspešno sačuvana!");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                } 
            }
        }
        private void filtriranjeKnjiga(object sender, EventArgs e)
        {
            Filter();
        }
        private void refresujBtn_Click(object sender, EventArgs e)
        {
            populate();
            zanrCmb.SelectedIndex = -1;
        }
        private void resetujBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int kljuc = 0;
        private void listaKnjiga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            autorTxt.Text = listaKnjiga.SelectedRows[0].Cells[1].Value.ToString();
            nazivTxt.Text = listaKnjiga.SelectedRows[0].Cells[2].Value.ToString();
            cenaTxt.Text = listaKnjiga.SelectedRows[0].Cells[3].Value.ToString();
            popustTxt.Text = listaKnjiga.SelectedRows[0].Cells[4].Value.ToString();
            brStranaTxt.Text = listaKnjiga.SelectedRows[0].Cells[5].Value.ToString();
            zanrCmb.Text = listaKnjiga.SelectedRows[0].Cells[6].Value.ToString();
            kolicinaTxb.Text = listaKnjiga.SelectedRows[0].Cells[7].Value.ToString();
            if (nazivTxt.Text=="")
            {
                kljuc = 0;
            }
            else
            {
                kljuc=Convert.ToInt32(listaKnjiga.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (kljuc==0)
            {
                MessageBox.Show("Niste izabrali knjigu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Knjiga where Id_knjiga=" + kljuc + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Knjiga uspešno izbrisana");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void izmeniBtn_Click(object sender, EventArgs e)
        {
            if (autorTxt.Text == "" || nazivTxt.Text == "" || cenaTxt.Text == "" || popustTxt.Text == "" || brStranaTxt.Text == "" || zanrCmb.SelectedIndex == -1 || kolicinaTxb.Text=="")
            {
                MessageBox.Show("Niste izabrali knjigu!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Knjiga set autor='"+autorTxt.Text+ "',naziv='" + nazivTxt.Text + "',cena='" + cenaTxt.Text + "',popust='" + popustTxt.Text + "',broj_strana='" + brStranaTxt.Text + "',zanr='" + zanrCmb.SelectedItem.ToString() + "',kolicina='" + kolicinaTxb.Text + "' where Id_knjiga=" + kljuc+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Knjiga je uspesno izmenjena");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select Id_racun, datum, ukupna_cena from Racun";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            listaRacuna.DataSource = ds.Tables[0];
            myTimer.Start();
            Con.Close();
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            this.listaRacuna.Visible = false;
            spisakRacunaLbl.Visible = false;
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

        private void cenaBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void popustBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void stranaBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void kolicinaBroj(object sender, KeyPressEventArgs e)
        {
            char karakter = e.KeyChar;

            if (!Char.IsDigit(karakter) && karakter != 8 && karakter != 46)
            {
                e.Handled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
