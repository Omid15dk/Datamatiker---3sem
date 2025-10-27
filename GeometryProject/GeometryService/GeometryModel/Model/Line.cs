namespace GeometryModel.Model;

public class Line : GeometryBase {

    public Line() { }

    // Constructor - applies superclass (base) constructor
    public Line(List<Coordinate> inCoords) : base(inCoords) { }

    // Constructor - reuse this classes constructor
    public Line(int lineId, List<Coordinate> inCoords) : this(inCoords) {
        LineId = lineId;
    }

    public int LineId { get; set; }

}
