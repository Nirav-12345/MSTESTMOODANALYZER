using System;

namespace CollectionDemo;

class Program
{
    public static void Main(string[] args)
    {
        doListDemo();
        doStackDemo();
        doListDemo();
        doQueueDemo();
        dictionryDemo();
        doSetDemo();






    }

    private static void doListDemo()
    {
        Console.WriteLine("\n InlistDemo");

        List<string> list = new List<string>();
        list.Add("Nir");
        list.Add("Abi");
        list.Add("Jou");
        list.Add("Gunjan");
        list.Add("Donald");
        list.Add("Pwan");

        foreach (var l in list)
        {
            Console.WriteLine(l);
        }




    }



    private static void doStackDemo()
    {
        Console.WriteLine("\n In StackDemo");

        Stack<string> stack = new Stack<string>();

        stack.Push("ggg");
        stack.Push("ddd");
        stack.Push("mmm");
        stack.Push("kkk");
        stack.Push("AAA");
        foreach (var s in stack)
        {
            Console.WriteLine(s);
        }
    }

    private static void doQueueDemo()
    {

        Console.WriteLine("\n In queue Demo");
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("fff");
        queue.Enqueue("uuu");
        queue.Enqueue("ooo");
        queue.Enqueue("kkk");
        foreach (var q in queue)
        {
            Console.WriteLine(q);
            Console.WriteLine(queue.Peek());

            //string dequeu = queue.Dequeue();
            //.WriteLine("Iterationd Equeu to Dequeue");

            //foreach (var ele in dequeu)
            //{
                //Console.WriteLine(ele);
            //}
        }
    }
    private static void dictionryDemo()
    {
        Console.WriteLine("\n In Dictionary Demo");
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(100, "fff");
        dict.Add(200, "fetch");
        dict.Add(333, "Car");
        Console.WriteLine("Accessing 100th elemnt" + dict[100]);

        foreach (var d in dict)
        {
            Console.WriteLine("Key" + d.Key + "value" + d.Value);
        }
    }


    private static void doSetDemo()
    {

        Console.WriteLine("\n Accessing Set Demo");
        var set = new HashSet<string>();
        set.Add("aaa");
        set.Add("kkk");
        set.Add("ppp");
        foreach(string i in set)
        {
            Console.WriteLine(i);
        }
    }


}