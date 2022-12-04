using AutoMapper;
using FitDailyLife.Entities;
using FitDailyLife.Models;

namespace FitDailyLife
{
    public class FitDailyLifeMappingProfile :Profile
    {
        public FitDailyLifeMappingProfile()
        {
            CreateMap<BodyParameters, BodyWeightDto>();
            CreateMap<BodyParameters, MeasureDetailsDto>();

        }
    }
}
