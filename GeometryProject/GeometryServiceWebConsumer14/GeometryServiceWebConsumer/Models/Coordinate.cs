namespace GeometryServiceWebConsumer.Models {
    public class Coordinate {

        public Coordinate(int xValue, int yValue) {
            XValue = xValue;
            YValue = yValue;
        }

        public int XValue { get; set; }

        public int YValue { get; set; }

    }
}
