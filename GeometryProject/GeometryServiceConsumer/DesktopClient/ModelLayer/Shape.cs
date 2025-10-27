namespace DesktopClient.ModelLayer {

    public abstract class Shape {

        public int ShapeId { get; set; }

        public List<Coordinate>? Coordinates { get; set; }

    }
}
