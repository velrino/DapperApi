using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiDapper.Models
{
    public class RawLogDatami
    {
        public string campanha_id { get; set; }
        public DateTime campaign_date { get; set; }
        public int total_data_usage { get; set; }
        public int total_users { get; set; }
        public int new_users { get; set; }
        public int usage_per_user { get; set; }
        public string hourly { get; set; }
        public string device_os { get; set; }
        public string device_make { get; set; }
    }
}