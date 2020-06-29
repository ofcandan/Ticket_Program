using System;
using System.Windows.Input;
using Xamarin.Forms;
using beispiel.Models;

namespace beispiel.ViewModels
{
    public class TicketDetailViewModel : BaseViewModel
    {
        private Ticket _ticket;

        public TicketDetailViewModel(Ticket ticket)
        {
            _ticket = ticket;
        }

        public string Title
        {
            get => _ticket.Title;
            set
            {
                _ticket.Title = value;
                RaisePropertyChanged();
            }
           
        }
        public string Description
        {
            get => _ticket.Description;
            set
            {
                _ticket.Description = value;
                RaisePropertyChanged();
            }
        }
        public string EventModel
        {
            get => _ticket.EventModel;
            set
            {
                _ticket.EventModel = value;
                RaisePropertyChanged();
            }
        }
        public DateTime EventDate
        {
            get => _ticket.EventDate;
            set
            {
                _ticket.EventDate = value;
                RaisePropertyChanged();
            }
        }
    }
}

