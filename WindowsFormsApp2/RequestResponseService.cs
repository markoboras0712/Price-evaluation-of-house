using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace WindowsFormsApp2
{
    class RequestResponseService
    {
        public void StartPricePrediction(House house)
        {
            _ = InvokeRequestResponseService(house);
        }
        

        static async Task InvokeRequestResponseService(House house)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "price", "1"
                                            },
                                            {
                                                "bedrooms", house.Bedrooms
                                            },
                                            {
                                                "bathrooms", house.Bathrooms
                                            },
                                            {
                                                "sqft_living", house.Sqft_living
                                            },
                                            {
                                                "sqft_lot", house.Sqft_lot
                                            },
                                            {
                                                "floors", house.Floors
                                            },
                                            {
                                                "waterfront", house.Waterfront
                                            },
                                            {
                                                "view", house.View
                                            },
                                            {
                                                "condition", house.Condition
                                            },
                                            {
                                                "grade", house.Grade
                                            },
                                            {
                                                "yr_built", house.Yr_built
                                            },
                                            {
                                                "yr_renovated", house.Yr_renovated
                                            },
                                            {
                                                "zipcode", house.Zipcode
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                const string apiKey = "9jS8Lgc+8g0UNf886WO8Km2jBiYS13Z32D/5M+utbj1EqQSYE4nfZkxtnU83eg2aLrrItNGsCRKrCf0uolbWvA=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/2dc5c18b22ff421b8b141fb276f2a4dd/services/09a65523b7dc4f6c9740c7943f81c011/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic json =  JsonConvert.DeserializeObject(result);
                    MessageBox.Show("Estimated value of the house is \n" + "$ " +  json.Results.output1[0]["Scored Labels"] );
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp,
                    // which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }

        
    }
}

