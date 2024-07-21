public class Solution {
    // Method to evaluate the value of an arithmetic expression in Reverse Polish Notation (RPN)
    public int EvalRPN(string[] tokens) {
        // Initialize a stack to store intermediate results
        Stack<int> stack = new Stack<int>();

        // Iterate through each token in the input array
        foreach (string c in tokens) {
            // Check if the token is an addition operator
            if (c == "+") {
                // Pop the top two values from the stack, add them, and push the result back onto the stack
                stack.Push(stack.Pop() + stack.Pop());
            } 
            // Check if the token is a subtraction operator
            else if (c == "-") {
                // Pop the top two values from the stack, subtract the first popped value from the second, and push the result back onto the stack
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            } 
            // Check if the token is a multiplication operator
            else if (c == "*") {
                // Pop the top two values from the stack, multiply them, and push the result back onto the stack
                stack.Push(stack.Pop() * stack.Pop());
            } 
            // Check if the token is a division operator
            else if (c == "/") {
                // Pop the top two values from the stack, divide the second popped value by the first, and push the result back onto the stack
                // The division result is cast to an integer to ensure truncation towards zero
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push((int) ((double) b / a));
            } 
            // If the token is not an operator, it must be an operand (a number)
            else {
                // Parse the token as an integer and push it onto the stack
                stack.Push(int.Parse(c));
            }
        }
        // The final result of the expression will be the only value remaining in the stack
        return stack.Pop();
    }
}
