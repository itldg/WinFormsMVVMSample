using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading;
using System.Threading.Tasks;
using WinFormsMVVMSample.Model;

namespace WinFormsMVVMSample.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Sum))]
        int num1 = 0;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Sum))]
        int num2 = 0;

        [ObservableProperty]
        Person person = new Person();

        [ObservableProperty]
        bool canClick = true;

        public int Sum => Num1 + Num2;
        //[RelayCommand]
        //void Reset()
        //{
        //    _reset();
        //}

        [RelayCommand]
        async Task ResetAsync()
        {
            CanClick = false;
            await Task.Delay(3000);
            _reset();
            CanClick = true;
        }
        void _reset()
        {

            Person.FirstName = "";
            Person.LastName = "";
            Num1 = 0;
            Num2 = 0;
        }
    }
}
