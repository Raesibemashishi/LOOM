using logInn.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logInn.DataBase
{
    public class DBService
    {
        //DB name
        private const string DatabaseName = "ClientDetails.db3";

        //Connection of the DB
        private readonly SQLiteAsyncConnection _databaseConnect;

        //Constructor
        public DBService()
        {
            _databaseConnect = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DatabaseName));
            _ = _databaseConnect.CreateTableAsync<ClientDetails>().ConfigureAwait(false);
        }

        //Create  a list to store data 
        public async Task<List<ClientDetails>> GetClientDetails()
        { 
        
            return await _databaseConnect.Table<ClientDetails>().ToListAsync();
        
        }

        //DB (Create, Delete, Update, Display)
        

        //Display or  dirm the DB
        public async Task<ClientDetails> GetClientId(int id)
        {
            //i is the variable that will store the data from the DB and compare it with the id that we want to display
            return await _databaseConnect.Table<ClientDetails>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        //Create a Client record
        public async Task Create(ClientDetails client)
        {
           await _databaseConnect.InsertAsync(client);
        }

        //Update a Client detials.
        public async Task Update(ClientDetails client)
        {
            await _databaseConnect.UpdateAsync(client);
        }       

        //Delete a Client details
        public async Task Delete(ClientDetails client)//ClientDetails is the name of the class and client is the variable
        {
            await _databaseConnect.DeleteAsync(client);
        }
    }
}
