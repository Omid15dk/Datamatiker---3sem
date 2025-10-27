using GeometryServiceWebConsumer.Models;

namespace GeometryServiceWebConsumer.ServiceLayer {
    public interface ILineAccess {

        Task<IEnumerable<Line>?> GetLines(string? sortParam, int id = -1);
        Task<bool> SaveCoords(List<Coordinate> item);

    }
}
