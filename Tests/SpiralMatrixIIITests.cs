namespace Tests;

public class SpiralMatrixIIITests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void SpiralMatrix(int rows, int cols, int rStart, int cStart, int[][] expected)
    {
        var spiralMatrix = Solution.SpiralMatrixIII(rows, cols, rStart, cStart);
        spiralMatrix.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { 1, 4, 0, 0, new int[][] { [0,0],[0,1],[0,2],[0,3] } },
            new object[] { 5, 6, 1, 4, new int[][] { [1,4],[1,5],[2,5],[2,4],[2,3],[1,3],[0,3],[0,4],[0,5],[3,5],[3,4],[3,3],[3,2],[2,2],[1,2],[0,2],[4,5],[4,4],[4,3],[4,2],[4,1],[3,1],[2,1],[1,1],[0,1],[4,0],[3,0],[2,0],[1,0],[0,0] } },
        };
    
}