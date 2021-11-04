using System;
using System.IO;
using System.Text;

namespace Document
{
    class Program
    {

        static string getFile (string str) {
            while (true) {
                Console.WriteLine("Enter name for {0} text file:  ", str);
                string file = Console.ReadLine();
                string fileName = file + ".txt";

                if (File.Exists(fileName))    
                {    
                    return file;
                }   
                Console.WriteLine("File does not exist, pleas re-enter\n");  
            }
        }

        static byte[] readFile (String fileName) {
            using (StreamReader sr = File.OpenText(fileName)) {    
                string text = sr.ReadLine();    
                byte[] addText = new UTF8Encoding(true).GetBytes(text);
                return addText;     
            }    
        }


        static void Main(string[] args)
        {  
            while(true) {
                try {

                    Console.WriteLine("Document Merger\n");

                    String fileName1 = getFile("first");
                    String fileName2 = getFile("second");

                    String mergeFileName = fileName1 + fileName2 + ".txt";  
 
                    byte[] fileText1 = readFile(fileName1 + ".txt");  
                    byte[] fileText2 = readFile(fileName2 + ".txt"); 

                    using (FileStream fs = File.Create(mergeFileName)) { 
                        fs.Write(fileText1, 0, fileText1.Length);   
                        fs.Write(fileText2, 0, fileText2.Length);    
                    }    

                    int length = fileText1.Length + fileText2.Length;

                Console.WriteLine(mergeFileName + " was successfully saved. The document contains " + length +  " characters.\n");

                } catch (Exception Ex) {    
                    Console.WriteLine(Ex.ToString());    
                    System.Environment.Exit(0);
                }

                Console.WriteLine("\nDo you have more files to merge? [Y/N]:");
                string input = Console.ReadLine();
                if(input == "N" || input == "n") {
                    break;
                }
            }
        }
    }
}
