using MAUI_DI_Loading_Data_From_Resources.Shared.Services;

namespace MAUI_DI_Loading_Data_From_Resources.Web.Client.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "WebAssembly";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
