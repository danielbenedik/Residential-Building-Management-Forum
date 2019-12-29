using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProMtaBrain
{
    [Serializable]
    public class Event : Expression
    {
        string meetingPoint;
        DateTime meetingTime;

        public Event(string _namOfBranch, string _title, string _content, DateTime _timeCreated, string _meetingPoint, DateTime _meetingTime) : base(_namOfBranch, _title, _content,  _timeCreated)
        {
            meetingPoint = _meetingPoint;
            meetingTime = _meetingTime;
        }

        public DateTime MemeetingTime { get => meetingTime;}
        public string MeetingPoint { get => meetingPoint;}
    }
}