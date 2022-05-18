using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BDs
{
    public static class BDD
    {
        public static MySqlConnection? BDConnection;
        public static bool initConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "e1";
            string passwd = "asgpf80000";
            string BD = "basee1";
            string chaineDeConnexion = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            BDConnection = new MySqlConnection(chaineDeConnexion);

            try
            {
                BDConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool fermerConnexion()
        {
            bool retour = false;
            if (BDConnection.State == System.Data.ConnectionState.Open)
            {
                BDConnection.Close();
                retour = true;
            }
            return retour;
        }
    }
}