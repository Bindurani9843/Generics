using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class dictionary
    {
        //dictionary
        public static void Main()
        {
            Dictionary<string, string> My_dict = new Dictionary<string, string>();
            My_dict.Add("a1", "Bindu");
            My_dict.Add("a2", "Jeevana");
            My_dict.Add("a3", "Sanju");
            Console.WriteLine("Dictionary");
            foreach (KeyValuePair<string, string> element in My_dict)
            {
                Console.WriteLine("key: {0} and value:{1} ", element.Key, element.Value);
            }
            Console.WriteLine("------------------------------------------------------------");



            //hashtag

            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add("A1", "Sanju");
            my_hashtable.Add("A2", "Karthik");
            my_hashtable.Add("A3", "Chandu");
            Console.WriteLine("Hashtable");
            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("key: {0} and value:{1} ", element.Key, element.Value);

            }
            Console.ReadKey();
        }

    }

}