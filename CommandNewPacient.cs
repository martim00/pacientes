using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pacientes
{
    public class CommandNewPacient : ICommand
    {
        public void Activate()
        {
            NewPacientDialog dialog = new NewPacientDialog();
            dialog.ShowDialog();

        }
    }
}
