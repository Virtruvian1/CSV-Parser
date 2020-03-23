using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Syncfusion.XlsIO;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Program
{
    public class ParserEngine
    {
        public bool ValidFilePath(string FilePath) // Checks FilePath
        {
            // Test 1
            return File.Exists(FilePath);
        }
        public bool ValidFileExtention(string FilePath) // Checks FilePath
        {
            // Test 2
            if (FilePath.Contains(".csv"))
            {
                return true;
            }
            return false;
        }

        public string TakeFilePath()
        {
            Console.Write("Please input file path: ");
            return Console.ReadLine().Replace('\\', '/');
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var Parser = new ParserEngine();
            bool bothTest = false;
            string FilePath = "";
            char[] delimiterChars = { ',' };
            do
            {
                FilePath = Parser.TakeFilePath();
                bool ValidFilePath = Parser.ValidFilePath(FilePath);
                bool ValidFileExtention = Parser.ValidFileExtention(FilePath);
                if (ValidFilePath)
                {
                    if (ValidFileExtention)
                    { 
                    bothTest = true;
                    }
                }
            }
            while (!bothTest);
            // if(!test1 && !test2)
            //      test 1     test2  ->      if(statement)  ->  therefore runs or not?
            //       true        true       false                doesn't run
            //      true        false       false                 doesn't run
            //      false       true        false                  doesn't run
            //      false       false       true                    runs


            // Open file
            using (TextFieldParser parser = new TextFieldParser($@"{FilePath}"))
            {
                parser.TextFieldType = FieldType.Delimited;
                
                // Parse through each string using the delimiter
                parser.SetDelimiters(",");
                
                while (!parser.EndOfData)
                {
                    // Read line into a string
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        //TODO: Process field
                    }
                }
            }

            
            // Parse through each string using the delimiter
            // Set to Database
        }
    }
