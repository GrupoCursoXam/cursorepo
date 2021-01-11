using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GitXamarin1.Models;
using SQLite;

namespace GitXamarin1.Data
{
    public class DatabaseQuery      //Must be public, remember
    {
         readonly SQLiteAsyncConnection _database;
        public DatabaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Users>().Wait();
        }

        #region CRUD
        public Task<List<Users>> GetUsers()
        {
            return _database.QueryAsync<Users>("Select * from users");
        }

        public Task<int> SaveUserAsync(Users users)
        {
            if (users.Id != 0)
            {    //If exist, UPDATE
                return _database.UpdateAsync(users);
            }
            else {
                return _database.UpdateAsync(users);
            }
        }
        //Delete
        public Task<int> DeleteUserAsync(Users users)
        {
            return _database.DeleteAsync(users);
        }
         #endregion
    }
}
