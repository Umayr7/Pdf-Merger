using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    class LinkedList
    {
        public Node head;
        public Node tail;

        public void insert(string p)
        {
            Node curr = new Node(p);
            if (head == null)
            {
                head = curr;
                tail = curr;
            }
            tail.next = curr;
            tail = tail.next;
        }
        public int len()
        {
            int length = 0;
            Node curr = head;
            if (head == null)
            {
                return 0;
            }
            while (curr != null)
            {
                length++;
                curr = curr.next;
            }
            return length;
        }
    }
}
