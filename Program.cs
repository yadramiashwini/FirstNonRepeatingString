using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace FirstNonRepeatingString
{
    public class Program
    {

        public static int FirstNonRepeat(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n; ++i)
            {
                bool found = true;
                // Step 2: Check if the character repeats in the
                // rest of the string
                for (int j = 0; j < n; ++j)
                {
                    if (i != j && s[i] == s[j])
                    {
                        found = false;
                        break;
                    }
                }

                // Step 3: If character does not repeat, return
                // its index
                if (found)
                {
                  return i;
       
                }
            }
           
            return -1;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("enter string:");
            string s = Console.ReadLine();
             int val = FirstNonRepeat(s);
            if (val == -1)
            {
                Console.WriteLine("character is not found:");
            }
            else
            {
                Console.WriteLine("character is found:"+val);
            }

        }
    }
}
