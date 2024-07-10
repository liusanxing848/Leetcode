public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Dictionaries to store the characters in each column, row, and 3x3 square
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> squares = new Dictionary<int, HashSet<char>>();  // key = (r / 3) * 3 + c / 3

        // Iterate over each cell in the 9x9 Sudoku board
        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char cell = board[r][c];
                
                // Skip empty cells
                if (cell == '.') {
                    continue;
                }

                // Check if the current cell value is already present in the corresponding row, column, or 3x3 square
                if (rows.TryGetValue(r, out var rowSet) && rowSet.Contains(cell)
                        || cols.TryGetValue(c, out var colSet) && colSet.Contains(cell)
                        || squares.TryGetValue((r / 3) * 3 + c / 3, out var squareSet) && squareSet.Contains(cell)) {
                    // If the value is already present, the board is invalid
                    return false;
                }

                // Initialize the HashSet for the current column if it doesn't exist
                cols.TryAdd(c, new HashSet<char>());
                // Initialize the HashSet for the current row if it doesn't exist
                rows.TryAdd(r, new HashSet<char>());
                // Initialize the HashSet for the current 3x3 square if it doesn't exist
                squares.TryAdd((r / 3) * 3 + c / 3, new HashSet<char>());

                // Add the current cell value to the corresponding row, column, and 3x3 square sets
                cols[c].Add(cell);
                rows[r].Add(cell);
                squares[(r / 3) * 3 + c / 3].Add(cell);
            }
        }
        // If no duplicates are found, the board is valid
        return true;
    }
}
