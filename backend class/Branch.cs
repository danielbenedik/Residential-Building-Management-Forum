using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMtaBrain
{
   // [Serializable]
    public class Branch
    {
        string name;
        string usefulInformation;
        DataStatusEventFriends myData=null;

        public Branch(string _name, string _usefulInformation)
        {
            name = _name;
            usefulInformation = _usefulInformation;
            myData = new DataStatusEventFriends();
        }

        public string Name { get => name;}
        public string UsefulInformation { get => usefulInformation;}
        public DataStatusEventFriends MyData { get => myData; }
        public Branch() { }
    }
}
