using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAPI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClick_Button(object sender, EventArgs e)
        {
            string url = "https://apiexterno.simpress.com.br/camadadeservico/infraestrutura/v1/mobileinfo/358506071558179";
            //string url = "http://integracao_servicos.simpress.com.br/API/MobileInfo/v1/imei/358506071558179";

            try
            {
                var httpClient = new HttpClient();
                httpClient.MaxResponseContentBufferSize = 2147483647;
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("app_token","hHEFLrDNHk4L");
                httpClient.DefaultRequestHeaders.Add("client_id", "qer6ZJM3cfn6");
                Task<string> downloadTask = httpClient.GetStringAsync(url);
                string content = await downloadTask;

                await DisplayAlert("Evento", content, "Ok");
            }
            catch (Exception ex)
            {
                throw ex;
            }

       
        }

    }
}
