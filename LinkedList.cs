using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace LinkedListExample {
    public class Node {
        public int data;
        public Node next;

        public Node (int input) {
            data = input;
            next = null;
        }

        public void AddToEndOfList (int input) {
            if (next == null) {
                next = new Node (input);
            } else {
                next.AddToEndOfList (input);
            }
        }

        public void AddToStartOfList (int input) {
            if (next != null) {
                next = new Node (input);
            } else {
                next.AddToStartOfList (input);
            }
        }

        public void PrintNode () {
            Console.WriteLine (data);
            if (next != null) {
                next.PrintNode ();
            }
        }
    }

    public class LinkedList {
        public Node headNode;

        public LinkedList () {
            headNode = null;
        }

        public void AddToEndOfList (int input) {
            if (headNode == null) {
                headNode = new Node (input);
            } else {
                headNode.AddToEndOfList (input);
            }
        }

        public void AddToStartOfList (int input) {
            if (headNode == null) {
                headNode = new Node (input);
            } else {
                Node newNode = new Node (input);
                newNode.next = headNode;
                headNode = newNode;
            }
        }

        public void PrintList () {
            if (headNode != null) {
                headNode.PrintNode ();
            }
        }

        public LinkedList sortList (LinkedList unsortedList) {

            for (int i = 0; i < unsortedList.length; i++) {

            }
        }
    }

    public class Program {
        public static void Main () {
            LinkedList exampleList = new LinkedList ();
            exampleList.AddToEndOfList (1);
            exampleList.AddToEndOfList (2);
            exampleList.AddToEndOfList (3);
            exampleList.AddToEndOfList (4);
            exampleList.AddToStartOfList (5);
            exampleList.AddToStartOfList (6);
            exampleList.AddToStartOfList (7);
            exampleList.AddToStartOfList (8);
            exampleList.PrintList ();
        }
    }
}