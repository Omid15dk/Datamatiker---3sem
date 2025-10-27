namespace GeometryService.Dtos;
public class CoordinateReadDto {

    public CoordinateReadDto() { }

    public CoordinateReadDto(int xValue, int yValue) {
        XValue = xValue;
        YValue = yValue;
    }

    public int XValue { get; set; }

    public int YValue { get; set; }

}
