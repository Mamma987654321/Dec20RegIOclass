using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;



namespace Dec20RegIOclass
{
    internal class IOExample
    {
        public static void WriteAndReadFile()
        {// create a file with streamwrite
            StreamWriter writer = new StreamWriter(@"C:\Mphasis\File1.txt");
            writer.WriteLine("this is a first Line");//write permissions or write mode
            writer.WriteLine("this is a second Line");//this is second line

            writer.Close();//must close
            StreamReader reader = new StreamReader(@"C:\Mphasis\File1.txt");
            string line = reader.ReadToEnd();
            Console.WriteLine(line);
            reader.Close();



        }
        public static void WriteAndReadWithFileStream() {
            FileStream wristream = new FileStream(@"C:\Mphasis\File2.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(wristream);
            writer.WriteLine("File 2 is created");
           
            writer.Close();
            StreamReader reader = new StreamReader(@"C:\Mphasis\File2.txt");
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
        public static void FileWithFileFuns() {
            string pathFile = @"C:\\Mphasis\File5.txt";
            //checking
            if (File.Exists(pathFile))
            {//true
                StreamReader reader = File.OpenText(pathFile);
                string s1 = reader.ReadToEnd();
                Console.WriteLine("file exists so we are reading " + s1);
                reader.Close();
            }
            else { 
                StreamWriter writer = File.CreateText(pathFile);
                writer.Write("now the file is created File5");
                writer.Close();

                //let when a file is created
                DateTime dt1 = File.GetCreationTime(pathFile);
                Console.WriteLine(dt1.ToString());
                //to append in existing file
                StreamWriter sw1 = File.AppendText(pathFile);
                sw1.Close();
             //   File.Move(pathFile, "C:\\Mphasis");// oldfile,new path cut paste
              //  File.Copy(pathFile, "C:\\Mphasis\\File6.txt");// new file name must 

            }
            

            }
        public static void WorkingWithDirectoryFuns()
        {// create file
           

        }
        static void Main(string[] args)
        {
            // WriteAndReadFile();
           // WriteAndReadWithFileStream();
         //  FileWithFileFuns();
            Console.ReadLine();
        }
    }
}
