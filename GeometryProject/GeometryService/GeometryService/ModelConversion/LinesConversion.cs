using GeometryModel.Model;
using GeometryService.Dtos;

namespace GeometryService.ModelConversion;
public class LinesConversion {

    public static LineReadDto? FromLineToReadDto(Line? inLine) {
        LineReadDto? foundLine = null;
        if (inLine != null) {
            foundLine = GetLineReadDto(inLine);
        }
        return foundLine;
    }

    public static List<LineReadDto> FromLinesToReadDtos(IEnumerable<Line> inLines) {
        List<LineReadDto> foundLines = new List<LineReadDto>();
        LineReadDto? tempDtoLine;
        foreach (Line line in inLines) {
            tempDtoLine = GetLineReadDto(line);
            if (tempDtoLine != null) {
                foundLines.Add(tempDtoLine);
            }
        }
        return foundLines;
    }

    public static Line FromReadDtoToLine(LineReadDto inLine) {
        List<Coordinate> lineCoordinates = GetLineCoordinates(inLine);
        Line foundLine = new Line(inLine.Id, lineCoordinates);
        return foundLine;
    }

    public static List<Line> FromReadDtosToLines(IEnumerable<LineReadDto> inLines) {
        List<Line> foundLines = new List<Line>();
        Line tempLine;
        if (inLines != null) {
            foreach (LineReadDto dtoLine in inLines) {
                List<Coordinate> lineCoordinates = GetLineCoordinates(dtoLine);
                tempLine = new Line(dtoLine.Id, lineCoordinates);
                foundLines.Add(tempLine);
            }
        }
        return foundLines;
    }

    private static LineReadDto? GetLineReadDto(Line? inLine) {
        LineReadDto? lineReadDto = null;
        if (inLine != null) {
            if (inLine.Coordinates != null && inLine.Coordinates.Count == 2) {
                lineReadDto = new LineReadDto {
                    Id = inLine.LineId,
                    X1 = inLine.Coordinates[0].XValue,  // point 1
                    Y1 = inLine.Coordinates[0].YValue,
                    X2 = inLine.Coordinates[1].XValue,  // point 2
                    Y2 = inLine.Coordinates[1].YValue
                };
            } else {
                lineReadDto = new LineReadDto {
                    Id = inLine.LineId
                };
            }
        }
        return lineReadDto;
    }

    private static List<Coordinate> GetLineCoordinates(LineReadDto inLine) {
        List<Coordinate> lineCoordinates = new List<Coordinate>() {
                new Coordinate(inLine.X1, inLine.Y1),
                new Coordinate(inLine.X2, inLine.Y2)
            };
        return lineCoordinates;
    }


}
