using DesktopClient.ModelLayer;
using DesktopClient.Servicelayer;

namespace DesktopClient.BusinessLogicLayer {
    public class ShapeLogic {

        private readonly ILineAccess _lineServiceAccess;

        public ShapeLogic() {
            _lineServiceAccess = new LineServiceAccess();
        }

        public async Task<IEnumerable<Line>?> GetAllLines(string? sortParam) {
            IEnumerable<Line>? foundLines;
            try {
                foundLines = await _lineServiceAccess.GetLines(sortParam);
            }
            catch {
                foundLines = null;
            }

            return foundLines;
        }

        public async Task<IEnumerable<Line>?> GetLineById(int id) {
            IEnumerable<Line>? foundLines;
            try {
                string? idSortParam = null;
                foundLines = await _lineServiceAccess.GetLines(idSortParam, id);
            }
            catch {
                foundLines = null;
            }

            return foundLines;
        }

        public async Task<bool> InsertLine(List<Coordinate> inCoords) {
            bool wasInserted;
            try {
                wasInserted = await _lineServiceAccess.SaveCoords(inCoords);
            }
            catch {
                wasInserted = false;
            }

            return wasInserted;
        }

    }
}
