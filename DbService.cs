using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using pacientes.model;
using pacientes.Util;

namespace pacientes
{
    public class DbService
    {
        private SQLiteConnection db;

        public event GenericHandler OnPacientAdded;

        public void Init()
        {
            this.db = new SQLiteConnection("db");
            this.db.CreateTable<Pacient>();
        }

        public void SavePacient(Pacient pacient)
        {
            this.db.Insert(pacient);
            this.OnPacientAdded.Invoke(null);
        }

        public IEnumerable<Pacient> FindAllPacients()
        {
            return this.db.Query<Pacient>("select * from Pacient");
        }
    }
}
