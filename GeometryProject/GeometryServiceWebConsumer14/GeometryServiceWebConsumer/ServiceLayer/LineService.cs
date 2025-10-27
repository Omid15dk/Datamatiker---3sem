using GeometryServiceWebConsumer.Models;
using Newtonsoft.Json;
using System.Text;

namespace GeometryServiceWebConsumer.ServiceLayer {
    public class LineService : ServiceConnection, ILineAccess {

        public LineService(IConfiguration inConfiguration) : base(inConfiguration["ServiceUrlToUse"]) {
        }

        public string? UseServiceUrl { get; set; }

        public async Task<IEnumerable<Line>?> GetLines(string? sortParam, int id = -1) {
            List<Line>? listFromService = null;

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
                            listFromService = [ foundCoord ];
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
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                    savedOk = true;
                }
            }
            catch {
                savedOk = false;
            }

            return savedOk;
        }

        public async Task<bool> UpdateLine(LineToPost item) {
            bool updatedOk = false;

            UseUrl = BaseUrl;
            UseUrl += "lines";
            UseUrl += "/" + item.Id;


            try {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await CallServicePut(content);
                bool wasResponse = (serviceResponse != null);
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                    updatedOk = true;
                }
            }
            catch {
                updatedOk = false;
            }

            return updatedOk;
        }

        public async Task<bool> DeleteLine(int delId) {
            bool deletedOk = false;

            UseUrl = BaseUrl;
            UseUrl += "lines/" + delId;

            try {
                var serviceResponse = await CallServiceDelete();
                bool wasResponse = (serviceResponse != null);
                if (serviceResponse != null && serviceResponse.IsSuccessStatusCode) {
                    deletedOk = true;
                }
            }
            catch {
                deletedOk = false;
            }

            return deletedOk;
        }

    }//ends class
}
