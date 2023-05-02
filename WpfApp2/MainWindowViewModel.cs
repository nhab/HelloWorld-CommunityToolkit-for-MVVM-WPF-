using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp2
{
    public  partial class MainWindowViewModel:ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ClickCommand))]
        private string? firstName = "kevin";

        public IRelayCommand ClickCommand { get; }
        public MainWindowViewModel()
        {
            ClickCommand = new RelayCommand(OnClick,CanClick);
        }
        private bool CanClick() => FirstName == "kevin";

       
        private void OnClick()
        {
            FirstName = "Robert";
        }
    }
}
