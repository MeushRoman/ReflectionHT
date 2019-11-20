using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlUpdatуR
{
    class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>();

            users.Add(new User("name1", 22));
            users.Add(new User("Name2", 23));
            users.Add(new User("Name3", 24));

            User user = users.FirstOrDefault();

            user.name = "Name4";
            DB db = new DB();

            string str = db.Update(user);
        }
    }
}
