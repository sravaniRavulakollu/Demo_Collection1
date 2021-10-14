using System;
using System.Collections.Generic;
using System.Collections;

namespace Demo_Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stack<string> Numbers = new Stack<string>();
            Numbers.Push("one");
            Numbers.Push("Two");
            Numbers.Push("Three");

            foreach(var item in Numbers)
            {
                Console.WriteLine("Following the items" + item);
            }
            Queue<int> MyQue = new Queue<int>();
            MyQue.Enqueue(120);
            MyQue.Enqueue(220);
            MyQue.Enqueue(330);
            foreach (var item in MyQue)

            Console.WriteLine("First Element that is removed from the queue is{0}", MyQue.Dequeue());
            Console.WriteLine("Total count of the queue is {0}", MyQue.Count);
            Console.WriteLine("Type of the queue is {0}", MyQue.GetType());

            ArrayList MyArrayList = new ArrayList();
            MyArrayList.Add(10);
            MyArrayList.Add("sravani");
            MyArrayList.Add(6.8775);
            MyArrayList.Add(true);
            MyArrayList.Add("DividedByZeroException");
            foreach(var item in MyArrayList)
            {
                Console.WriteLine("Content of my Array List which is non-generic  type of collection {0}\n", item);
            }
            SortedList<string, int> GameScore = new SortedList<string, int>();
            GameScore.Add("My COD Score was",1446);
            GameScore.Add("Last Week NFS Score was", 4534);
            GameScore.Add("FIFA Score is", 764);
            foreach(var item in GameScore)
            {
                Console.WriteLine("Content of GameScore Collection is \t {0} and value \t {1}\n", item.Key, item.Value);

            }
            Dictionary<string, string> PasswordDetails = new Dictionary<string, string>();
            PasswordDetails.Add("Facebook", "@#$%^&");
            PasswordDetails.Add("Instagram", "*$%^#");
            PasswordDetails.Add("Outlook.com", "QUERY");

            foreach(var item in PasswordDetails)
            {
                Console.WriteLine("Content of the Dictonary with  \t key is: {0},\t{1}", item.Key, item.Value);

            }
            Console.WriteLine("total count of the element {0}", PasswordDetails.Count);

            Hashtable MyHashTable = new Hashtable();
            MyHashTable.Add(01, "hyd");
            MyHashTable.Add(02, "vij");
            MyHashTable.Add(03, "gnt");
            Console.WriteLine("Total Content of the HashTable is {0}", MyHashTable.Count);
            foreach(DictionaryEntry item in MyHashTable)
            {
                Console.WriteLine("Hash Code of the elemnt is {0}\n", item.GetHashCode());
                Console.WriteLine("Content of the table is \t key:{0} and value:{1}\n", item.Key, item.Value);
            }

        }
    }
}
