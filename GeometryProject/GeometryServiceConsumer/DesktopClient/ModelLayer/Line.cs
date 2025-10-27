namespace DesktopClient.ModelLayer;

public class Line {

    public List<Coordinate>? Coordinates { get; set; }

    // Default constructor necessary for deserialization from JSON
    public Line() { }

    public Line(int inLineId) {
        Id = inLineId;
    }

    public Line(List<Coordinate> Incoords) {
        Coordinates = Incoords;
    }

    public Line(int inShapeId, List<Coordinate> Incoords) : this(inShapeId) {
        Coordinates = Incoords;
    }

    public int Id { get; set; }
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public override string ToString() {
        string coordText = $"Id {Id} - Coordinates: ({X1},{Y1}), ({X2},{Y2})";
        return coordText;
    }

}
