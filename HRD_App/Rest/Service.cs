using HRD_App.Errors;
using HRD_App.Utils;
using HRD_DataLibrary.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest
{
    public class Service<T> : IService<T>
    {
        private string name;
        private HttpClient httpClient;
        private Dictionary<string, string> args;

        public Service(string name, HttpClient httpClient, Dictionary<string, string> args)
        {
            this.name = name;
            this.httpClient = httpClient;
            this.args = args;
        }

        public async Task<List<T>> GetAll(bool deleted)
        {
            Dictionary<string, string> args = new Dictionary<string, string>(this.args);
            args.Add("deleted", deleted.ToString());

            HttpResponseMessage response = await httpClient.GetAsync(name + "?" + UrlArgsUtil.makeArgs(args));

            return (response.IsSuccessStatusCode)
                ? await response.Content.ReadAsAsync<List<T>>()
                : throw ApiException.Create(await response.Content.ReadAsAsync<ErrorType>());
        }

        public async Task<T> Delete(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(name + "/" + id + "?" + UrlArgsUtil.makeArgs(args));

            return (response.IsSuccessStatusCode)
                ? await response.Content.ReadAsAsync<T>()
                : throw ApiException.Create(await response.Content.ReadAsAsync<ErrorType>());
        }

        public async Task<T> Get(int id)
        {
            HttpResponseMessage response = await httpClient.GetAsync(name + "/" + id + "?" + UrlArgsUtil.makeArgs(args));

            return (response.IsSuccessStatusCode)
                ? await response.Content.ReadAsAsync<T>()
                : throw ApiException.Create(await response.Content.ReadAsAsync<ErrorType>());
        }

        public async Task<T> Add(T item)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync(name + "?" + UrlArgsUtil.makeArgs(args), item);

            return (response.IsSuccessStatusCode)
                 ? await response.Content.ReadAsAsync<T>()
                 : throw ApiException.Create(await response.Content.ReadAsAsync<ErrorType>());
        }

        public async Task Update(int id, T item)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync(name + "/" + id + "?" + UrlArgsUtil.makeArgs(args), item);

            if (!response.IsSuccessStatusCode)
                throw ApiException.Create(await response.Content.ReadAsAsync<ErrorType>());
        }
    }
}
