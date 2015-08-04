using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pacientes.model;

namespace pacientes.ViewModel
{
    public class NewPacientViewModel
    {
        private DbService dbService;

        public NewPacientViewModel(DbService dbService)
        {
            this.dbService = dbService;
        }

        public void SavePacient(String name)
        {
            Pacient pacient = new Pacient();
            pacient.Name = name;
            dbService.SavePacient(pacient);

        }
    }
}
