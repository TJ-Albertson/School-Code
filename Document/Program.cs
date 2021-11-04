using System;
using System.IO;
using System.Text;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {  

            Console.WriteLine("Document\n");

            Console.WriteLine("Enter name for Document:  ");
            string file1 = Console.ReadLine();
            string fileName = file1 + ".txt";

            Console.WriteLine("Add text to Document  :  ");
            string text = Console.ReadLine();
    
            try {    
 
                using (FileStream fs = File.Create(fileName)) {    

                    byte[] addText = new UTF8Encoding(true).GetBytes(text);    
                    fs.Write(addText, 0, addText.Length);    

                }    

            } catch (Exception Ex) {    
                Console.WriteLine(Ex.ToString());    
                System.Environment.Exit(0);
            }

            Console.WriteLine(fileName + " was successfully saved. The document contains " + text.Length +  " characters.");

        }
    }
}
