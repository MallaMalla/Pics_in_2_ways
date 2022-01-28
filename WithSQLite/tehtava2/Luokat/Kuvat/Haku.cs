using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava2
{
    public class Haku
    {
        private DataTable dt = new DataTable();

        public DataTable Dt
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
            }
        }

        public void haeNimi(int count)
        {

            SQLiteConnection sqlite_conn;

            //Tietokantayhteyden avaus
            sqlite_conn = new SQLiteConnection("Data Source = nimet.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            SQLiteDataReader reader;
            SQLiteCommand sqlCmd;
            sqlCmd = sqlite_conn.CreateCommand();
            sqlCmd.CommandText = "SELECT nimi FROM kuva WHERE ID = " + count;

            reader = sqlCmd.ExecuteReader();

            Dt.Load(reader);

            sqlite_conn.Close();
        }

    }
}