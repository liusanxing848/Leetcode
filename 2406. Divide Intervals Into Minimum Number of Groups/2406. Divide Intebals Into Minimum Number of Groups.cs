public class Solution 
{
    public int PartitionString(string s) 
    {
        if(String.IsNullOrEmpty(s)) //edge case
        {
            return 0;
        }

        int counter = 1; //if string is null or empty, means at leas there will be some char in it

        HashSet<char> record = new HashSet<char>(); //Hashset to check if have any duplicates

        foreach(char c in s)
        {
            if(record.Contains(c)) //if found duplicates
            {
                counter ++; //counter increment by 1
                record = new HashSet<char>(){c}; //destory current hashset, then register the current char in the HashSet then start over
            }

            record.Add(c); //if did not found any duplicates, then add current char into the HashSet.
        }
        return counter; 
    }
}