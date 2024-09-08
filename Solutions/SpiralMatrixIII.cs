// https://leetcode.com/problems/spiral-matrix-iii/description/
namespace Solutions;

public static partial class Solution {

    readonly record struct Position(int Row, int Col)
    {
        public bool IsValid(int rows, int cols) => Row >= 0 && Row < rows && Col >= 0 && Col < cols;
    };

    private enum Direction { Right, Down, Left, Top };

    private record State(Position Position, Direction Direction, int Increment);

    private static State GetNextState(State current, bool turn)
    {
        var direction = turn ? (Direction)(((int)current.Direction + 1) % 4) : current.Direction;
        var increment = current.Increment + (turn && direction is Direction.Left or Direction.Right ? 1 : 0);
        var position = current.Direction switch
        {
            Direction.Right => current.Position with { Col = current.Position.Col + 1 },
            Direction.Down => current.Position with { Row = current.Position.Row + 1 },
            Direction.Left => current.Position with { Col = current.Position.Col - 1 },
            Direction.Top => current.Position with { Row = current.Position.Row - 1 },
            _ => throw new InvalidOperationException()
        };
        return new State(position, direction, increment);
    }

    public static int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
    {
        var states = new List<State>();
        var total = rows * cols;
        var current = new State(new Position(rStart, cStart), Direction.Right, 1);
        do
        {
            var distance = current.Increment;
            for (var i = 0; i < distance; i++)
            {
                states.Add(current);
                current = GetNextState(current, turn: i == distance - 1);
            }
        } while (states.Count(x => x.Position.IsValid(rows, cols)) < total);
        return states.Where(x => x.Position.IsValid(rows, cols))
            .Select(s =>new [] { s.Position.Row, s.Position.Col })
            .ToArray();
    }
}
