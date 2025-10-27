using System.Data.SqlClient;
using GeometryModel.Model;
using Microsoft.Extensions.Configuration;

namespace GeometryData.DatabaseLayer;

public class DbShapeAccess : IShapeAccess {

    private enum SortParameter { none, id, x1value, x2value }
    private readonly SortParameter defaultSortParameter;

    public DbShapeAccess(IConfiguration inConfiguration) {
        // From configuration data get name of conn-string - and then fetch the conn-string
        string? useConnectionString = inConfiguration["ConnectionStringToUse"];
        ConnectionString = useConnectionString is not null ? inConfiguration.GetConnectionString(useConnectionString) : null;
        // Ensure some sorting
        defaultSortParameter = SortParameter.x1value;
    }

    public string? ConnectionString { get; set; }

    public IEnumerable<Line>? GetAllLines(string? sortParam) {

        IEnumerable<Line>? foundLines = null;
        string validSortParamString = GetValidOrderByColumnString(sortParam);

        // Prepare command
        string queryString = $"SELECT id, x1Value, y1Value, x2Value, y2Value FROM Line ORDER BY {validSortParamString}";

        // Get connection
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        using (SqlCommand readCommand = new SqlCommand(queryString, conn)) {
            if (conn != null) {
                conn.Open();
                SqlDataReader lineReader = readCommand.ExecuteReader();
                foundLines = GetLineObjects(lineReader);
            }
        }
        return foundLines;
    }

    public Line? GetLine(int inLineId) {

        Line? foundLine = null;

        // Prepare command
        string queryString = "SELECT id, x1Value, y1Value, x2Value, y2Value FROM LINE where id = @LineId";

        // Get connection
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        using (SqlCommand readCommand = new SqlCommand(queryString, conn)) {

            readCommand.Parameters.AddWithValue("LineId", inLineId);

            if (conn != null) {
                conn.Open();

                SqlDataReader lineReader = readCommand.ExecuteReader();
                List<Line> foundLines = GetLineObjects(lineReader);
                if (foundLines != null) {
                    if (foundLines.Count > 0) {
                        foundLine = foundLines[0];
                    } else {
                        foundLine = new Line { LineId = int.MinValue };
                    }
                }
            }
        }
        return foundLine;
    }

    public bool AddLine(List<Coordinate> newLine) {
        int numberOfRowsInserted = 0;
        // Only proceed if input is valid
        bool coordsAreValid = GetLineCoordinatesValidity(newLine);
        if (coordsAreValid) {
            // The two line points
            Coordinate point1 = newLine[0];
            Coordinate point2 = newLine[1];

            // Prepare command
            string queryString = "INSERT INTO LINE(x1Value, y1Value, x2Value, y2Value) VALUES(@X1Val, @Y1VAL,@X2Val, @Y2VAL)";

            // Get connection
            using SqlConnection conn = new SqlConnection(ConnectionString);
            using SqlCommand insertCommand = new SqlCommand(queryString, conn);
            insertCommand.Parameters.AddWithValue("X1Val", point1.XValue);
            insertCommand.Parameters.AddWithValue("Y1Val", point1.YValue);
            insertCommand.Parameters.AddWithValue("X2Val", point2.XValue);
            insertCommand.Parameters.AddWithValue("Y2Val", point2.YValue);

            if (conn is not null) {
                conn.Open();
                numberOfRowsInserted = insertCommand.ExecuteNonQuery();
            }
        }
        return (numberOfRowsInserted > 0);
    }

