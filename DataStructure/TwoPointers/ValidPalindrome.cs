namespace DataStructure.TwoPointers
{
    public static class ValidPalindrome
    {
        private static string input = "Was it a car or a cat I saw?";

        public static void Execute()
        {
            VerifyPalindrome(input);
        }

        public static bool VerifyPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                while (l < r && VerifyAlphaNumeric(s[l]) == false)
                {
                    l++;
                }

                while (r > l && VerifyAlphaNumeric(s[r]) == false)
                {
                    r--;
                }

                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                {
                    return false;
                }

                l++;
                r--;
            }   

            return true;
        }

        public static bool VerifyAlphaNumeric(char c)
        {
            return ((int)c >= 97 && (int)c <= 122) || 
                    ((int)c >= 65 && (int)c <= 90) || 
                    ((int)c >= 48 && (int)c <= 57);
        }
    }
}
