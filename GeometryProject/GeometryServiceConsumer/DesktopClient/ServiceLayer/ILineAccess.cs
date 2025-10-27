using DesktopClient.ModelLayer;

namespace DesktopClient.Servicelayer {
    public interface ILineAccess {

        Task<IEnumerable<Line>?> GetLines(string? sortParam, int id = -1);
        Task<bool> SaveCoords(List<Coordinate> item);

    }
}
