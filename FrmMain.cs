using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMVVMSample.ViewModel;

namespace WinFormsMVVMSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            InitMVVM();
        }
        void InitMVVM()
        {


            MainViewModel mainViewModel = new MainViewModel();

            txtFirstName.DataBindings.Add("Text", mainViewModel.Person, nameof(mainViewModel.Person.FirstName), false, DataSourceUpdateMode.OnPropertyChanged);
            txtLastName.DataBindings.Add("Text", mainViewModel.Person, nameof(mainViewModel.Person.LastName), false, DataSourceUpdateMode.OnPropertyChanged);
            lblFullName.DataBindings.Add("Text", mainViewModel.Person, nameof(mainViewModel.Person.FullName));

            nud1.DataBindings.Add("Value", mainViewModel, nameof(mainViewModel.Num1), false, DataSourceUpdateMode.OnPropertyChanged);
            nud2.DataBindings.Add("Value", mainViewModel, nameof(mainViewModel.Num2), false, DataSourceUpdateMode.OnPropertyChanged);
            lblSum.DataBindings.Add("Text", mainViewModel, nameof(mainViewModel.Sum));

            btnReset.Click += (object sender, EventArgs e) => mainViewModel.ResetCommand.Execute(null);
            btnReset.DataBindings.Add("Enabled", mainViewModel, nameof(mainViewModel.CanClick));

        }
    }
}
