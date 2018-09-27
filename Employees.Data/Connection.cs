using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Employees.Data
{
    public class Connection
    {
        HttpClient client = new HttpClient();

        public async Task<string> getEmployees(int id = 0)
        {
            var uri = new Uri(string.Format("http://masglobaltestapi.azurewebsites.net/api/Employees", string.Empty));
            var response = await client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }
    }
}
