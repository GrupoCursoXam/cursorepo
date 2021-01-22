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
            _database.CreateTableAsync<TodoModel>().Wait();
        }

        #region CRUD
        public Task<List<Users>> GetUsers()
        {
            return _database.QueryAsync<Users>("Select * from users");
        }
        // Get One
        public Task<TodoModel> GetTaskModelAsync(int id)
        {
            return _database.Table<TodoModel>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        //Get all
        public Task<List<TodoModel>> GetTaskModel()
        {
            return _database.Table<TodoModel>().ToListAsync();
        }

        public Task<int> SaveTodoAsync(TodoModel todom)
        {
            if (todom.Id!= 0)
            {    //If exist, UPDATE
                return _database.UpdateAsync(todom);
            }
            else
            {
                return _database.InsertAsync(todom);
            }
        }

        public Task<int> SaveUserAsync(Users users)
        {
            if (users.Id != 0)
            {    //If exist, UPDATE
                return _database.UpdateAsync(users);
            }
            else {
                return _database.InsertAsync(users);
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
