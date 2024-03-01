namespace exercise{
    public class Word
    {
        // wow
        // Anna
        public bool Palindrome(string word)
        {
            string inputWord = word.ToLower();
            int i;
            List<char> wordL = new List<char>();
            for(i = 0; i < word.Length; i++)
            {
                char newWord = inputWord[i];
                wordL.Add(newWord);                
            }
            wordL.Reverse();
            string newString = "";
            for(i = 0; i < wordL.Count; i++)
            {
                newString += wordL[i];
            }

            if(inputWord == newString){
                return true;
            }
            return false;
        }
    }
}