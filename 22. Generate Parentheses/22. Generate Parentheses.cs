public class Solution 
{
    
    // Main method to generate valid parentheses combinations
    public List<string> GenerateParenthesis(int n) 
    {
        List<string> res = new List<string>(); // Initialize result list
        Backtrack(n, 0, 0, "", res); // Start backtracking with initial values
        return res; // Return the list of valid combinations
    }

    // Recursive backtracking method to generate valid parentheses
    private void Backtrack(int n, int openN, int closedN, string current, List<string> res) 
    {
        // Base case: if we have used all n pairs of parentheses
        if (openN == closedN && openN == n) 
        {
            res.Add(current); // Add the current valid combination to the result list
            return; // End this branch of recursion
        }

        // If we can add an opening parenthesis (haven't used all n yet)
        if (openN < n) 
        {
            // Recurse, adding an opening parenthesis
            Backtrack(n, openN + 1, closedN, current + "(", res);
        }
        // If we can add a closing parenthesis (must have more open than closed)
        if (closedN < openN) 
        {
            // Recurse, adding a closing parenthesis
            Backtrack(n, openN, closedN + 1, current + ")", res);
        }
    }
}