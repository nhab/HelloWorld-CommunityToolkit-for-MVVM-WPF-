using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    public  partial class MainWindowViewModel:ObservableObject
    {
        [ObservableProperty]
       // [NotifyCanExecuteChangedFor(nameof(Click))]
        private string? firstName = "kevin";

        private bool CanClick() => FirstName == "kevin";

        [RelayCommand(CanExecute =nameof(CanClick))]
        private async Task Click()
        {
            FirstName = "Robert";
        }
    }
}
