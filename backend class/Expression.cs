using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProMtaBrain
{
    [Serializable]
    public abstract class Expression
    {
        string nameOfBranch;
        string title;
        string content;
        DateTime timeCreated;

        public Expression(string _nameOfBranch, string _title , string _content, DateTime _timeCreated)
        {
            nameOfBranch = _nameOfBranch;
            title = _title;
            content = _content;
            timeCreated = _timeCreated;
        }

        public string Title { get => title;}
        public string Content { get => content; }
        public DateTime Time { get => timeCreated; }
        public string NameOfBranch { get => nameOfBranch;}
    }
}