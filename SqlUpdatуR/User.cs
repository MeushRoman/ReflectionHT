using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlUpdatуR
{
    class User
    {
        public Guid GUID { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public User(string name, int age)
        {
            this.GUID = Guid.NewGuid();
            this.name = name;
            this.age = age;
        }
    }
}
