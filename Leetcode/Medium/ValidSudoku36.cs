/*
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
 

Example 1:


Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8.
Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 

Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.
 */
public static class ValidSudoku36
{
    public static bool solve(char[][] board)
    {
        List<HashSet<int>> rows = new List<HashSet<int>>();
        List<HashSet<int>> columns = new List<HashSet<int>>();
        List<HashSet<int>> grids = new List<HashSet<int>>();
        for (int i = 0; i < 9; i++) {
            grids.Add(new HashSet<int>());
        }

        Dictionary<string, int> gridMap = new Dictionary<string, int>()
        { {"00",0 },{"01",1 },{"02",2 },
          {"10",3 },{"11",4 },{"12",5 },
          {"20",6 },{"21",7 },{"22",8 } };

        for (int i = 0; i < board.Count(); i++) {

            rows.Add(new HashSet<int>());

            for (int j = 0; j < board[i].Length; j++) {

                columns.Add(new HashSet<int>());

                int element = (int)char.GetNumericValue(board[i][j]);

                if (element < 1) { continue; }

                if (rows[i].Contains(element)) {
                    return false;
                }
                else {
                    rows[i].Add(element);
                }

                if (columns[j].Contains(element)) {
                    return false;
                }
                else {
                    columns[j].Add(element);
                }

                //Compute the grid number
                int k;
                string code = Convert.ToString(i / 3) + Convert.ToString(j / 3);

                k = gridMap[code];

                if (grids[k].Contains(element)) {
                    return false;
                }
                else {
                    grids[k].Add(element);
                }
            }
        }

        return true;
    }
}