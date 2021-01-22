using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitXamarin1.Models
{
    public class TodoModel
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int Id { get; set; }
        [MaxLength(60), NotNull]
        public string TaskName { get; set; }
        

        public DateTime TaskDate { get; set; }
    }
}
