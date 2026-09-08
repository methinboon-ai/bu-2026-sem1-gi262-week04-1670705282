using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            //string[] playerName = new string[20];
            LinkedList<string> linkedlist = new LinkedList<string>();

            // [Node 1]
            linkedlist.AddLast("Node 1");

            // [Node 1]<-[Node 2]
            linkedlist.AddLast("Node 2");

            // [Node 0]<-[Node 1]<-[Node 2]
            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> firstNode = linkedlist.First;
            Debug.Log("first: " + firstNode.Value);

            LinkedListNode<string> lastNode = linkedlist.Last;
            Debug.Log("last: " + lastNode.Value);

            Debug.Log("firstNode.Next: " + firstNode.Next.Value);
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();

        }

        #endregion
    }
}
