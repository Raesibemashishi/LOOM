using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logInn.Model
{
    [SQLite.Table("UserDetails")]
    public class ClientDetails
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]

        [SQLite.Column("Id")]
        public int Id { get; set; }
        [SQLite.Column("Name")]
        public string Name { get; set; }

        [SQLite.Column("Email")]
        public string Email { get; set; }

        [SQLite.Column("Password")]
        public string Password { get; set; }
    }
}
