using Abp.MultiTenancy;
using ABP_CORE_MPA.Authorization.Users;

namespace ABP_CORE_MPA.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
