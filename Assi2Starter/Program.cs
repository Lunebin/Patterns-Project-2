using System;
using System.Collections.Generic;

namespace Assi2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PostProxy> Posts = new List<PostProxy>();

            PostProxy p1 = new PostProxy(Posts.Count);
            Posts.Add(p1);

            PostProxy p2 = new PostProxy(Posts.Count);
            Posts.Add(p2);

            PostProxy p3 = new PostProxy(Posts.Count);
            Posts.Add(p3);

            Console.WriteLine("Welcome to the Social Network!\nEnter a command to get started, or 'help' to see a list of commands:");
            string command = "";

            while(command != "quit") {
                string[] commandArgs = command.Split(":");
                int postNum = -1;
                if(commandArgs.Length > 1) {
                    try {
                        postNum = int.Parse(commandArgs[1]);
                    } catch(FormatException) {
                        Console.WriteLine("Error: Invalid post number specified!");
                    }

                    if(postNum < 0 || postNum > Posts.Count) {
                        Console.WriteLine("Error: Invalid post number specified!");
                        break;
                    }
                }

                switch(commandArgs[0]) {
                    case "help":
                        Console.WriteLine("help\t\t\tDisplay this menu");
                        Console.WriteLine("new\t\t\tCreate a new post.");
                        Console.WriteLine("list\t\t\tList all posts.");
                        Console.WriteLine("download:[id]\t\tDownload a post.");
                        Console.WriteLine("settitle:[id]:[title]\tSet a post's title.");
                        Console.WriteLine("setbody:[id]:[body]\tSet a post's body.");
                        Console.WriteLine("view:[id]\t\tView a post.");
                        Console.WriteLine("quit\t\t\tQuit the application");
                        break;
                    case "new":
                        PostProxy newP = new PostProxy(Posts.Count);
                        Posts.Add(newP);
                        Console.WriteLine("New post added!");
                        break;
                    case "list":
                        int index = 0;
                        foreach(PostProxy p in Posts)
                        {             
                            Console.WriteLine(index + "\t" + p.printTitle());
                            index++;
                        }
                        break;
                    case "download":
                        try
                        {
                            Posts[Int16.Parse(commandArgs[1])].downloadPost();
                            Console.WriteLine("Post downloaded and is now a Fancy Post!");
                        }
                        catch
                        {
                            Console.WriteLine("Error: did not enter a valid number");
                        }
                        break;
                    case "settitle":
                        try
                        {
                            Posts[Int16.Parse(commandArgs[1])].setTitle(commandArgs[2]);
                            Console.WriteLine("Title changed!");
                        }
                        catch
                        {
                            Console.WriteLine("Error: Title not changed!");
                        }
                        break;
                    case "setbody":
                        try
                        {
                            Posts[Int16.Parse(commandArgs[1])].setBody(commandArgs[2]);
                            Console.WriteLine("Body changed!");
                        }
                        catch
                        {
                            Console.WriteLine("Error: Body not changed!");
                        }
                        break;
                    case "view":
                        Console.WriteLine(Posts[Int16.Parse(commandArgs[1])].printPost());
                        break;
                    default:
                        if(command != "") {
                            Console.WriteLine("Invalid command.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
