using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMtaBrain
{
   // [Serializable]
    public class DataStatusEventFriends
    {
        List<Status> statusList=null;
        List<Event> eventList=null;
        List<Member> friendsList=null;

        public DataStatusEventFriends()
        {
            statusList = new List<Status>();
            eventList = new List<Event>();
            friendsList = new List<Member>();
        }

        public List<Event> EventList { get => eventList;}
        public List<Member> FriendsList { get => friendsList;}
        public List<Status> StatusList { get => statusList;}

        public void Add_to_statusList(Status statusToAdd)
        {
            statusList.Add(statusToAdd);
        }
        public void Add_to_eventList(Event eventToAdd)
        {
            eventList.Add(eventToAdd);
        }
        public void Add_to_friendsList(Member memberToAdd)
        {
            friendsList.Add(memberToAdd);
        }
        public void Reverse_all_lists()
        {
            statusList.Reverse();
            eventList.Reverse();
        }
    }
}
