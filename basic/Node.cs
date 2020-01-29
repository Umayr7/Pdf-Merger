using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    class Node
    {
        public Node next;
        public string path;

        public Node(string path)
        {
            this.path = path;
            next = null;
        }
    }
}
