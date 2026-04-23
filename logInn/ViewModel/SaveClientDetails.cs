
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
       // private object existingClient;


        //Editing Client Details
        public bool IsEditingMode { get; set; }
        public ClientDetails EditingClient { get; set; }

        //Defining the properties
        public string Name
                    {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();

            }
        }

        
        public string Email 
        {
            get => email;
            set
            {
                email = value; 
                OnPropertyChanged();

            }
        }

       

        public string Password
        {
            get => password;
            set
            {
                password = value; 
                OnPropertyChanged(); 

            }
        }
        //The end of the information to save to the DB


        //Buttons

        public ICommand SaveEditedCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SignInCommand { get; }
        public ICommand SignUpHereCommand { get; }
        
        private Page page;

        //Constructor for the button
        public SaveClientDetails(Page _page)
        {
            SaveCommand = new Command(async () => await SaveMethod());
            SaveEditedCommand = new Command(async () => await SaveEditedMethod());
            SignInCommand = new Command(async () => await SignInMethod());
            SignUpHereCommand = new Command(async () => await SignUpHereMethod());
            page = _page;
           
            //Load Clients Details 
            LoadClientDetails();
            
        }

      


        //This method will navigate the client to the sign up page
        private async Task SignUpHereMethod()
        {
            await Shell.Current.GoToAsync("///SignUpHere");
        }


        //Loading Client Details
        private async Task LoadClientDetails()
        { 
           var client = await dBService.GetClientDetails();
            ClientDetails.Clear();

            foreach (var item in client)
            {
                ClientDetails.Add(item);
            }
        }


        //This method will sign in the client to the app
        private async Task SignInMethod()
        {
            await Shell.Current.GoToAsync("///HomePage");
        }


        //This method will save the edited details of the client
        private async Task SaveEditedMethod()
        {
            if (IsEditingMode && EditingClient != null)
            {
                //Update the client deatils
                EditingClient.Name = Name;
                EditingClient.Email = Email;
                EditingClient.Password = Password;

                //Save the updated details to the db
                await dBService.Update(EditingClient);

                //Refresf the Client Details list
                int index = ClientDetails.IndexOf(EditingClient);

                if (index >= 0)
                {
                    ClientDetails.RemoveAt(index);
                    ClientDetails.Insert(index, EditingClient);
                }

                await Shell.Current.DisplayAlert("Message", "Saved Successfuly", "OK");
                IsEditingMode = false;
                EditingClient = null;


                //Clear the fields
                Name = string.Empty;
                Email = string.Empty;
                Password = string.Empty;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(Password));
            }
            else
            {
                await Shell.Current.DisplayAlert("Message", "Click details to edit", "OK");
            }
        }

        private async Task SaveMethod()
        {
            //Validate the fields
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Email))
            {
                await Shell.Current.DisplayAlert("error", "Please fill all fields","OK");
                return;
            }
            else
            {
                // Get infor/Client form the DB

                var exixstingClient = await dBService.GetClientDetails();
                
                //Check if email exist in DB
               bool emailExist = exixstingClient.Any(c => c.Email == Email);
                


                if (emailExist)
                {
                    await Shell.Current.DisplayAlert("error", "Email alreadY exist", "OK");
                    return;
                }

                //Create  a new client details
                var newClient = new ClientDetails
                {
                    Name = Name,
                    Email = Email,
                    Password = Password
                };

                await dBService.Create(newClient);
                ClientDetails.Add(newClient);
                await Shell.Current.DisplayAlert("Success", "Client details saved", "Ok");
                

                
            }

            //Clear the fields
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Email));
            OnPropertyChanged(nameof(Password));

        }

        public async Task OnClientTapped(ClientDetails client)
        {
            var action = await page.DisplayActionSheet
                ("Choose an action",
                "Cancel", 
                null,
                "Edit",
                "Delete");
            switch (action)
            {
                case "Edit":
                    IsEditingMode = true;
                    EditingClient = client;
                    Name = client.Name;
                        Email = client.Email;
                        Password = client.Password;
                        
                    break;
                case "Delete":
                    await dBService.Delete(client);
                    LoadClientDetails();
                    //Clear the fields
                    Name = string.Empty;
                    Email = string.Empty;
                    Password = string.Empty;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(Password));


                    break;

            
            }

        }

        protected void OnPropertyChanged([CallerMemberNameAttribute] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
