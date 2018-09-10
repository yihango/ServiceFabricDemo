using Abp.AutoMapper;
using ABP_CORE_MPA.Authentication.External;

namespace ABP_CORE_MPA.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
