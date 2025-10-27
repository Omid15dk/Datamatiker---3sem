using GeometryModel.Model;
using GeometryService.Dtos;

namespace GeometryService.ModelConversion;

public class CoordinatesConversion {

    public static List<Coordinate> FromReadDtoToCoordinate(IEnumerable<CoordinateReadDto> readCoords) {
        List<Coordinate> foundCoordinates = new List<Coordinate>();
        Coordinate tempCoord;
        foreach (CoordinateReadDto readCoord in readCoords) {
            tempCoord = new Coordinate(readCoord.XValue, readCoord.YValue);
            foundCoordinates.Add(tempCoord);
        }
        return foundCoordinates;
    }

}
