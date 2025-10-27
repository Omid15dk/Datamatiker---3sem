using System.ComponentModel.DataAnnotations;

namespace GeometryServiceWebConsumer.Models {
    public class Line {

        // Default constructor necessary for deserialization from JSON
        public Line() { }

        public Line(int inLineId) {
            Id = inLineId;
        }

        public Line(List<Coordinate> Incoords) {
            Coordinates = Incoords;
        }

        public Line(int inLineId, List<Coordinate> Incoords) : this(inLineId) {
            Coordinates = Incoords;
        }

        public int Id { get; set; }
 
        public int X1 { get; set; }
     
        public int Y1 { get; set; }
     
        public int X2 { get; set; }
         
        public int Y2 { get; set; }


        public List<Coordinate>? Coordinates { get; set; }

        private int GetValue(int pointIndex, int coordIndex) {
            int foundVal = int.MinValue;
            if (Coordinates != null && Coordinates.Count == 2) {
                if (coordIndex == 0) {
                    foundVal = Coordinates[pointIndex].XValue;
                }
                if (coordIndex == 1) {
                    foundVal = Coordinates[pointIndex].YValue;
                }
            }
            return foundVal;
        }
    }
}
