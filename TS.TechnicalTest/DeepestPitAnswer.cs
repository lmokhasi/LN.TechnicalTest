namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        if (points == null || points.Length < 3)
        {
            return -1;
        }

        int N = points.Length;
        int maxDepth = 0;
        int p = 0;

        while (p < N - 2)
        {
            int q = p + 1;
            while (q < N - 1 && points[q - 1] > points[q])
            {
                q++;
            }

            if (q == p + 1)
            {
                p = q;
                continue;
            }

            int r = q;
            while (r < N && points[r - 1] < points[r])
            {
                r++;
            }

            if (r > q)
            {
                int currentDepth = Math.Min(points[p] - points[q - 1], points[r - 1] - points[q - 1]);
                if (currentDepth > maxDepth)
                {
                    maxDepth = currentDepth;
                }
            }

            p = r - 1;
        }

        return maxDepth > 0 ? maxDepth : -1;
    }
}
