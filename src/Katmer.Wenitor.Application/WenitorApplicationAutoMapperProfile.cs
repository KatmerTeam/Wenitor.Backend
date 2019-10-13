using AutoMapper;

namespace Katmer.Wenitor
{
    public class WenitorApplicationAutoMapperProfile : Profile
    {
        public WenitorApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Alert, AlertDTO>();
            CreateMap<ScheduleCheck, ScheduleCheckDTO>();
            CreateMap<TargetSelector, TargetSelectorDTO>();
            CreateMap<TargetSource, TargetSourceDTO>();
        }
    }
}
