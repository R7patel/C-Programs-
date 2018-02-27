using System;
using System.Collections;
namespace ConsoleApplication4
    {
        class Program
        {
            static void Main(string[] args)
            {
                Stack s = new Stack(5);
                s.Push((object)23);
                s.Push((object)27);
                s.Push((object)25);
                s.Push((object)24);
                s.Push((object)21);
                Console.WriteLine("Pushed: 23,27,25,24,21");
                Console.WriteLine("pop:" + s.Pop().ToString());
                Console.WriteLine("pop:" + s.Pop().ToString());
                Console.WriteLine("pop:" + s.Pop().ToString());
                Console.WriteLine("pop:" + s.Pop().ToString());
                Console.WriteLine("pop:" + s.Pop().ToString());
                //Console.WriteLine("pop:" + s.Pop().ToString()); 
                Queue q = new Queue(5);
                q.Enqueue((object)23);
                q.Enqueue((object)24);
                q.Enqueue((object)25);
                q.Enqueue((object)26);
                q.Enqueue((object)27);
                Console.WriteLine("Enqueue: 5,23,24,25,26,27");
                Console.WriteLine("DeQ:" + q.Dequeue().ToString());
                Console.WriteLine("DeQ:" + q.Dequeue().ToString());
                Console.WriteLine("DeQ:" + q.Dequeue().ToString());
                Console.WriteLine("DeQ:" + q.Dequeue().ToString());
                Console.WriteLine("DeQ:" + q.Dequeue().ToString());
                //  Console.WriteLine("DeQ:" + q.Dequeue().ToString()); 
                ArrayList al = new ArrayList(1);
                al.Add((object)12);
                al.Add((object)13);
                al.Add((object)14);
                Console.WriteLine("Arr: {0}--{1}--{2}", al[0], al[1], al[2]);
                Console.ReadKey();

            // int[,] a = new int[2, 2] { { 1, 2 }, { 3, 4 } };

      /*      int[][] a = new int[2][];
            for (int i=0;i<2;i++)
            {
                a[i] = new int[2] { 1, 2 };
            }
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(a[i][j]);
            Console.ReadKey();*/
        }
        }

    }
