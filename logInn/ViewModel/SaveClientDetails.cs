
using logInn.DataBase;
using logInn.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace logInn.ViewModel
{
    public class SaveClientDetails : INotifyPropertyChanged
    {

        //Access to the DB
        private readonly DBService dBService = new DBService();

        //ObservableCollection for adding and removing items from the list
        public ObservableCollection<ClientDetails> ClientDetails { get; set; } 
        = new ObservableCollection<ClientDetails>();



        //Info to save to the DB
        private string name;
        private string email;
        private string password;

        //Defining the properties
        private string Name
                    {
            get => name;
            set
            {
                name = value; OnPropertyChanged();

            }
        }

        
        private string Email 
        {
            get => Email;
            set
            {
                Email = value; OnPropertyChanged();

            }
        }

       

        private string Password
        {
            get => password;
            set
            {
                Password = value; OnPropertyChanged(); 

            }
        }
        //The end of the information to save to the DB


        //Buttons

        public ICommand SaveEditedCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SignInCommand { get; }
        public ICommand SignUpHereCommand { get; }

        //Constructor for the button
        public SaveClientDetails()
        {
            SaveCommand = new Command(async () => await SaveMethod());
             SaveEditedCommand = new Command(async () => await SaveEditedMethod());
            SignInCommand = new Command(async () => await SignInMethod());
            SignUpHereCommand = new Command(async () => await SignUpHereMethod());

            //Load Clients Details 
            LoadClientDetails();
        }

        private async Task SignUpHereMethod()
        {
            throw new NotImplementedException();
        }


        //Loading Client Details
        private void LoadClientDetails()
        { 
        
        }

        private async Task SignInMethod()
        {
            throw new NotImplementedException();
        }

        private async Task SaveEditedMethod()
        {
            throw new NotImplementedException();
        }

        private async Task SaveMethod()
        {
            throw new NotImplementedException();
        }

        protected void OnPropertyChanged([CallerMemberNameAttribute] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
