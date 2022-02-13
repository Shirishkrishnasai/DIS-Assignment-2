/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK

AUTHOR: Shirish Krishna Sai Yalavarthy
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ISM6225_Assignment_2_Spring_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1:
            Console.WriteLine("Question 1:");
            //int[] nums1 = { 0, 1, 2, 3, 12 };
            int[] nums1 = {1, 3, 5, 6 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums1, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question2:
            Console.WriteLine("Question 2");
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            //string paragraph = "a.";
            string[] banned = { "hit" };
            //string[] banned = { "" };

            string commonWord = MostCommonWord(paragraph, banned);
            Console.WriteLine("Most frequent word is {0}:", commonWord);
            Console.WriteLine();

            //Question 3:
            Console.WriteLine("Question 3");
            //int[] arr1 = { 2, 2, 3, 4 };
            int[] arr1 = { 2, 2, 2, 3, 3 };
            

            int lucky_number = FindLucky(arr1);
            Console.WriteLine("The Lucky number in the given array is {0}", lucky_number);
            Console.WriteLine();

            //Question 4:
            Console.WriteLine("Question 4");
            string secret = "1807";
            string guess = "7810";
            string hint = GetHint(secret, guess);
            Console.WriteLine("Hint for the guess is :{0}", hint);
            Console.WriteLine();


            //Question 5:
            Console.WriteLine("Question 5");
            string s = "ababcbacadefegdehijhklij";
            List<int> part = PartitionLabels(s);
            Console.WriteLine("Partation lengths are:");
            for (int i = 0; i < part.Count; i++)
            {
                Console.Write(part[i] + "\t");
            }
            Console.WriteLine();

            //Question 6:
            Console.WriteLine("Question 6");
            int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            string bulls_string9 = "abcdefghijklmnopqrstuvwxyz";
            //int[] widths = new int[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            //string bulls_string9 = "bbbcccdddaaa";
            
            List<int> lines = NumberOfLines(widths, bulls_string9);
            Console.WriteLine("Lines Required to print:");
            for (int i = 0; i < lines.Count; i++)
            {
                Console.Write(lines[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Question 7:
            Console.WriteLine("Question 7:");
            string bulls_string10 = "()[]{}";
            //string bulls_string10 = "(]";
            bool isvalid = IsValid(bulls_string10);
            if (isvalid)
                Console.WriteLine("Valid String");
            else
                Console.WriteLine("String is not Valid");

            Console.WriteLine();
            Console.WriteLine();


            //Question 8:
            Console.WriteLine("Question 8");
            string[] bulls_string13 = { "gin", "zen", "gig", "msg" };
            int diffwords = UniqueMorseRepresentations(bulls_string13);
            Console.WriteLine("Number of with unique code are: {0}", diffwords);
            Console.WriteLine();
            Console.WriteLine();

            //Question 9:
            Console.WriteLine("Question 9");
            int[,] grid = new int[,] {  { 0, 1, 2, 3, 4 },  { 24, 23, 22, 21, 5 },  { 12, 13, 14, 15, 16 },  { 11, 17, 18, 19, 20 },  { 10, 9, 8, 7, 6 } };
            //int[][] grid = new int[][] { new int[] { 0, 1, 2, 3, 4 }, new int[] { 24, 23, 22, 21, 5 }, new int[] { 12, 13, 14, 15, 16 }, new int[] { 11, 17, 18, 19, 20 }, new int[] { 10, 9, 8, 7, 6 } };
            int time = SwimInWater(grid);
            Console.WriteLine("Minimum time required is: {0}", time);
            Console.WriteLine();

            //Question 10:
            Console.WriteLine("Question 10");
            string word1  = "horse";
            string word2 = "ros";
            int minLen = MinDistance( word1,  word2);
            Console.WriteLine("Minimum number of operations required are {0}", minLen);
            Console.WriteLine();
        }
    

        /*
        
        Question 1:
        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        Note: The algorithm should have run time complexity of O (log n).
        Hint: Use binary search
        Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2
        Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1
        Example 3:
        Input: nums = [1,3,5,6], target = 7
        Output: 4
        */

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                for (int i = 0; i < nums.Length; i++)  // Iterate until we find the index of required target number
                { 
                    if (nums[i] >= target)  
                    {
                        return i;  // If Target is found return the index if number is not found return the index of last number lower than the nums[i]
                    }
                }
                return nums.Length;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         
        Question 2
       
        Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.
        The words in paragraph are case-insensitive and the answer should be returned in lowercase.

        Example 1:
        Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
        Output: "ball"
        Explanation: "hit" occurs 3 times, but it is a banned word. "ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
        Note that words in the paragraph are not case sensitive, that punctuation is ignored (even if adjacent to words, such as "ball,"), and that "hit" isn't the answer even though it occurs more because it is banned.

        Example 2:
        Input: paragraph = "a.", banned = []
        Output: "a"
        */

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            try
            {

                Dictionary<string, int> frequency_dict = new Dictionary<string, int>();
                paragraph = paragraph.ToLower();  // convert paragraph to lower characters
                char[] punctuations = { ' ', '!', '?', ',', ';', '.', '\'' };  // list out all the punctuations to be removed
                string[] split_para = paragraph.Split(punctuations, StringSplitOptions.RemoveEmptyEntries);  // remove all punctuations and empty entries

                foreach (string str_word in split_para)  
                {
                    if (Array.IndexOf(banned, str_word) == -1)  // If Banned index is -1 it then loop iteration continues to frequency dictionary
                    {
                        if (frequency_dict.ContainsKey(str_word))
                        {
                            frequency_dict[str_word] += 1;  // If frequency dict has the word increase the index of the word
                        }
                        else
                        {
                            frequency_dict.Add(str_word, 1);  // else add the word to the frequency c
                        }
                    }
                }

                KeyValuePair<string, int> max_value = new KeyValuePair<string, int>();
                foreach (var key_value in frequency_dict)
                {
                    if (key_value.Value > max_value.Value)
                        max_value = key_value;
                }
                return max_value.Key;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
        Question 3:
        Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
        Return the largest lucky integer in the array. If there is no lucky integer return -1.
 
        Example 1:
        Input: arr = [2,2,3,4]
        Output: 2
        Explanation: The only lucky number in the array is 2 because frequency[2] == 2.

        Example 2:
        Input: arr = [1,2,2,3,3,3]
        Output: 3
        Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.

        Example 3:
        Input: arr = [2,2,2,3,3]
        Output: -1
        Explanation: There are no lucky numbers in the array.
         */

        public static int FindLucky(int[] arr)
        {
            try
            {
                int max_default_return_value = -1;  // If there is no lucky integer -1 should be returned.
                var integer_dict = new Dictionary<int, int>();  
                for (int i = 0; i < arr.Length; i++)  
                {
                    if (integer_dict.ContainsKey(arr[i]))    // If the key is in Dict add the value of the key
                    {    
                        integer_dict[arr[i]]++;  
                    }
                    else    // if key is not in the dict add the integer with value to be iterated
                    {
                        integer_dict.Add(arr[i], 1);
                    }
                }
             
                foreach (var item in integer_dict)
                {
                    if (item.Key == item.Value && item.Key > max_default_return_value)
                    {                                           // If the value matches the key return all the values 
                        max_default_return_value = item.Key;
                    }
                }
                return max_default_return_value;               
            }
            catch (Exception)
            {
                throw;
            }

        }

        /*
        
        Question 4:
        You are playing the Bulls and Cows game with your friend.
        You write down a secret number and ask your friend to guess what the number is. When your friend makes a guess, you provide a hint with the following info:
        •	The number of "bulls", which are digits in the guess that are in the correct position.
        •	The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position. Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
        Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.
        The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. Note that both secret and guess may contain duplicate digits.
 
        Example 1:
        Input: secret = "1807", guess = "7810"
        Output: "1A3B"
        Explanation: Bulls relate to a '|' and cows are underlined:
        "1807"
          |
        "7810"

        */

        public static string GetHint(string secret, string guess)
        {
            try
            {
                int bull_count = 0;  
                int cow_count = 0;

                int[] secret_count = new int[10];
                int[] guess_count = new int[10];

                for (int i = 0; i < secret.Length; i++)  
                {
                    if (secret[i] == guess[i])  // If index of secret matches with index of guess increment the bull count
                    {
                        bull_count++;
                    }
                    else    // If index dosen't match iterate through secret_count and guess_count
                    {    
                        secret_count[secret[i] - '0']++;
                        guess_count[guess[i] - '0']++;
                    }
                }

                for (int i = 0; i < 10; i++)  // Concatenate the minimum secret cound and guess to A and B respectively
                {
                    cow_count += Math.Min(secret_count[i], guess_count[i]);
                }

                return bull_count.ToString() + "A" + cow_count.ToString() + "B";


            }
            catch (Exception)
            {

                throw;
            }
        }


        /*
        Question 5:
        You are given a string s. We want to partition the string into as many parts as possible so that each letter appears in at most one part.
        Return a list of integers representing the size of these parts.

        Example 1:
        Input: s = "ababcbacadefegdehijhklij"
        Output: [9,7,8]
        Explanation:
        The partition is "ababcbaca", "defegde", "hijhklij".
        This is a partition so that each letter appears in at most one part.
        A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.

        */

        public static List<int> PartitionLabels(string s)
        {
            try
            {
                var result = new List<int>();    // result list to be returned

                int i = 0;
                int len = s.Length;
                while (i < len)
                {
                    int last_index = s.LastIndexOf(s[i]);  // returns last index of the required value

                    for (int j = i + 1; j < last_index; j++)
                    {
                        int temporary_index = s.LastIndexOf(s[j]);    // store the last index of the value j as temporary
                        if (temporary_index > last_index)     // if the temporary is greater than lastindex of i reinitiate the value of temporary to lastindex
                            last_index = temporary_index;  
                    }
                    result.Add(last_index + 1 - i);    
                    i = last_index + 1;
                }
                //Console.WriteLine(result);
                return result;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
        Question 6

        You are given a string s of lowercase English letters and an array widths denoting how many pixels wide each lowercase English letter is. Specifically, widths[0] is the width of 'a', widths[1] is the width of 'b', and so on.
        You are trying to write s across several lines, where each line is no longer than 100 pixels. Starting at the beginning of s, write as many letters on the first line such that the total width does not exceed 100 pixels. Then, from where you stopped in s, continue writing as many letters as you can on the second line. Continue this process until you have written all of s.
        Return an array result of length 2 where:
             •	result[0] is the total number of lines.
             •	result[1] is the width of the last line in pixels.
 
        Example 1:
        Input: widths = [10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], s = "abcdefghijklmnopqrstuvwxyz"
        Output: [3,60]
        Explanation: You can write s as follows:
                     abcdefghij  	 // 100 pixels wide
                     klmnopqrst  	 // 100 pixels wide
                     uvwxyz      	 // 60 pixels wide
                     There are a total of 3 lines, and the last line is 60 pixels wide.



         Example 2:
         Input: widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], 
         s = "bbbcccdddaaa"
         Output: [2,4]
         Explanation: You can write s as follows:
                      bbbcccdddaa  	  // 98 pixels wide
                      a           	 // 4 pixels wide
                      There are a total of 2 lines, and the last line is 4 pixels wide.

         */

        public static List<int> NumberOfLines(int[] widths,string s)
        {
            try
            {
                var result = new[] { 1, 0 };    // result list to be returned

                foreach (var c in s)    // Iterate through the string
                {
                    result[1] += widths[c - 'a'];
                    if (100 < result[1])         // As the width can't be exceed 100 iterate through result[1] until loop reaches 100
                    {
                        ++result[0];    
                        result[1] = widths[c - 'a'];  
                    }
                }
                
                return new List<int>() {result[0], result[1] };
            }
            catch (Exception)
            {
                throw;
            }

        }


        /*
        
        Question 7:

        Given a string bulls_string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
            1.	Open brackets must be closed by the same type of brackets.
            2.	Open brackets must be closed in the correct order.
 
        Example 1:
        Input: bulls_string = "()"
        Output: true

        Example 2:
        Input: bulls_string  = "()[]{}"
        Output: true

        Example 3:
        Input: bulls_string  = "(]"
        Output: false

        */

        public static bool IsValid(string bulls_string10)
        {
            try
            {
                bool is_present;      // boolean value to check the string character
                while (bulls_string10.Length > 0)
                {
                    is_present = false;
                    if (bulls_string10.IndexOf("{}") != -1)        // check all the required characters indices from the end and return true if it satisifies all the conditions
                    {
                        bulls_string10 = bulls_string10.Replace("{}", "");
                        is_present = true;
                    }
                    else if (bulls_string10.IndexOf("[]") != -1)
                    {
                        bulls_string10 = bulls_string10.Replace("[]", "");
                        is_present = true;
                    }
                    else if (bulls_string10.IndexOf("()") != -1)
                    {
                        bulls_string10 = bulls_string10.Replace("()", "");
                        is_present = true;
                    }
                    if (bulls_string10.Length == 1 || !is_present) return false;  // if only one character is present return false 
                }
                return true;
                //return false;
            }
            catch (Exception)
            {
                throw;
            }
        }



        /*
         Question 8
        International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
        •	'a' maps to ".-",
        •	'b' maps to "-...",
        •	'c' maps to "-.-.", and so on.

        For convenience, the full table for the 26 letters of the English alphabet is given below:
        [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
            •	For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
        Return the number of different transformations among all words we have.
 
        Example 1:
        Input: words = ["gin","zen","gig","msg"]
        Output: 2
        Explanation: The transformation of each word is:
        "gin" -> "--...-."
        "zen" -> "--...-."
        "gig" -> "--...--."
        "msg" -> "--...--."
        There are 2 different transformations: "--...-." and "--...--.".

        */

        public static int UniqueMorseRepresentations(string[] words)
        {
            try
            {
                String[] morse_code_list = new String[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
                // Gather all the morse code into a list
                String[] result = new String[words.Length];
                int i = 0;

                foreach (var word in words)   // iterate through the input list of words and then letters
                {
                    foreach (var letter in word)
                    {
                        result[i] += morse_code_list[((int)letter - 97)];     
                    }
                    Console.WriteLine(result[i]);
                    i++;
                }
                return result.Distinct().ToArray().Count();    // return the count of the distinct transformations 
            }
            catch (Exception)
            {
                throw;
            }

        }

      


        /*
        
        Question 9:
        You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation at that point (i, j).
        The rain starts to fall. At time t, the depth of the water everywhere is t. You can swim from a square to another 4-directionally adjacent square if and only if the elevation of both squares individually are at most t. You can swim infinite distances in zero time. Of course, you must stay within the boundaries of the grid during your swim.
        Return the least time until you can reach the bottom right square (n - 1, n - 1) if you start at the top left square (0, 0).

        Example 1:
        Input: grid = [[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]
        Output: 16
        Explanation: The final route is shown.
        We need to wait until time 16 so that (0, 0) and (4, 4) are connected.

        */

        public static int SwimInWater(int[,] grid)
        {
            try
            {
                int grid_len = grid.GetLength(0);  // get the length of the array 
                int low = Math.Max(grid[0,0], grid[grid_len - 1,grid_len - 1]);  // get the lowest value in the grid
                int high = grid_len * grid_len - 2;  // get the highest value in the grid
                bool[] check_done = null;  
                while (low <= high)
                {
                    int mid = low + (high - low) / 2;    // middle vale of the grid
                    check_done = new bool[grid_len * grid_len];  
                    var success = Depth_first_search(mid, 0, 0);    // returns the value from Depth_first_search algorithm
                    if (success)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                return low;

                bool Depth_first_search(int t, int y, int x)  // Depth first search algorithm
                {
                    if (x == grid_len - 1 && y == grid_len - 1)
                        return true;

                    check_done[grid[y,x]] = true;
                    if (y - 1 >= 0 && !check_done[grid[y - 1, x]] && grid[y - 1, x] <= t && Depth_first_search(t, y - 1, x))    // upper grid
                        return true;
                    if (y + 1 < grid_len && !check_done[grid[y + 1,x]] && grid[y + 1,x] <= t && Depth_first_search(t, y + 1, x)) // down grid
                        return true;
                    if (x + 1 < grid_len && !check_done[grid[y,x + 1]] && grid[y,x + 1] <= t && Depth_first_search(t, y, x + 1)) // right grid
                        return true;
                    if (x - 1 >= 0 && !check_done[grid[y, x - 1]] && grid[y, x - 1] <= t && Depth_first_search(t, y, x - 1))    // left grid
                        return true;

                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         
        Question 10:
        Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
        You have the following three operations permitted on a word:

        •	Insert a character
        •	Delete a character
        •	Replace a character
         Note: Try to come up with a solution that has polynomial runtime, then try to optimize it to quadratic runtime.

        Example 1:
        Input: word1 = "horse", word2 = "ros"
        Output: 3
        Explanation: 
        horse -> rorse (replace 'h' with 'r')
        rorse -> rose (remove 'r')
        rose -> ros (remove 'e')

        */

        public static int MinDistance(string word1, string word2)
        {
            try
            {
                int word1_len = word1.Length;
                int word2_len = word2.Length;

                if (word1_len * word2_len == 0)     // if multiplication of lengths is 0 add the lengths and return
                    return word1_len + word2_len;  

                int[,] result = new int[word1_len + 1, word2_len + 1];    

                for (int i = 0; i <= word1_len; i++)
                {
                    for (int j = 0; j <= word2_len; j++)
                    {
                        if (i == 0)
                        {
                            result[i, j] = j;    // add j to result when the i is 0 and proceed
                        }
                        else if (j == 0)       // add i to result when the j is 0 and proceed
                        {
                            result[i, j] = i;
                        }
                        else if (word1[i - 1] == word2[j - 1])   // if indices of word i-1 and word 2 j-1 are equal add i-1 and j-1 to result 
                        {
                            result[i, j] = result[i - 1, j - 1];
                        }
                        else  // else add minimum value of result of i-1,j-1, and minimum value of i,j-1, and result of i-1,j and contiune iteration
                        {
                            result[i, j] = Math.Min(result[i - 1, j - 1], Math.Min(result[i, j - 1], result[i - 1, j])) + 1;
                        }
                    }
                } 
                return result[word1_len, word2_len];    // return the result 
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
