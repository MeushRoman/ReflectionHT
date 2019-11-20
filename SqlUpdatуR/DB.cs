using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlUpdatуR
{
    public class DB
    {
        
        public string Update(object obj)
        {
            Type type = obj.GetType();

            var prop = type.GetProperties();

            string str = "UPDATE " + type.Name + " SET";
            for (int i = 1; i < prop.Length; i++)
            {
                str += " " + prop[i].Name + " = '" + prop[i].GetValue(obj) + "'";
            }
            str += " WHERE " + prop[0].Name + " = '" + prop[0].GetValue(obj) + "'";
                       
            return str;
        }
    }
}
