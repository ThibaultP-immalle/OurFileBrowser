﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OurFileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowDefault();
            } else
            {
                switch (args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFilesInCurrentDirectory();
                        break;
                    case "-d":
                        ShowAlleSubDirsInCurrentDir();
                        break;
                    case "-h":
                        ShowHelp();
                        break;
                    case "-k":
                        ChangeColor();
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }

        }
        static void ShowDefault()
        {
            Console.WriteLine("Current Directory:");
            ShowCurrentDirectory();
            Console.WriteLine("Alle Subdirs:");
            ShowAlleSubDirsInCurrentDir();
            Console.WriteLine("Alle files:");
            ShowAllFilesInCurrentDirectory();
        }
        static void ShowCurrentDirectory()
        {
            //Console.WriteLine("Current Directory:");
            Console.WriteLine("Current Directory:" + Directory.GetCurrentDirectory());
            
        }
        static void ShowAllFilesInCurrentDirectory()
        {
            //string dir = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("Alle files in current directory");
            //Console.WriteLine("Alle files in de directory:" + System.IO.Directory.GetFiles(dir));
            string[] dirs = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (string dir in dirs)
            {
                Int64 fileSizeInBytes = new FileInfo(dir).Length;
                Console.WriteLine(Path.GetFileName(dir) + "         " + fileSizeInBytes + " bytes");
            }
            Console.WriteLine();
        }
        static void ShowAlleSubDirsInCurrentDir()
        {
            //string[] subdirs = Directory.GetDirectories(Environment.CurrentDirectory);
            //foreach (string dir in subdirs)
            //{
            //    Console.WriteLine(Path.GetDirectoryName(dir));
            //}
            //Console.WriteLine();
            //var directories = Directory.GetDirectories(Environment.CurrentDirectory);
            //Console.WriteLine(directories);
            string[] fileArray = Directory.GetDirectories(Environment.CurrentDirectory);
            for (int i = 0; i < fileArray.Length; i++)
            {

               Console.WriteLine(Path.GetFileName(fileArray[i]));
            }
        }
        static void ShowHelp()
        {
            Console.WriteLine("Help - ofb = OurFileBrowser.exe:");
            Console.WriteLine("- ofb -c: Toont de huidige directory");
            Console.WriteLine("- ofb -d: Toont alle subdirectories in  de huidige directory");
            Console.WriteLine("- ofb -f: Toont alle files in de huidige directory");
            Console.WriteLine("- ofb (zonder argumenten): Toont de huidige directory, alle files en alle subdirectories");
            Console.WriteLine("- ofb -h: Toont help");
            Console.WriteLine("- ofb -k: verander de kleur van de console");
        }
        static void ChangeColor()
        {
            Console.WriteLine("Welke kleur wil je graag?");
            Console.WriteLine("Kies tussen: rood, groen, blauw, geel.");
            string kleur = Console.ReadLine();          
            switch (kleur)
            {
                case "rood":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "groen":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "blauw":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "geel":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

            }

        }

        


    }
}