﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVParsing
{
    class Program
    {
            static List<string> getCSV(string s)
            {
                StringBuilder result = new StringBuilder();
                List<string> stringResult = new List<string>();
                for (int i = 0; i < s.Length; i++)
                {
                    if(s[i] == '\"')
                    {
                        i++;
                        while (s[i] != '\"')
                        {
                            result.Append(s[i]);
                            i++;
                        }
                    }
                    else if(s[i] == ',')
                    {
                        stringResult.Add(result.ToString().Trim());
                        result.Clear();
                    }
                    else if(s[i] != ',')
                    {
                        result.Append(s[i]);
                    }
                }
                stringResult.Add(result.ToString().Trim());
                return stringResult;
            }
        public static List<string> getCSVText(List<string> myList, string fileLocation)
        {
            using (StreamReader sr = File.OpenText(fileLocation))
            {
                string input;
                while ((input = sr.ReadLine()) != null) myList.Add(input);
            };
            return myList;
        }
        static void Main(string[] args)
        {
            /*************************
            * read CSV with embedded commas
            * parse CSV into separate fields and
            * ignore commas within quoted string
            * ***********************/
            List<string> myList = new List<string>();
            myList = (getCSVText(myList, "../../../pres-test.csv"));
            Console.WriteLine("Reading CSV with embedded commas");
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
            "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
            "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input3);

            foreach (string s in myList)
            {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                Console.WriteLine(s1);
            }
        }
    }
}
