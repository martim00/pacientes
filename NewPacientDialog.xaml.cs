using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using pacientes.ViewModel;

namespace pacientes
{
    /// <summary>
    /// Interaction logic for NewPacientDialog.xaml
    /// </summary>
    public partial class NewPacientDialog : Window
    {
        private NewPacientViewModel vm;

        public NewPacientDialog(NewPacientViewModel vm)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;               // don't show the dialog on the taskbar
            this.Topmost = true;                      // ensure we're Always On Top
            this.ResizeMode = ResizeMode.NoResize;    // remove excess caption bar buttons
            this.Owner = Application.Current.MainWindow;
            this.vm = vm;
        }

        private void SavePacientHandler(object sender, RoutedEventArgs e)
        {
            vm.SavePacient(this.pacientName.Text);
            this.Close();
        }
    }
}
