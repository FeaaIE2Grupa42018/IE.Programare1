using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IE.Programare1.GestiuneAlbume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OleDbConnection GetConexiune()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vladimir\Documents\FEAA Cursuri\Programare1\2018\IE.Programare1\BD\GestAlbume.accdb;Persist Security Info=False;";
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception)
            {
                MessageBox.Show("Eroare la conexiune");
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = GetConexiune();
            if(conn == null)
            {
                return;
            }
            OleDbCommand selectCommand = new OleDbCommand();
            selectCommand.Connection = conn;
            selectCommand.CommandText = "select ID, Denumire from Albume";
            OleDbDataReader reader = selectCommand.ExecuteReader();
            DataTable albume = new DataTable("Albume");
            albume.Load(reader);

            uxComboBoxAlbume.DataSource = albume;

            if(!reader.IsClosed)
            {
                reader.Close();
            }
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

        }

        private void uxComboBoxAlbume_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = GetConexiune();
            if(conn == null)
            {
                return;
            }
            OleDbCommand selectCommand = new OleDbCommand();
            selectCommand.Connection = conn;
            selectCommand.CommandText = "select * from Albume where ID=@id";
            selectCommand.Parameters.AddWithValue("id", uxComboBoxAlbume.SelectedValue);

            OleDbDataReader reader = selectCommand.ExecuteReader();
            reader.Read();

            uxTextBoxId.Text = reader["ID"].ToString();
            uxTextBoxDenumire.Text = reader["Denumire"].ToString();
            //uxDateTimePickerData.Value = DateTime.Parse(reader["Data"].ToString());
            uxDateTimePickerData.Value = reader.GetDateTime(1);
            uxTextBoxArtist.Text = reader["Artist"].ToString();
            uxTextBoxPret.Text = reader["Pret"].ToString();
            uxComboBoxSuport.Text = reader["Suport"].ToString();


            if(!reader.IsClosed)
            {
                reader.Close();
            }
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void uxButtonNou_Click(object sender, EventArgs e)
        {
            uxTextBoxId.Text = "0";
            uxTextBoxDenumire.Text = "";
            uxTextBoxPret.Text = "0";
            uxTextBoxArtist.Clear();
            uxDateTimePickerData.Value = DateTime.Today;
            uxComboBoxSuport.Text = "";
        }

        private void uxButtonSalveaza_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = GetConexiune();
            OleDbCommand salveazaCommand = new OleDbCommand();
            salveazaCommand.Connection = conn;
            int id = int.Parse(uxTextBoxId.Text);
            if(id == 0)
            {
                salveazaCommand.CommandText = "insert into Albume(Data,Denumire,Artist,Pret,Suport) values(@data, @denumire,@artist,@pret,@suport)";
            }
            else
            {
                salveazaCommand.CommandText = "update Albume set Data=@data,Denumire=@denumire,Artist=@artist,Pret=@pret,Suport=@suport where ID=@id";
                salveazaCommand.Parameters.AddWithValue("id", id);
            }
            OleDbParameter data = new OleDbParameter();
            data.OleDbType = OleDbType.Date;
            data.Value = uxDateTimePickerData.Value;
            //preluam valoriele din controale

            int rec = salveazaCommand.ExecuteNonQuery();
            if(rec > 0)
            {
                MessageBox.Show("Salvare reusit!");
            }

            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
