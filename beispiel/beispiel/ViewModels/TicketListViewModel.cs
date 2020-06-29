using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace beispiel.ViewModels
{
    public class TicketListViewModel : BaseViewModel
    {

        private ObservableCollection<TicketDetailViewModel> tickets;
       

        public TicketListViewModel(INavigation navigation)
        {
            Tickets = new ObservableCollection<TicketDetailViewModel>();
            
        }

        public ObservableCollection<TicketDetailViewModel> Tickets
        {
            get => tickets; set
            {
                tickets = value;
                RaisePropertyChanged();
            }
        }
    }
}
