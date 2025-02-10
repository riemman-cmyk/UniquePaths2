namespace UniquePaths2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] obstacleGrid = [[0, 0, 0], [0, 1, 0], [0, 0, 0]];
            Console.WriteLine(get_all_path_number(obstacleGrid));
        }
        static int get_all_path_number(int[][] grid)
        {
            int n = grid[0].Length;
            int m = grid.Length;

            if (grid[0][0] == 1 || grid[m - 1][n - 1] == 1)
            {
                return 0;
            }
            int[] q = new int[n];
            q[0] = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        q[j] = 0;
                    }
                    else if (j > 0)
                    {
                        q[j] += q[j - 1];
                    }
                }
            }

            return q[n - 1];
        }
    }
}
