using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using pacientes.model;
using System.Collections.ObjectModel;

namespace pacientes.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private CommandManager commandManager;
        private DbService dbService;

        public MainWindowViewModel(CommandManager commandManager, DbService dbService)
        {
            this.commandManager = commandManager;
            this.dbService = dbService;
            this.dbService.OnPacientAdded += UpdatePacients;
            this.UpdatePacients(null);

        }

        private void UpdatePacients(EventArgs e)
        {
            AllPacients = new ObservableCollection<Pacient>(dbService.FindAllPacients());
            this.OnPropertyChanged("AllPacients");
        }

        public ObservableCollection<Pacient> AllPacients
        {
            get; private set;
        }

        public ICommand NewPacientCommand {
            get {
                return new DelegateCommand(
                    () =>
                    {
                        this.commandManager.ActivateCommand(typeof(CommandNewPacient).Name);
                    }, () => { return true; }
                    );
                
            }
        }

    }
}
