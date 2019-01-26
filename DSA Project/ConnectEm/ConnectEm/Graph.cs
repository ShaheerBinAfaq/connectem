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
    public class Graph : ISerializable
    {
        public string name;
        public List<string> friends = new List<string>();
        public Graph()
        { }
        public Graph(string n)
        {
            this.name = n;            
        }

        public void AddFriend(Graph f)
        {
            friends.Add(f.name);
            f.friends.Add(this.name);
        }
        public void RemoveFriend(Graph f)
        {
            friends.Remove(f.name);
            f.friends.Remove(this.name);
        }
        public int getNumberOfFriends()
        {
            return friends.Count();
        }
        public string[] getNameOfFriends()
        {
            string[] FriendsName = new string[friends.Count];
            int i = 0;
            foreach (string f in friends)
            {
                FriendsName[i] = f;
                i++;
            }

            return FriendsName;
        }
        public bool FriendOrNot(Graph f)
        {            
            foreach(string b in friends)
            {
                if (b == f.name)
                    return true;
            }
            return false;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", name);
            info.AddValue("FriendsList", friends);
        }
        public Graph(SerializationInfo info, StreamingContext context)
        {
            name = (string)info.GetValue("Name",typeof(string));
            friends = (List<string>)info.GetValue("FriendsList", typeof(List<string>));
        }
    }
}
