using System;
using System.Collections.Generic;
using System.Text;
//File I/O
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;

namespace DerekBanasCSharpTut
{
    class Tut20
    {
        public static void Sample(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            Console.WriteLine("Current Directory: {0}", currDir.Parent);
            DirectoryInfo ratulsDir = new DirectoryInfo(@"C:\Users\Ratul");
            Console.WriteLine(ratulsDir.CreationTime);
            Console.WriteLine(ratulsDir.Attributes);
            Console.WriteLine(ratulsDir.Name);
            Console.WriteLine(ratulsDir.Parent);
            Console.WriteLine(ratulsDir.FullName);
            //create a directory
            string newFolderPath = @"C:\Users\Ratul\source\repos\DerekBanasCSharpTut\DerekBanasCSharpTut\dummies";
            if (Directory.Exists(newFolderPath))
            {
                Console.WriteLine("Folder exists");
            }
            else
            {
                Directory.CreateDirectory(newFolderPath);
            }
            DirectoryInfo newDirectory = new DirectoryInfo(newFolderPath);
            string[] customers = { "Bob Smith", "Ronald", "Jacub", "Sally", "Morris" };
            //create a file
            File.WriteAllLines( Path.Combine(newDirectory.FullName, "customers.txt") ,
                customers);
            //Read from files
            foreach(string cust in File.ReadLines(Path.Combine(newDirectory.FullName, "customers.txt")))
            {
                Console.WriteLine("Customer : {0}", cust);
            }
            //delete a file
            File.Delete(Path.Combine(newDirectory.FullName, "customers.txt"));
            Console.WriteLine("Deleted File!!");
            Directory.Delete(newFolderPath);
            Console.WriteLine("Deleted Folder!!");
            //Getting a bunch of files that satisfy certain conditions
            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\Ratul\Pictures");
            //It will return the files within the specified directory
            //No nested folder will be checked
            FileInfo[] files = myDataDir.GetFiles("*.jpg");
            Console.WriteLine("Total number of files: {0}", files.Length);
            foreach(FileInfo file in files)
            {
                Console.WriteLine("{0}", file.Name);
            }
            //nested folder will be checked
            files = myDataDir.GetFiles("*.jpg", SearchOption.AllDirectories);
            Console.WriteLine("Total number of files: {0}", files.Length);
        }
    }
}
