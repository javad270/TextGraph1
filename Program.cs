/*
using System;
using System.IO;
// in this example we are going to import some data and loop through them, creat a graph and assign 
//some of text words as the graph nodes and if there's a connection between them, add to their respective edge.
namespace TextGraph
{
    class Graph
    {
        public string[] text;
        public string[] Text
        {
            get { return text; }
            set { text = value; }
        }


        int[,] g = new int[10, 10];

        public Graph()
        {

            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 2; j++)
                {
                    g[i, j] = 0;
                }
            }
        }

       public  void addEdge()
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                for (int j = i + 1; j <= i + 1; j++)
                {
                    if (text[i] == "this" && text[j] == "project")
                    {
                        g[0, 1] = g[0, 1] + 1;
                    }

                    else if (text[i] == "project" && text[j] == "was")
                    {
                        g[1, 2] = g[1, 2] + 1;
                    }
                }
            }

        }

        public  void displayMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(g[i, j] + " ");
                }
            }
            Console.WriteLine("\n \"g[0, 1]\" is the edge between \"this\" and \"project\" is :{0}", g[0, 1]);
            Console.WriteLine(" \"g[1, 2]\"is the edge between \"project\" and \"was\" is :{0}", g[1, 2]);

        }

    }
    class program
    {
        public static void Main(string[] args)
        {
            string Address = @"C:\Users\Javad\Desktop\C#\demo\General.txt";
            Graph obj = new Graph();
            string importedText = File.ReadAllText(Address);
            char[] myChars = { ' ', '.', ',' };
            obj.Text = importedText.Split(myChars);

            obj.addEdge();
            obj.displayMatrix();

            string AddedText = importedText + "this sentence is created just like that.";
            File.WriteAllText(Address, AddedText);

            Console.ReadKey();
        }
    }
}*/



using System;
using System.IO;
// in this example we are going to import some data and loop through them, creat a graph and assign 
//some of text words as the graph nodes and if there's a connection between them, add to their respective edge.
namespace TextGraph
{
    class Graph
    {
        public static string[] text;
        public static int[,] g = new int[10, 10];

        public Graph()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = i + 1; j < 2; j++)
                {
                    g[i, j] = 0;
                }
            }
        }

        public static void addEdge()
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                for (int j = i + 1; j <= i + 1; j++)
                {
                    if (text[i] == "this" && text[j] == "project")
                    {
                        g[0, 1] = g[0, 1] + 1;
                    }

                    else if (text[i] == "project" && text[j] == "was")
                    {
                        g[1, 2] = g[1, 2] + 1;
                    }
                }
            }

        }

        public static void displayMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(g[i, j] + " ");
                }
            }
            Console.WriteLine("\n \"g[0, 1]\" is the edge between \"this\" and \"project\" is :{0}", g[0, 1]);
            Console.WriteLine(" \"g[1, 2]\"is the edge between \"project\" and \"was\" is :{0}", g[1, 2]);

        }

    }
    class program
    {
        public static void Main(string[] args)
        {
            string Address = @"C:\Users\Javad\Desktop\C#\demo\General.txt";

            string importedText = File.ReadAllText(Address);
            char[] myChars = { ' ', '.', ',' };
            Graph.text = importedText.Split(myChars);

            Graph.addEdge();
            Graph.displayMatrix();

            string AddedText = importedText + "this sentence is created just like that.";
            File.WriteAllText(Address, AddedText);

            Console.ReadKey();
        }
    }
}

