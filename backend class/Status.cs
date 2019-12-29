using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMtaBrain
{
    //[Serializable]
    public class Status : Expression
    {
        string ImageFilePath;

        public Status(string _namOfBranch, string _title, string _content, DateTime _timeCreated, string _ImageFilePath = null) : base(_namOfBranch, _title, _content, _timeCreated)
        {
            ImageFilePath = _ImageFilePath;
        }

        public string ImageFilePath1 { get => ImageFilePath;}
    }
}
