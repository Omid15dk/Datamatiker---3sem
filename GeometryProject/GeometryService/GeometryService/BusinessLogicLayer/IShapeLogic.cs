using GeometryService.Dtos;

namespace GeometryService.BusinessLogicLayer;
public interface IShapeLogic {
    bool DeleteLine(int delId);
    IEnumerable<LineReadDto>? GetAllLines(string? sortParam);
    LineReadDto? GetLineById(int id);
    bool InsertLine(List<CoordinateReadDto> inDtoCoords);
    bool UpdateLine(LineReadDto inLineReadDto);
}