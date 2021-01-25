using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace active_directory_wpf_msgraph_v2
{
    public class PostmanEnvironment
    {
        public PostmanEnvironment()
        {

        }
        public string id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public string uid { get; set; }
        public List<EnvironmentKeyValue> values { get; set; }
    }
    public class EnvironmentKeyValue
    {
        public string key { get; set; }
        public string value { get; set; }
        public bool enabled { get; set; }
    }
}
