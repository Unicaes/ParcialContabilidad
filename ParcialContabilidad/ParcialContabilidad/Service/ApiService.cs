using Newtonsoft.Json;
using ParcialContabilidad.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParcialContabilidad.Service
{
    public class ApiService
    {
        private const String url = "http://contabilidadapi.azurewebsites.net/api/";
        private static HttpClient cliente = new HttpClient();
        public static async Task<Response> GetAll<T>(String Controller)
        {
            try
            {
                var response = await cliente.GetAsync(url + Controller);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = JsonConvert.DeserializeObject<Response>(await response.Content.ReadAsStringAsync()).Message
                    };
                }

                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<ObservableCollection<T>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = list
                };
            }
            catch (Exception e)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = $"Error al cargar los datos {e}"
                };
            }
        }
        public static async Task<Response> Post<T>(string controller, T item)
        {
            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await cliente.PostAsync($"{url}{controller}", content);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response()
                    {
                        Message = JsonConvert.DeserializeObject<Response>(await response.Content.ReadAsStringAsync()).Message,
                        IsSuccess = false
                    };
                }
                return new Response()
                {
                    IsSuccess = true,
                    Result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync())
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    IsSuccess = false,
                    Message = "Error Ex " + ex.Message
                };
            }
        }
        public static async Task<bool> Delete<T>(String controller, int id)
        {
            try
            {
                HttpResponseMessage response = await cliente.DeleteAsync(url + controller + "/" + id.ToString());
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static async Task<bool> Put<T>(String controller, object id, T item)
        {
            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await cliente.PutAsync(url + controller + "/" + id.ToString(), content);
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
