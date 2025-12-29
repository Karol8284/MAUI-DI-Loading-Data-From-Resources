using MAUI_DI_Loading_Data_From_Resources.Shared.Services;

namespace MAUI_DI_Loading_Data_From_Resources.Web.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "Web";
        }

        public string GetPlatform()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
