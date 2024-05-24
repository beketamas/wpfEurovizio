using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WpfApp1
{
    class Eurovizio
    {
        int ev;
        string eloado;
        string cim;
        int helyezes;
        int pontszam;

        public Eurovizio(MySqlDataReader olvas)
        {
            this.ev = olvas.GetInt32(0);
            this.eloado = olvas.GetString(1);
            this.cim = olvas.GetString(2);
            this.helyezes = olvas.GetInt32(3);
            this.pontszam = olvas.GetInt32(4);
        }

        public int Ev { get => ev; set => ev = value; }
        public string Eloado { get => eloado; set => eloado = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
    }
}
