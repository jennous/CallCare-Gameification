using CallCare_Gameification_FE.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace CallCare_Gameification_FE.Classes
{
    public class Users
    {
        public Users()
        {

        }

        public async Task<User> getUserDetails(int id)
        {
            using var httpClient = new HttpClient();
            try
            {
                // URL of the API
                string apiUrl = "https://localhost:7198/User/" + id;

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();

                    if (data != null)
                    {
                        var user = JsonConvert.DeserializeObject<User>(data);
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
