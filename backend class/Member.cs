using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMtaBrain
{
    //[Serializable]
    public class Member
    {
        // private Data //
        string name;
        DateTime dateOfBirth;
        int Id;
        bool isMen;
        string password;
        MailAddress mailAddress=null;
        // data//
        DataStatusEventFriends myData=null;

        public Member(string _name, DateTime _dateOfBirth, bool _isMen, MailAddress _mailAddress, string _password, int _ID = 0)
        {
            name = _name;
            dateOfBirth = _dateOfBirth;
            Id = _ID;
            isMen = _isMen;
            password = _password;
            mailAddress = _mailAddress;

            myData = new DataStatusEventFriends();
        }
        public Member() { }

        public string Name { get => name; }
        public DateTime DateOfBirth { get => dateOfBirth; }
        public int ID { get => Id;}
        public bool IsMen { get => isMen;}
        public string Password { get => password;}
        public DataStatusEventFriends MyData { get => myData;}
        public MailAddress MailAddress { get => mailAddress;}
    }
}
