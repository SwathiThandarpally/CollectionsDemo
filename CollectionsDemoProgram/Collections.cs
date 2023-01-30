using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemoProgram
{
    public  class Collections
    {
        public  void Listdemo()
        {
            Console.WriteLine("In doListdemo");
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Carrot");
            list.Add("Dragon");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        public  void Stackdemo()
        {
            Console.WriteLine("In doStackdemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ashman");
            stack.Push("Bhagvan");
            stack.Push("crupa");
            stack.Push("Dairy");

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            string pop = stack.Pop();
        }

        public  void Queuedemo()
        {
            Console.WriteLine("In doQueueDemo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Vaish");
            queue.Enqueue("Veda");
            queue.Enqueue("Varma");
            queue.Enqueue("Vicky");

            Console.WriteLine("Peek element is : " + queue.Peek());
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Pooped element is:" + dequeue);

            Queue<string> .Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public  void Setdemo()
        {
            Console.WriteLine("In deSetdemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Raj");
            set.Add("Reema");
            set.Add("Reshma");
            set.Add("Rohan");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
           while( enumerator.MoveNext())
           {
                Console.WriteLine(enumerator.Current); ;
           }
        }

        public  void Dictionarydemo()
        {
            Console.WriteLine("In doDictionarydemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(20, "Apple");
            dictionary.Add(40, "WaterMelon");
            dictionary.Add(60, "Papaya");
            dictionary.Add(80, "Kiwi");
            Console.WriteLine("Displaying Value Of Key: " + dictionary[80]);
            Console.WriteLine(dictionary);
            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }
        }
    }
}
