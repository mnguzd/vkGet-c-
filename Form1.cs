using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VKgetter
{
    public partial class Form1 : Form
    {
        const string ServiceKey = "0f6157a20f6157a20f6157a2770f0e069300f610f6157a2514d9ff41e76ca2d8a3413ad";
        string query = "https://api.vk.com/method/METHOD_NAME?PARAMETERS&access_token=ACCESS_TOKEN&v=V";
        string query2;
        public Form1()
        {
            InitializeComponent();
            WebClient wc = new WebClient();
            string id = wc.DownloadString("https://vk.com/mnguzd");
            Match math = Regex.Match(id, "");
            label1.Text = math.Groups[1].Value;
            label1.Text = id.Length.ToString();

        }
    }
}
