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
    }
}
