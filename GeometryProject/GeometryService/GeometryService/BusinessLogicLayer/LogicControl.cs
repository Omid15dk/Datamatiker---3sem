using System.Diagnostics;
using GeometryModel.Model;
using GeometryData.DatabaseLayer;
using GeometryService.Dtos;
using GeometryService.ModelConversion;

namespace GeometryService.BusinessLogicLayer;
public class LogicControl : IShapeLogic {

    private readonly IShapeAccess _shapeAccess;

    public LogicControl(IShapeAccess inShapeAccess) {
        _shapeAccess = inShapeAccess;
    }

    public IEnumerable<LineReadDto>? GetAllLines(string? sortParam) {
        IEnumerable<LineReadDto>? publicLines = null;
        IEnumerable<Line>? lines;
        try {
            lines = _shapeAccess.GetAllLines(sortParam);     // Ok if sortParan is null
            if (lines is not null) {
                publicLines = LinesConversion.FromLinesToReadDtos(lines);
            }
        }
        catch (Exception exc) {
            Debug.Write(exc.ToString());
            publicLines = null;
        }

        return publicLines;
    }

    public LineReadDto? GetLineById(int id) {
        Line? privateLine;
        LineReadDto? publicLine;
        try {
            privateLine = _shapeAccess.GetLine(id);
            publicLine = LinesConversion.FromLineToReadDto(privateLine);
        }
        catch (Exception exc) {
            Debug.Write(exc.ToString());
            publicLine = null;
        }

        return publicLine;
    }

    public bool InsertLine(List<CoordinateReadDto> inDtoCoords) {
        bool wasInserted = false;
        try {
            if (inDtoCoords != null) {
                List<Coordinate> privateCoords = CoordinatesConversion.FromReadDtoToCoordinate(inDtoCoords);
                wasInserted = _shapeAccess.AddLine(privateCoords);
            }
        }
        catch (Exception exc) {
            Debug.Write(exc.ToString());
            wasInserted = false;
        }

        return wasInserted;
    }

    public bool UpdateLine(LineReadDto inLineReadDto) {
        bool wasUpdated;
        try {
            Line inLine = LinesConversion.FromReadDtoToLine(inLineReadDto);
            wasUpdated = _shapeAccess.UpdateLine(inLine);
        }
        catch (Exception exc) {
            Debug.Write(exc.ToString());
            wasUpdated = false;
        }

        return wasUpdated;
    }

    public bool DeleteLine(int delId) {
        bool wasDeleted;
        try {
            wasDeleted = _shapeAccess.DeleteLine(delId);
        }
        catch (Exception exc) {
            Debug.Write(exc.ToString());
            wasDeleted = false;
        }

        return wasDeleted;
    }

}
