using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOverFlowPost
{
    class Post
    {
        public string _title { get; set; }
        public string _description { get; set; }
        public DateTime _created { get; }
        private int _votes;

        public Post()
        {
            _created = DateTime.Now;
        }

        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public int GetVotes()
        {
           return _votes;
        }

    }
}
