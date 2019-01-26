using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConnectEm
{
    [Serializable()]
    public class Users : ISerializable
    {
        public string name;
        public string cityName;
        public int age;
        public string emailAddress;
        public string password;
        public long phoneNumber;

        public Users()
        { }
        public Users(string n,string cn,int a,string e,string p,long ph)
        {
            name = n;
            cityName = cn;
            age = a;
            emailAddress = e;
            password = p;
            phoneNumber = ph;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", name);
            info.AddValue("City_Name", cityName);
            info.AddValue("Age", age);
            info.AddValue("Email_Address", emailAddress);
            info.AddValue("Password", password);
            info.AddValue("Phone_Number", phoneNumber);
        }
        public Users(SerializationInfo info, StreamingContext context)
        {
            name = (string)info.GetValue("Name", typeof(string));
            cityName = (string)info.GetValue("City_Name", typeof(string));
            age = (int)info.GetValue("Age", typeof(int));
            emailAddress = (string)info.GetValue("Email_Address", typeof(string));
            password = (string)info.GetValue("Password", typeof(string));
            phoneNumber = (long)info.GetValue("Phone_Number", typeof(long));
        }
    }
}
