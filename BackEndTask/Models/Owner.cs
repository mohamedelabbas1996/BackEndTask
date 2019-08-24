using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndTask.Models
{
    public class Owner
    {
        public int reputation { set; get; }
        public int user_id { set; get; }
        public string user_type { set; get; }
        public string profile_image { set; get; }
        public string display_name { set; get; }
        public string link { get; set; }
    }
}