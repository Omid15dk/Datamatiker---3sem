namespace GeometryModel.Model;

public abstract class GeometryBase {

    public GeometryBase() { }   // Necessary for subclass to have empty constructor

    public GeometryBase(List<Coordinate> inCoordinates) {
        Coordinates = inCoordinates;
    }

    public List<Coordinate>? Coordinates { get; set; }

}
