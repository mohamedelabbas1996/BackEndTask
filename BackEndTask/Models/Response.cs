using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndTask.Models
{
    public class Response
    {
        public IEnumerable<Item> Items { get; set; }
        public bool  has_more {set;get;}
        public int quota_max { set; get; } 
        public int quota_remaining { set; get; }
    }
}