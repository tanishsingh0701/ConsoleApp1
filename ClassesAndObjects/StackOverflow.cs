using System;

namespace ClassesAndObjects
{
    public class StackOverflow 
    {
        private string _title;
        private string _description;
        private DateTime _createdTime;

        private int total_vote=0;


        public int GetVote
        {
            get
            {
                return this.total_vote;
            }

        }
        public StackOverflow(string title,string description,DateTime createdTime)
        {
            _title = title;
            _description = description;
            _createdTime = createdTime;

        }

        public void UpVote() 
        {
            total_vote += 1;
        }

        public void DownVote() 
        {
            total_vote -= 1;

        
        }
        


    }
}
