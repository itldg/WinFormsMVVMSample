using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVVMSample.Model
{
    public partial class Person : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string firstName = "";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string lastName = "";

        public string FullName => $"{FirstName} {LastName}";
    }
}
