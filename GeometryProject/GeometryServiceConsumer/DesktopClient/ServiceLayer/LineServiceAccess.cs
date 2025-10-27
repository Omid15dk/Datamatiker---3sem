using System.Text;
using Newtonsoft.Json;
using DesktopClient.ModelLayer;
using System.Configuration;
using DesktopClient.ServiceLayer;

namespace DesktopClient.Servicelayer {

    public class LineServiceAccess : ServiceConnection, ILineAccess {

        public LineServiceAccess() : base(ConfigurationManager.AppSettings.Get("ServiceUrlToUse")) {
        }

        public async Task<IEnumerable<Line>?> GetLines(string? sortParam, int id = -1) {
            IEnumerable<Line>? listFromService = null;

            // api/shapes/lines/id
            UseUrl = BaseUrl;
            UseUrl += "lines";
            bool hasValidId = (id > 0);
            if (hasValidId) {
                UseUrl += "/" + id.ToString();
            } else {
                bool hasSortParam = ((sortParam != null) && (!sortParam.ToLower().Equals("none")));
                if (hasSortParam) {
                    UseUrl += "?sortBy=" + sortParam;
                }
            }

            try {
                var serviceResponse = await CallServiceGet();
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                    var content = await serviceResponse.Content.ReadAsStringAsync();
                    if (hasValidId) {
                        Line? foundCoord = JsonConvert.DeserializeObject<Line>(content);
                        if (foundCoord != null) {
                            listFromService = new List<Line>() { foundCoord };
                        }
                    } else {
                        listFromService = JsonConvert.DeserializeObject<List<Line>>(content);
                    }
                } else {
                    if (wasResponse && serviceResponse != null && serviceResponse.StatusCode == System.Net.HttpStatusCode.NotFound) {
                        listFromService = new List<Line>();
                    } else {
                        listFromService = null;
                    }
                }
            }
            catch {
                listFromService = null;
            }

            return listFromService;
        }

        public async Task<bool> SaveCoords(List<Coordinate> item) {
            bool savedOk = false;

            UseUrl = BaseUrl;
            UseUrl += "lines";

            try {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                    savedOk = true;
                }
            }
            catch {
                savedOk = false;
            }

            return savedOk;
        }

    }//ends class
}
