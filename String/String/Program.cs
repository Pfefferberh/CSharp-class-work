using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// . Вводится строка слов. Вывести слова в обратном порядке.   
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //  string s5 = "Printing backwards";
            //  for (int i = 0; i < s5.Length; i++)
            //  {
            //      Console.Write(s5[s5.Length - i - 1]);
            //  }
            //  Console.WriteLine("\n");
            #endregion

            #region
            //string str = "BOO i am scaring you!";
            //Console.WriteLine(str);
            //str =str.Replace("am","was");
            //Console.WriteLine(str);
            #endregion

            #region
            //string str = "BOO i am scaring you!";
            //Console.WriteLine(str);
            //string man = Console.ReadLine();
            //str.IndexOf(man);
            //str = str.Replace(man, Console.ReadLine());
            //Console.WriteLine(str);
            #endregion

            #region
            //var Matrix = new char[4][];
            //Matrix[0] = new char[] { 'w', 'o', 'r', 'l' };
            //Matrix[1] = new char[] { 's', 'e', 'a', 'b' };
            //Matrix[2] = new char[] { 'l', 'o', 'a', 'd' };
            //Matrix[3] = new char[] { 'b', 'o', 's', 's' };
            //string strl=System.String.Empty;
            //for (int i = 0; i < Matrix.Length; i++)
            //{
            //    for (int j = 0; j < Matrix[i].Length; j++)
            //    {
            //       Console.Write(Matrix[i][j]+" ");
            //         strl = Convert.ToString(strl+Matrix[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(strl);
            //bool cW = strl.Contains(Console.ReadLine());
            //Console.WriteLine(cW);
            #endregion

            #region
            string text = "    I   did    it    ";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string strl = System.String.Empty;
            for (int i = 0; i < words.Length; i++)
            { 
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i][j]);
                    strl = Convert.ToString(strl + words[i][j]); 
                    
                }
                Console.WriteLine();
                strl = Convert.ToString(strl +"*");
      
            }
            strl=strl.TrimEnd('*');
            Console.WriteLine(strl);
            #endregion
        }
    }
}
