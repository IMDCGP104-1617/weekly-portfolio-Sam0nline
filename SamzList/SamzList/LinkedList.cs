﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamzList
{
    class LinkedList
    {
        public class Node
        {
            public object Content;
            public Node Next;
        }

        private Node head;
        
        public LinkedList()
        {
            head = null;
        }

        public void InsertBeginning(object content)
        {
            Node firstNode = new Node();
            firstNode.Content = content;

            if (head == null)
            {
                head = firstNode;
            }
            else
            {
                firstNode.Next = head;
                head = firstNode;
            }
        }

    }
}

