using GeometryServiceWebConsumer.Models;
using GeometryServiceWebConsumer.ServiceLayer;

namespace GeometryServiceWebConsumer.BusinessLogicLayer {

    public class ShapeLogic {

        private readonly LineService _lineServiceAccess;

        public ShapeLogic(IConfiguration inConfiguration) {
            _lineServiceAccess = new LineService(inConfiguration);
        }

        // Builds web page with all lines
        public async Task<IEnumerable<Line>?> GetAllLines(string sortParam) {
            IEnumerable<Line>? foundLines;
            try {
                foundLines = await _lineServiceAccess.GetLines(sortParam);
            }
            catch {
                foundLines = null;
            }

            return foundLines;
        }

        public async Task<Line?> GetLineById(int id) {
            Line? foundLine = null;
            if (id != 0) {
                try {
                    string? idSortParam = null;
                    IEnumerable<Line>? foundLines = await _lineServiceAccess.GetLines(idSortParam, id);
                    if (foundLines != null) {
                        foundLine = foundLines.FirstOrDefault();
                    }
                }
                catch {
                    foundLine = null;
                }
            }

            return foundLine;
        }

        public async Task<bool> InsertLine(Line inLine) {
            bool wasInserted = false;
            if (inLine != null) {
                try {
                    List<Coordinate> inCoords = new List<Coordinate>() {
                        new Coordinate(inLine.X1, inLine.Y1),
                        new Coordinate(inLine.X2, inLine.Y2)
                    };
                    wasInserted = await _lineServiceAccess.SaveCoords(inCoords);
                }
                catch {
                    wasInserted = false;
                }
            }

            return wasInserted;
        }

        public async Task<bool> UpdateLine(LineToPost inLine) {
            bool wasUpdated;
            try {
                wasUpdated = await _lineServiceAccess.UpdateLine(inLine);
            }
            catch {
                wasUpdated = false;
            }

            return wasUpdated;
        }

        public async Task<bool> DeleteLine(int delId) {
            bool wasDeleted;
            try {
                wasDeleted = await _lineServiceAccess.DeleteLine(delId);
            }
            catch {
                wasDeleted = false;
            }

            return wasDeleted;
        }

    }
}
