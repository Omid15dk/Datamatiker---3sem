using DesktopClient.ModelLayer;
using DesktopClient.BusinessLogicLayer;

namespace DesktopClient {
    public partial class Form1 : Form {

        ShapeLogic _shapeLogic;

        public Form1() {
            InitializeComponent();

            _shapeLogic = new ShapeLogic();

            List<string> sortBy = new List<string>() {
                "None", "Id", "X1value", "X2value"
            };
            cbSorting.DataSource = sortBy;
        }

        private async void BtnGetLines_Click(object sender, EventArgs e) {

            string processText = "OK";

            IEnumerable<Line>? fetchedLines;
            string idInputString = textBoxLineId.Text;
            int refinedId = GetAsInt(idInputString);
            string? sortBy = null;
            if (cbSorting.SelectedItem != null) {
                sortBy = cbSorting.SelectedItem.ToString();
            }

            if (refinedId > 0) {
                // Call service with id
                fetchedLines = await _shapeLogic.GetLineById(refinedId);
            }
            else {
                // Call without id
                fetchedLines = await _shapeLogic.GetAllLines(sortBy);
            }

            if (fetchedLines == null) {
                processText = "NOT ok";
            }

            lblProcessGet.Text = processText;
            listBoxResult.DataSource = fetchedLines;

        }

        private async void BtnSaveLine_Click(object sender, EventArgs e) {
            bool wasSavedOk;
            string processText = "OK";

            string x1InputString = textBoxX1.Text;
            int refinedX1 = GetAsInt(x1InputString);
            string y1InputString = textBoxY1.Text;
            int refinedY1 = GetAsInt(y1InputString);
            string x2InputString = textBoxX2.Text;
            int refinedX2 = GetAsInt(x2InputString);
            string y2InputString = textBoxY2.Text;
            int refinedY2 = GetAsInt(y2InputString);

            if (refinedX1 >= 0 && refinedY1 >= 0 && refinedX2 >= 0 && refinedY2 >= 0) {
                // Call service to POST 
                List<Coordinate> aLine = new List<Coordinate>() {
                    new Coordinate(refinedX1, refinedY1),
                    new Coordinate(refinedX2, refinedY2)
                };
                wasSavedOk = await _shapeLogic.InsertLine(aLine);
            }
            else {
                wasSavedOk = false;
            }

            if (!wasSavedOk) {
                processText = "NOT ok";
            }

            lblProcessPost.Text = processText;

            textBoxLineId.Text = null;
            BtnGetLines_Click(null, null);  // Hack - to structure better
        }

        private int GetAsInt(string rawIntString) {
            int foundInt = -1;

            if (!string.IsNullOrWhiteSpace(rawIntString)) {
                int.TryParse(rawIntString.Trim(), out foundInt);
            }

            return foundInt;
        }

    }
}
