using System.Collections;

namespace DemoADV02
{
    internal class Program
    {
        public static void PrintArraylist(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (int item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }

        public static int SumArrayList(ArrayList list)
        {
            int sum = 0;
            if(list is not null)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    sum += (int)list[i]; 
                }
            }
            return sum;
        }

        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            foreach (T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
            }
            return sum;
        }

        public static void printLinkedList(LinkedList<int> list)
        {
            Console.Write("null");
            Console.WriteLine();
            foreach (int item in list)
            {
                Console.WriteLine($"<-- {item} -->");
            }
            Console.WriteLine("null");
        }

        static void Main(string[] args)
        {
            #region What is Collections ?
            // Collections : Built-in DS in C#
            // Array : Containers

            // Collections in C#
            // Lists
            // Hashtables

            // Generic - Non-Generic
            // Lists
            // Non-Generic : Array List - Satck - Queue
            // Generic : List - Linked List - Stack - Queue

            // Hashtables :
            // Non-Generic : Hashtable
            // Generic : Dictionary - SortedDictionary 
            #endregion

            #region Non-Generic Lists : ArrayList
            // Lists 
            // Non-Generic Lists : ArrayList

            // ArrayList Like Array
            // Array Based
            // Index

            // Array Indexed Collection : Fixed Size
            // ArrayList Indexed Collection : Dynamic Size

            // Index : 0 1 2 3 4 5
            // Item  : 4 5 6 7 8 1
            // Size  : 6

            // Arr[1] ---> 5

            //int[] numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers[1]);

            //numbers[1] = 12;
            //Console.WriteLine(numbers[1]);

            //ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.Add(6);
            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.AddRange(new[] { 10, 11, 12 })

            //PrintArraylist(list);

            // int Index = list.BinarySearch(2);
            // int Index = list.BinarySearch(2, );

            // Console.WriteLine(Index);

            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 30, Salary = 13000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 35, Salary = 15000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 32, Salary = 14000 };

            //ArrayList list = new ArrayList();
            //list.AddRange(new Employee[] { E01, E02, E03, E04 });

            //int index = list.BinarySearch(E01);
            //Console.WriteLine($"Index : {index}");

            //Console.WriteLine("===============================");

            //foreach (Employee item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //list.Clear();

            //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");

            //bool flag = list.Contains(2);
            //Console.WriteLine(flag);

            //int[] Arr = new int[4];

            //list.CopyTo(Arr);

            //foreach (int item in Arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //ArrayList arrayList = list.GetRange(0, 2);

            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //int index = list.IndexOf(5, 4, 5);

            //list.Remove(5);
            //list.RemoveAt(0);
            //list.RemoveRange(0, 3);
            //list.SetRange(0, new int[] { 10, 20, 30 });
            //PrintArraylist(list); 
            #endregion

            #region Problem with Non-Generic Lists [ArrayList]
            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            ////list.Add("Hello World");

            //int sum = SumArrayList(list);
            //Console.WriteLine(sum); 
            #endregion

            #region Generic Lists : List
            // Generic Lists : List
            // List : Version Generic of ArrayList
            // List Like ArrayList Like Array : Generic - Dynamic Size

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //PrintList(list);

            //int Sum = SumList(list);
            //Console.WriteLine(Sum);

            //list.AddRange(new List<int>() { 10, 20, 30, 40, 50 });
            //PrintList(list);

            //int i = list.BinarySearch(5);
            //Console.WriteLine(i); 
            #endregion

            #region Generic List : LinkedList
            // Generic List : Linked List

            //LinkedList<int> linkedList = new LinkedList<int>();

            //linkedList.AddFirst(1);
            //linkedList.AddFirst(2); 
            #endregion






        }
    }
}
