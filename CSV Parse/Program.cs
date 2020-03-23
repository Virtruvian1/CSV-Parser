using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Syncfusion.XlsIO; 
using System.Diagnostics;

namespace Program
{
    public class ParserEngine
    {
        private string _filePath;
        private string _currentColumn;
        private string _currentTable;

        public ParserEngine() // Default Constructor
        {
            _filePath = "Empty Path";
            _currentColumn = "No Data";
            _currentTable = "No Data";
        }

        public string FilePath // Checks FilePath
        { 
            get { return _filePath;  } 
            set 
            {
                bool filePathExist = false; 
                bool filePathCorrect = false;
                int processCounter = 1;

                switch (processCounter)
                {
                    case 1:
                        // Test 1
                        filePathExist = File.Exists(FilePath);
                        processCounter++;
                        break;
                    case 2:
                        // Test 2
                        processCounter++;
                        break;
                    case 3:
                        // Test 3
                        if (filePathExist == true && filePathCorrect == true)
                        {
                            _filePath = value;
                        }
                        else { Console.WriteLine("ERROR! The file path provided does not exist or is not a .CSV File, please try again"); }
                        break;
                    default:
                        break;
                }
            } 
        } 

        public void TakeFilePath (string tempFilePath)
        {
            Console.Write("Please input file path: ");
            FilePath = Console.ReadLine();
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {

            
        }
    }
}
