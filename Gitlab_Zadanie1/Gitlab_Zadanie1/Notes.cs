using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab
{
    class Author
    {
        public string Name { get; set; }
    }
    internal class Notes
    {
        public string body { get; set; }
        public Author author { get; set; }
    }
}
