using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class strings_example
    {
        public void Run()
        {
            //Console.WriteLine("++++++++++++++++++++++++++++");
            //Console.WriteLine("SHAHBAZ HUSSAIN");
            //Console.WriteLine("HUSSAIN 0000");
            //char[] letters = { 'w', 'e', 'l' };
            //Console.WriteLine(letters);
            //string message1 = new string(letters);        TO CONVERT CHAR ARRAY TO STRING
            //Console.WriteLine("message1 :" + message1);
            //char[] shahbaz = message1.ToCharArray();      TO CONVERT STRING TO THE ARRAY
            //Console.WriteLine(shahbaz);

            //string fname = "shahbaz";
            //string lname = "hussain";
            //string fullname = fname +"-"+ lname;
            //Console.WriteLine("THE FULL NAME IS "+fullname);
            //Console.WriteLine("the length of the fullname is "+fullname.Length);

            //string bankname = "shahbaz hussain";
            //Console.WriteLine("the upper case is "+bankname.ToUpper());

            //string bank = "SHAHBAZ HUSSAIN";
            //Console.WriteLine("the lower case :"+ bank.ToLower());

            //string name1 = " ";
            //string name2 = "";
            //string name3 = null;
            //if(string.IsNullOrWhiteSpace(name3))
            //{
            //    Console.WriteLine("there a string exists");
            //}


            //string fname = bankname.ToUpper();
            //Console.WriteLine(fname);

            //if(string.Equals(bank,fname))
            //{
            //    Console.WriteLine("the string is equall");
            //}


            //string customername = "Shahbaz hussain";
            //    if(customername.StartsWith("s")||customername.StartsWith("S"))
            //{
            //    Console.WriteLine("hello yeah this starts with s");
            //}

            //if(customername.EndsWith("n"))
            //{
            //    Console.WriteLine("YEAH THIS ENDS WITH N");
            //}


            //EXAMPLE NO 03:
            // TO COMBINE THE ARRAY OF STRINGS WE USE CONCATINATE 
            //string.join("seperator",stringname) joins with seperatror
            //string.concat(stringname)


            //    String[] shahbaz = { "hello", "how", "are","you" };
            //    string result = string.Join("-",shahbaz);
            //    Console.WriteLine("the concatinated string is "+"\n"+result);

            //    //split the string array:
            //    string exam = "shahbaz:hussain:123;234:abc:4444";
            //    string[] splitted = exam.Split(":".ToCharArray());
            //    Console.WriteLine(splitted);
            //    foreach(string s in splitted)
            //    {
            //        Console.WriteLine(s);
            //    }

            ////contains:
            //if(result.Contains("how"))
            //    {
            //        Console.WriteLine("the strings contains how");
            //    }

            //string[] str = { "how", "are", "you", "what" };
            //string str2 = string.Concat(str);
            //string str3 = string.Join(" ", str);
            //Console.WriteLine(str2 + " " + str3);
            //string str5 = "shahbaz:hussain;123:456:";
            //string[] str4 = str5.Split(";".ToCharArray());
            //foreach(string splitted in str4)
            //{
            //   string[] variable=splitted.Split(":".ToCharArray());
            //}
            /////////contains
            //string str = "shahbaz husssain is a ";
            //if(str.Contains("is"))
            //{
            //    Console.WriteLine("yes it has is");
            //}
            /////////////// index of
            //int num= str.IndexOf("is");
            //Console.WriteLine("index is "+num);

            ////////////////////// trim
            string str = "ubl where you come first";
            //str += "            \n\n         ";
            //Console.WriteLine(str+"end");
            //string trimresult =str.Trim(" \n\n".ToCharArray());
            //Console.WriteLine(trimresult + " end");

            ///////////SUBSTRING
            //string substring = str.Substring(0,4);
            //Console.WriteLine(substring);

            string replace = str.Replace("ubl", "hbl");
            Console.WriteLine(replace);
          

            Console.ReadKey();

        }
    }
}
