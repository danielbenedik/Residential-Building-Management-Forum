using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMtaBrain
{
   // [Serializable]
    public class SportEvent : Event
    {
        string nameOfTheActivity;
        int lengthOfThePath;

        public SportEvent(string _namOfBranch, string _title, string _content, DateTime _timeCreated, string _meetingPoint, DateTime _meetingTime, string _nameOfTheActivity, int _lengthOfThePath=0) : base(_namOfBranch, _title,  _content,  _timeCreated, _meetingPoint, _meetingTime)
        {
            nameOfTheActivity = _nameOfTheActivity;
            lengthOfThePath = _lengthOfThePath;
        }

        public string NameOfTheActivity { get => nameOfTheActivity;}
        public int LengthOfThePath { get => lengthOfThePath; }
    }
}
