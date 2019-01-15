using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static string fileName = "C:/test.txt";

        public static void Main(string[] args)
        {
            // Call if arguments are passed
            if (args.Length > 0)
            {
                // Write the OutPut
                WriteOutPut(args);
            }
            //Check for/create test.txt
            createTestFile(fileName);
        }

        public static void createTestFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file 
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file
                    Byte[] title = new UTF8Encoding(true).GetBytes("Test Txt File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("James Warner");
                    fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        public static string method(string arg1, string arg2)
        {
            FileDetails fileDetails = new FileDetails();
            string returnValue = "";

            //Check arg1
            if (arg1 == "-v" || arg1 == "--v" || arg1 == "/ v" || arg1 == "/v")
            {
                returnValue = fileDetails.Version(fileName);
            }
            else if (arg1 == "-s" || arg1 == "--s" || arg1 == "/ s" || arg1 == "/s")
            {
                returnValue = fileDetails.Size(fileName).ToString();
            }
            else
            {
                //Do nothing
            }

            Console.WriteLine(returnValue);
            return returnValue;

        }

        /// <summary>
        /// Writes the output based on the parameters passed.
        /// </summary>
        /// <param name="args">Contains two arguments</param>
        /// <returns>Returns the result value</returns>
        /// 
        public static string WriteOutPut(string[] args)
        {
            string returnValue = "";
            //Checks arguments are passed
            if (args.Length > 0)
            {
                string[] version = { "-v", "--v", "/v", "--version" };
                string[] fileSize = { "-s", "--s", "/s", "--size" };
                
                FileDetails fileDetails = new FileDetails();

                //Checks if version is looking for.
                if (version.Any(x => x == args[0]))
                {
                    if (args[1] != null)
                    {
                        returnValue = fileDetails.Version(args[1]);
                    }
                    else
                        returnValue = fileDetails.Version(fileName);
                }
                // checks if size is looking for.
                else if (fileSize.Any(x => x == args[0]))
                {
                    if (args[1] != null)
                    {
                        returnValue = fileDetails.Size(args[1]).ToString();
                    }
                    else
                        returnValue = fileDetails.Size(fileName).ToString();
                }
                Console.WriteLine(returnValue);
                Console.ReadKey();
            }
            return returnValue;
        }
    }





}
