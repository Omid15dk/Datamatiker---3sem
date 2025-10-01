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
            string? foundNickname = null;
            string? fetchedGreetingText = "No input";  // Text from service
            //
            string? rawName = tBoxName.Text;
            string? rawTimes = tBoxTimes.Text;
            string? rawNickname = tBoxNickname.Text;


            if (!string.IsNullOrWhiteSpace(rawName)) {
                foundName = rawName.Trim();
            }
            bool timesOk = int.TryParse(rawTimes, out foundTimes);
            if(!string.IsNullOrWhiteSpace(rawNickname))
            {
                foundNickname = rawNickname.Trim();
            }

            if (foundName != null)
            {
                foundSituation = GreetSituation.NameOnly;
                if (timesOk)
                {
                    foundSituation = GreetSituation.NameAndTimes;
                }
                if (foundNickname != null)
                {
                    foundSituation = GreetSituation.NameAndNickname;
                }
            }

            if (foundSituation != GreetSituation.NoInput) {
                GreetCtrl greetCtrl = new GreetCtrl();
                fetchedGreetingText = await greetCtrl.GetGreeting(foundSituation, foundName, foundTimes, foundNickname);
            }

            lblGreeting.Text = fetchedGreetingText;
        }
    }
}