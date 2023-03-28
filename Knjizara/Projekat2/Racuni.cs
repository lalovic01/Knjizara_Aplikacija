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

namespace Projekat2
{
    public partial class Racuni : Form
    {
        public Racuni()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Pocetna\Knjizara.mdf;Integrated Security=True;Connect Timeout=60");
        private void populate()
        {
            Con.Open();
            string query = "select id_knjiga, autor, naziv, cena, kolicina from Knjiga order by naziv ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            listaKnjiga.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateKnjige()
        {
            int novaKolicina = stock - Convert.ToInt32(kolicinaTxb.Text);
            try
            {
                Con.Open();
                string query = "update Knjiga set kolicina='" + novaKolicina + "' where Id_knjiga=" + kljuc + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Knjiga je uspešno uneta");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void UpdateKnjigeDodavanje()
        {
                int novaKolicina1 = stock;
                try
                {
                    Con.Open();
                    string query = "update Knjiga set kolicina='" + novaKolicina1 + "' where Id_knjiga=" + kljuc + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }   
        }
        int n = 0, Grdtotal=0;
        string datum;
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if(kolicinaTxb.Text == "" || Convert.ToInt32(kolicinaTxb.Text) > stock)
            {
                MessageBox.Show("Nema dovoljno kolicine!");
            }
            else
            {
                int total = Convert.ToInt32(kolicinaTxb.Text) * Convert.ToInt32(cenaTxt.Text);
                DataGridViewRow noviRed = new DataGridViewRow();
                noviRed.CreateCells(racunLista);
                noviRed.Cells[0].Value = n + 1;
                noviRed.Cells[1].Value = nazivTxt.Text;
                noviRed.Cells[2].Value = cenaTxt.Text;
                noviRed.Cells[3].Value = kolicinaTxb.Text;
                noviRed.Cells[4].Value = total;
                noviRed.Cells[5].Value = DateTime.Now.ToString();
                racunLista.Rows.Add(noviRed);
                n++;
                UpdateKnjige();
                Grdtotal += total;
                racunZbirLbl.Text = Grdtotal + ""+" din";
            }
        }
        int kljuc = 0, stock = 0;
        private void listaKnjiga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            autorTxt.Text = listaKnjiga.SelectedRows[0].Cells[1].Value.ToString();
            nazivTxt.Text = listaKnjiga.SelectedRows[0].Cells[2].Value.ToString();
            cenaTxt.Text = listaKnjiga.SelectedRows[0].Cells[3].Value.ToString();
            
            if (nazivTxt.Text == "")
            {
                kljuc = 0;
                stock = 0;
            }
            else
            {
                kljuc = Convert.ToInt32(listaKnjiga.SelectedRows[0].Cells[0].Value.ToString());
                stock=Convert.ToInt32(listaKnjiga.SelectedRows[0].Cells[4].Value.ToString());
            }
        }
        private void reset()
        {
            autorTxt.Text = "";
            nazivTxt.Text = "";
            cenaTxt.Text = "";
            kolicinaTxb.Text = "";
        }
        private void racunLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nazivTxt.Text = racunLista.SelectedRows[0].Cells[1].Value.ToString();
            cenaTxt.Text = racunLista.SelectedRows[0].Cells[2].Value.ToString();
            kolicinaTxb.Text = racunLista.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void brisanjeStavkeBtn_Click(object sender, EventArgs e)
        {
            if(kolicinaTxb.Text!="")
            {
                int total = Convert.ToInt32(racunLista.SelectedRows[0].Cells[4].Value.ToString());
                int rowIndex = racunLista.CurrentCell.RowIndex;
                racunLista.Rows.RemoveAt(rowIndex);
                UpdateKnjigeDodavanje();
                n--;
                Grdtotal -= total;
                racunZbirLbl.Text = Grdtotal + "" + " din";
                MessageBox.Show("Uspešno ste obrisali stavku sa računa!");
            }
            else
            {
                MessageBox.Show("Morate da selektujete stavku!");
            }
        }

        private void ukloniSveBtn_Click(object sender, EventArgs e)
        {
            if(kolicinaTxb.Text!="")
            {
                int total = Convert.ToInt32(racunLista.Rows[0].Cells[3].Value.ToString());
                UpdateKnjigeDodavanje();
                n--;
                Grdtotal = 0;
                racunZbirLbl.Text = Grdtotal + "" + " din";
                MessageBox.Show("Uspešno uklonjeno sve sa računa!");
                Racuni f2 = new Racuni();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Morate imati stavke na računu da bi uklonili!");
            }
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

        private void sacuvajRacBtn_Click(object sender, EventArgs e)
        {
            if(kolicinaTxb.Text!="")
            {
                try
                {
                    Con.Open();
                    datum += DateTime.Now.ToString();
                    string query = "insert into Racun values('" + datum + "','" + Grdtotal + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Račun uspešno napravljen!");
                    datum += DateTime.Now.ToString();
                    Con.Close();
                    Racuni f2 = new Racuni();
                    f2.Show();
                    this.Hide();       
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate imati stavke na računu!");
            }
          
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
