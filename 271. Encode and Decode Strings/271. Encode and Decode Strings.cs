public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) 
    {
        // StringBuilder is used to efficiently concatenate strings.
        StringBuilder sb = new StringBuilder();

        // Iterate through each string in the list.
        foreach (string s in strs)
        {
            // Append the length of the string followed by a special character '#' to the StringBuilder.
            sb.Append(s.Length);
            sb.Append('#');
            // Append the actual string to the StringBuilder.
            sb.Append(s);
        }

        // Convert the StringBuilder to a single string and return it.
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) 
    {
        // List to store the decoded strings.
        List<string> res = new List<string>();

        // Pointer to traverse the encoded string.
        int i = 0;
        
        // Loop until the entire encoded string is processed.
        while (i < s.Length)
        {
            // Another pointer to find the position of the special character '#'.
            int j = i;

            // Find the position of the next '#' character.
            while (s[j] != '#')
            {
                j++;
            }

            // Extract the length of the next string from the current position to the '#' character.
            // j - i gives the length of the numeric substring.
            int length = Int32.Parse(s.Substring(i, j - i));

            // Extract the actual string using the length found above. 
            // Starting position is (j + 1) because we need to skip the '#'.
            res.Add(s.Substring(j + 1, length));

            // Move the pointer to the next encoded part. 
            // (j + 1 + length) skips past the '#' and the current string.
            i = j + 1 + length;
        }

        // Return the list of decoded strings.
        return res;
    }
}