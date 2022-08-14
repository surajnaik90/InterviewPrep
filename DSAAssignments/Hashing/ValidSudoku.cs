/*
Determine if a Sudoku is valid, according to: http://sudoku.com.au/TheRules.aspx

The Sudoku board could be partially filled, where empty cells are filled with the character '.'.

The input corresponding to the above configuration :

["53..7....", "6..195...", ".98....6.", "8...6...3", "4..8.3..1", "7...2...6", ".6....28.", "...419..5", "....8..79"]
A partially filled sudoku which is valid.

Note:

A valid Sudoku board (partially filled) is not necessarily solvable. Only the filled cells need to be validated.
Return 0 / 1 ( 0 for false, 1 for true ) for this problem
 */
public static class ValidSudoku
{
    public static int solve(List<string> A)
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

        for (int i = 0; i < A.Count; i++) {

            rows.Add(new HashSet<int>());

            for (int j = 0; j < A[i].Length; j++) {

                columns.Add(new HashSet<int>());

                int element = (int) char.GetNumericValue(A[i][j]);

                if (element < 1) { continue; }

                if (rows[i].Contains(element)) { 
                    return 0;
                }
                else { 
                    rows[i].Add(element);
                }

                if (columns[j].Contains(element)) { 
                    return 0;
                }
                else {
                    columns[j].Add(element);
                }

                //Compute the grid number
                int k;
                string code = Convert.ToString(i / 3) + Convert.ToString(j / 3);

                k = gridMap[code];

                if (grids[k].Contains(element)) {
                    return 0;
                }
                else {
                    grids[k].Add(element);
                }
            }
        }

        return 1;
    }
}