    public bool UpdateLine(Line editLine) {
        int numberOfRowsModified = 0;
        // Only proceed if input is valid
        bool lineIsValid = GetLineValidity(editLine);
        if (lineIsValid && editLine.Coordinates is not null) {
            // The two line points
            Coordinate point1 = editLine.Coordinates[0];
            Coordinate point2 = editLine.Coordinates[1];

            // Prepare command - UPDATE Customers
            string queryString = "UPDATE Line SET x1Value=@X1Val, y1Value=@Y1Val, x2Value=@X2Val, y2Value=@Y2Val WHERE id=@LineId";

            // Get connection
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand insertCommand = new SqlCommand(queryString, conn)) {
                if (conn != null && editLine.Coordinates != null) {
                    insertCommand.Parameters.AddWithValue("X1Val", point1.XValue);
                    insertCommand.Parameters.AddWithValue("Y1Val", point1.YValue);
                    insertCommand.Parameters.AddWithValue("X2Val", point2.XValue);
                    insertCommand.Parameters.AddWithValue("Y2Val", point2.YValue);
                    insertCommand.Parameters.AddWithValue("LineId", editLine.LineId);
                    conn.Open();
                    numberOfRowsModified = insertCommand.ExecuteNonQuery();
                }
            }
        }
        return (numberOfRowsModified > 0);
    }

    public bool DeleteLine(int delId) {

        int numberOfRowsDeleted = 0;

        // Prepare command
        string deleteString = "DELETE FROM Line WHERE id=@LineId";

        using (SqlConnection conn = new SqlConnection(ConnectionString))
        using (SqlCommand deleteCommand = new SqlCommand(deleteString, conn)) {

            deleteCommand.Parameters.AddWithValue("LineId", delId);

            if (conn != null) {
                conn.Open();

                numberOfRowsDeleted = deleteCommand.ExecuteNonQuery();
            }
        }

        return (numberOfRowsDeleted > 0);
    }

    private List<Line> GetLineObjects(SqlDataReader lineReader) {
        List<Line> foundLines = new List<Line>();
        Line tempLine;
        List<Coordinate> tempCoord;
        int tempId; int tempX1Val; int tempY1Val; int tempX2Val; int tempY2Val;

        while (lineReader.Read()) {
            tempId = lineReader.GetInt32(lineReader.GetOrdinal("id"));
            tempX1Val = lineReader.GetInt32(lineReader.GetOrdinal("x1Value"));
            tempY1Val = lineReader.GetInt32(lineReader.GetOrdinal("y1Value"));
            tempX2Val = lineReader.GetInt32(lineReader.GetOrdinal("x2Value"));
            tempY2Val = lineReader.GetInt32(lineReader.GetOrdinal("y2Value"));
            tempCoord = new List<Coordinate>() {
                            new Coordinate(tempX1Val, tempY1Val),
                            new Coordinate(tempX2Val, tempY2Val)
                        };
            tempLine = new Line(tempId, tempCoord);
            foundLines.Add(tempLine);
        }
        return foundLines;
    }

    private string GetValidOrderByColumnString(string? rawOrderByString) {
        SortParameter foundSortParameter = GetSortParam(rawOrderByString);
        string validOrderByColumnString = foundSortParameter.ToString();
        return validOrderByColumnString;
    }

    // Validates if sorting parameter is valid - otherwise set to default
    private SortParameter GetSortParam(string? rawSortParam) {
        string? useSortParamString = null;
        if (rawSortParam != null) {
            useSortParamString = rawSortParam.ToLower();
        }
        bool sortParamOk = Enum.TryParse(useSortParamString, out SortParameter foundSortParam);
        if (!sortParamOk || (foundSortParam == SortParameter.none)) {
            foundSortParam = defaultSortParameter;
        }
        return foundSortParam;
    }

    private static bool GetLineValidity(Line lineToCheck) {
        bool lineIsValid = false;
        if (lineToCheck != null && lineToCheck.Coordinates != null) {
            if (lineToCheck.Coordinates.Count >= 2) {
                lineIsValid = true;
            }
        }
        return lineIsValid;
    }

    private bool GetLineCoordinatesValidity(List<Coordinate> coordsToCheck) {
        bool coordsAreValid = false;
        if (coordsToCheck != null && coordsToCheck.Count != 0) {
            if (coordsToCheck.Count >= 2) {
                coordsAreValid = true;
            }
        }
        return coordsAreValid;
    }

}
