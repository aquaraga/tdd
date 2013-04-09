﻿
namespace TDD
{
    public class StringUtil
    {
        public static string Reverse(string input)
        {
            if (input == null)
                return input;

            char[] charArray = input.ToCharArray();
            int start = 0;
            while (start < input.Length)
            {
                int end = FindLogicalEndOfWord(charArray, start);
                SwapInRange(charArray, start, end);
                start = FindBeginningOfNextWord(charArray, end + 1);
            }
            return new string(charArray);
        }

        private static int FindBeginningOfNextWord(char[] charArray, int spaceIndex)
        {
            while (spaceIndex < charArray.Length && charArray[spaceIndex] == ' ')
            {
                ++spaceIndex;
            }
            return spaceIndex;
        }

        private static int FindLogicalEndOfWord(char[] charArray, int fromIndex)
        {
            int lastNonSpaceIndex = fromIndex;
            while (lastNonSpaceIndex < charArray.Length && charArray[lastNonSpaceIndex] != ' ')
            {
                ++lastNonSpaceIndex;
            }
            return lastNonSpaceIndex - 1;
        }

        private static void SwapInRange(char[] charArray, int beginning, int end)
        {
            //Swap the beginning and end characters progressively until the middle of the sub-range is reached
            int middle = (end + beginning) / 2;
            for (int i = beginning; i <= middle; ++i)
            {
                Swap(charArray, i, end--);
            }
        }

        private static void Swap(char[] charArray, int position1, int position2)
        {
            char temp = charArray[position1];
            charArray[position1] = charArray[position2];
            charArray[position2] = temp;
        }
    }
}
