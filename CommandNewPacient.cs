using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pacientes.ViewModel;

namespace pacientes
{
    public class CommandNewPacient : IAction
    {
        private DbService dbService;

        public CommandNewPacient(DbService dbService) 
        { 
            this.dbService = dbService;

        }
        public void Activate()
        {
            NewPacientViewModel vm = new NewPacientViewModel(dbService);
            NewPacientDialog dialog = new NewPacientDialog(vm);
            dialog.ShowDialog();

        }
    }
}
