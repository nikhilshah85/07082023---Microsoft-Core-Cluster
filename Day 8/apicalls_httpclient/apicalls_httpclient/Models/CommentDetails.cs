using System.ComponentModel;

namespace apicalls_httpclient.Models
{
    public class CommentDetails
    {

        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        List<CommentDetails> commentsList = new List<CommentDetails>(); //this is where the data will be captured

        public List<CommentDetails> GetComments()
        {

            string url = "https://jsonplaceholder.typicode.com/comments";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear(); //clear the default format of data, we will set it to Json
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url).Result;


            //if call is successful, we will read the data else throw an exception
            if (call.IsSuccessStatusCode)
            {
                var data = call.Content.ReadAsAsync<List<CommentDetails>>();
                data.Wait();
                commentsList = data.Result;
                return commentsList;
            }
            else
            {
                throw new Exception("Sorry could not get data, pleaes contact admin");
            }

        }
    }
}



