using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections.Immutable;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace ProMtaBrain
{
    public enum eBranch
    {
        user = -1,
        LaundryBlog = 0,
        EventBlog = 1,
        SportBlog = 2
    }

    public class BigDataPro
    {
        Member currentMember = null; // current data process //
        public DataStatusEventFriends myProMtaData { private set; get; }

        public BigDataPro()
        {
            myProMtaData = new DataStatusEventFriends();
            Make_Branchs();
        }

        public Member CurrentMember { get => currentMember; set => currentMember = value; }
        public Branch[] ProMtaBranch { set; get; }

        void Make_Branchs()
        {
            ProMtaBranch = new Branch[3];
            ProMtaBranch[0] = new Branch("Laundry:", "open time: 10:00\nclose time: 19:30");
            ProMtaBranch[1] = new Branch("Event:", "Post Event to invite everyone!");
            ProMtaBranch[2] = new Branch("Sport:", "Let's do sports!\nPublish statuses and sports events! :)");
        }
        public bool Connect_member(string name, string password)
        {
            currentMember = myProMtaData.FriendsList.Find(x => x.Name == name); //if dont found it will be null

            if (currentMember != null)
            {
                if (currentMember.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public void Add_new_user(Member mewMember)
        {
            myProMtaData.Add_to_friendsList(mewMember);
        }
        public void Add_event(eBranch typeBranch, Event newEvent)
        {
            ProMtaBranch[(int)typeBranch].MyData.Add_to_eventList(newEvent);
            currentMember.MyData.Add_to_eventList(newEvent);
        }
        public void Add_status(eBranch typeBranch, Status newStatus)
        {
            ProMtaBranch[(int)typeBranch].MyData.Add_to_statusList(newStatus);
            currentMember.MyData.Add_to_statusList(newStatus);
        }
        public static BigDataPro Load_from_file()
        {
            BigDataPro loadObj=null;
            Stream stream = null;
            if (File.Exists(@"D:\a.xml"))
            {
                try
                {
                    stream = new FileStream(@"D:\a.xml", FileMode.Open);
                    XmlSerializer serializer = new XmlSerializer(typeof(BigDataPro));
                    loadObj = serializer.Deserialize(stream) as BigDataPro;
                }
                catch
                {
                    loadObj = new BigDataPro();
                }
                finally
                {
                    stream.Dispose();
                }
            }
            else
            {
                loadObj = new BigDataPro();
            }
            loadObj.myProMtaData.FriendsList.Count();
            return loadObj;
        }
        public void Save_to_file()
        {
            if (!File.Exists(@"D:\a.xml"))
            {
                File.Create(@"D:\a.xml");
            }

            using (Stream stream = new FileStream(@"D:\a.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}



