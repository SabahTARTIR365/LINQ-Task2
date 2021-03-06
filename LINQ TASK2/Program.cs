//IT'S WPRKING LIKE THIS 

using System.Collections.Generic;
using System.Linq;

namespace LINQTask1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            IEnumerable<string> words = new[] { "hello","hi","bee"};
           
            Console.WriteLine(FullExercise2.GetTheLastWord(words));
        }
    }
    class FullExercise2
    {
        // Given a sequence of words, get rid of any that don't have the character 'e' in them,
        // then sort the remaining words alphabetically, then return the following phrase using
        // only the final word in the resulting sequence:
        //    -> "The last word is <word>"
        // If there are no words with the character 'e' in them, then return null.
        //
        // TRY to do it all using only LINQ statements. No loops or if statements.
        public static string GetTheLastWord(IEnumerable<string> words)
        {

            string last = words.Where(name => name.Contains("e"))
             .OrderBy(name => name)
             .LastOrDefault();
            string s = $"The last word is {last}";
            return last == null ? last : s;

            //.Select(word=>$"The last word is {word}") ;
        }
    }
}
