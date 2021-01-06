namespace Coding
{
    public static class Array
    {
        public static int[][] GetPascalTriangle(int n)
        {
            var pascalTriangle = new int[n][];
            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i] = new int[i + 1];
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][i] = 1;

                for (int j = 1; j <= i - 1; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
                }
            }

            return pascalTriangle;
        }
    }
}
