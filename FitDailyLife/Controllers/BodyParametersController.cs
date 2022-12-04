using AutoMapper;
using FitDailyLife.Entities;
using FitDailyLife.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FitDailyLife.Controllers
{
    [Route("api/bodyparameters")]
    public class BodyParametersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbcontext;

        public BodyParametersController(AppDbContext dbcontext, IMapper mapper)
        {
            _mapper = mapper;
            _dbcontext = dbcontext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<BodyParameters>> GetMeasures()
        {
            var bodyparameters = _dbcontext
                .BodyParameters
                .ToList();
            var bodyparametersDtos = _mapper.Map<List<BodyWeightDto>>(bodyparameters);
            return Ok(bodyparametersDtos);
        }
        [HttpGet("{id}")]
        public ActionResult<BodyParameters> GetMeasuresById([FromRoute] int id)
        {
            var bodyparameter = _dbcontext
                .BodyParameters
                .FirstOrDefault(x => x.Id == id);
            if(bodyparameter is null)
            {
                return NotFound();
            }
            var bodyparameterDto = _mapper.Map<MeasureDetailsDto>(bodyparameter);
            return Ok(bodyparameterDto);
        }

    }
}
