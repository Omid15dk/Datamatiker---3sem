using WinConsumeWebApi.ServiceLayer;

namespace WinConsumeWebApi.BusinessLogicLayer {
    public class GreetCtrl {

        public async Task<string?> GetGreeting(GreetSituation inSit, string? inName, int inTimes, string? inNickname) {

            string? fetchedText = null;

            GreetCall hiService = new();

            switch (inSit) {
                case GreetSituation.NoInput:
                    fetchedText = await hiService.GetGreeting();
                    break;
                case GreetSituation.NameOnly:
                    if (inName != null) {
                        fetchedText = await hiService.GetGreeting(inName);
                    }
                    break;
                case GreetSituation.NameAndTimes:
                    if (inName != null) {
                        fetchedText = await hiService.GetGreeting(inName, null, inTimes);
                    }
                    break;
                case GreetSituation.NameAndNickname:
                    if (inName != null)
                    {
                        fetchedText = await hiService.GetGreeting(inName, inNickname);
                    }
                    break;
            }

            return fetchedText;
        }

    }
}
