using System;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Face
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://" + textBox1.Text + "/action/SearchPersonList");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"operator\": \"SearchPersonList\",\r\n     \"info\": \r\n     { \r\n        \"PersonType\": \"0\",\r\n        \"Picture\":1\r\n     }\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            textBox2.Text = response.Content;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://" + textBox1.Text + "/action/SearchPerson");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"operator\": \"SearchPerson\",\r\n    \"info\":\r\n    {\r\n        \"SearchType\":2,\r\n        \"SearchID\":\"" + textBox3.Text + "\",\r\n        \"Picture\":1\r\n    }\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            textBox2.Text = response.Content;
            JObject jObject = JObject.Parse(response.Content);
            Console.WriteLine(jObject.ToString());

        }

    }
}
