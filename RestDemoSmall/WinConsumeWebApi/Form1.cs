using WinConsumeWebApi.BusinessLogicLayer;

namespace WinConsumeWebApi {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void BtnGreet_Click(object sender, EventArgs e) {
            GreetSituation foundSituation = GreetSituation.NoInput;
            string? foundName = null;
            int foundTimes = 0;
            string? fetchedGreetingText = "No input";  // Text from service
            //
            string? rawName = tBoxName.Text;
            string? rawTimes = tBoxTimes.Text;


            if (!string.IsNullOrWhiteSpace(rawName)) {
                foundName = rawName.Trim();
            }
            bool timesOk = int.TryParse(rawTimes, out foundTimes);

            if (foundName != null) {
                foundSituation = GreetSituation.NameOnly;
                if (timesOk) {
                    foundSituation = GreetSituation.NameAndTimes;
                }
            }

            if (foundSituation != GreetSituation.NoInput) {
                GreetCtrl greetCtrl = new GreetCtrl();
                fetchedGreetingText = await greetCtrl.GetGreeting(foundSituation, foundName, foundTimes);
            }

            lblGreeting.Text = fetchedGreetingText;
        }
    }
}