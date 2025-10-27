namespace GeometryModel.Model;

// A point
public class Coordinate {

    public Coordinate() { }

    public Coordinate(int xValue, int yValue) {
        XValue = xValue;
        YValue = yValue;
    }

    public int XValue { get; init; }

    public int YValue { get; init; }

}
