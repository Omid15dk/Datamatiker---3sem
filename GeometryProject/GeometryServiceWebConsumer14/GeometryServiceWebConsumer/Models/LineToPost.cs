using System.ComponentModel.DataAnnotations;

namespace GeometryServiceWebConsumer.Models {
    public class LineToPost {

        public LineToPost() { }

        public int Id { get; set; }

        [Range(0, 1000)]
        public int X1 { get; set; }
        [Range(0, 1000)]
        public int Y1 { get; set; }
        [Range(0, 1000)]
        public int X2 { get; set; }
        [Range(0, 1000)]
        public int Y2 { get; set; }

    }
}
