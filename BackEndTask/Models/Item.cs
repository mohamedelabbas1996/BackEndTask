using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndTask.Models
{
    public class Item
    {
        public IEnumerable<string> Tags { set; get; }
        public Owner owner { set; get; }
        public Boolean is_answered { set; get; }
        public int view_count { set; get; }
        public int answer_count { set; get; }
        public int score { get; set; }
        public int last_activity_date { set; get; }
        public int creation_date { get; set; }
        public int question_id { set; get; }
        public string link { set; get; }
        public string title { set; get; }
    }
}