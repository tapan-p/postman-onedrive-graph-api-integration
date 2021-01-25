using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace active_directory_wpf_msgraph_v2
{
    public class PostmanCollection
    {
        public PostmanCollection()
        {

        }
        public List<PostmanVariable> variable { get; set; }
    }
    public class PostmanVariable
    {
        public PostmanVariable()
        {

        }
        public string id { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }
}
