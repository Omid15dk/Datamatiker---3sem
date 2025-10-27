using GeometryModel.Model;

namespace GeometryData.DatabaseLayer;

public interface IShapeAccess {

    IEnumerable<Line>? GetAllLines(string? sortParam);

    Line? GetLine(int id);

    bool AddLine(List<Coordinate> newCoords);

    bool UpdateLine(Line editLine);

    bool DeleteLine(int id);

}
