namespace LeetCode.Algorithms;

// EASY
internal sealed class _661
{
    public static int[][] ImageSmoother(int[][] img)
    {
        var n = img.Length;
        var m = img[0].Length;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                var sum = 0;
                var count = 0;
                for (var x = i - 1; x <= i + 1; x++)
                {
                    for (var y = j - 1; y <= j + 1; y++)
                    {
                        if (0 <= x && x < n && 0 <= y && y < m)
                        {
                            sum += img[x][y] & 255;
                            count += 1;
                        }
                    }
                }

                img[i][j] |= (sum / count) << 8;
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                img[i][j] >>= 8;
            }
        }

        return img;
    }
}