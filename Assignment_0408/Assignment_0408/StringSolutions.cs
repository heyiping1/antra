using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment_0408
{
    public class StringSolutions
    {
        public void reverseString(string s)
        {
            Console.WriteLine("Method 1: Convert to char array");
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            foreach (char c in chars)
            {
                Console.Write(c);
            }
            Console.WriteLine("\nMethod 2: Print backward");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            
        }

        public void reverseWords(string s)
        {
            string[] words = Regex.Split(s, @"[.,\s:;=()&\[\]""'\\\/!?]+");
            MatchCollection matches = Regex.Matches(s, @"[.,\s:;=()&\[\]""'\\\/!?]+");
            List<string> separators = new List<string>();
            foreach (Match match in matches)
            {
                separators.Add(match.Value);
            }
            StringBuilder sb = new StringBuilder();
            int separatorIndex = 0;
            for (int i = words.Length - 1; i >= 0; i--) { 
                if (words[i].Length > 0)
                {
                    sb.Append(words[i]);
                    sb.Append(separators[separatorIndex++]);
                }
            }
            Console.WriteLine("Original sentence:");
            Console.WriteLine(s);
            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(sb.ToString());
        }

        public void findPalindromes(string s)
        {
            string[] words = Regex.Split(s, @"[.,\s:;=()&\[\]""'\\\/!?]+");
            List<string> palindromes = new List<string>();
            foreach (string word in words)
            {
                bool isPalindrome = true;
                int left = 0;
                int right = word.Length - 1;
                while (left < right)
                {
                    if (word[left] != word[right])
                    {
                        isPalindrome = false;
                        break;
                    }
                    left++;
                    right--;
                }
               if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }
            palindromes = palindromes.Distinct().OrderBy(p => p).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        public void parseURL(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";
            string[] protocolSplit = url.Split("://");
            if (protocolSplit.Length == 2)
            {
                protocol = protocolSplit[0];
                url = protocolSplit[1];
            }
            string[] serverSplit = url.Split('/');
            server = serverSplit[0];
            if (serverSplit.Length > 1)
            {
                resource = serverSplit[1];
            }
            Console.WriteLine(url);
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}
