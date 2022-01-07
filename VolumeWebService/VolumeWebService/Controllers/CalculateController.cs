using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolumeWebService.Data;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController:ControllerBase
    {
        private readonly IVolumeResultService calculaor;

        public CalculateController(IVolumeResultService calculaor)
        {
            this.calculaor = calculaor;
        }

        [HttpGet]
        public async Task<ActionResult<IList<VolumeResult>>> GetResults()
        {
            try
            {
                IList<VolumeResult> results = await calculaor.GetResultsAsync();
                return Ok(results);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("cylinder")]
        public async Task<ActionResult<double>> CalculateVolumeCylinder([FromQuery]double height,[FromQuery]double radius)
        {
            try
            {
                var result = calculaor.CalculateVolumeCylinder(height,radius);
                VolumeResult added = new VolumeResult();
                added.height = height;
                added.radius = radius;
                added.volume = result.Result;
                added.type = "Cylinder";
                calculaor.AddResultAsync(added);
                Console.WriteLine(result);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet("cone")]
        public async Task<ActionResult<double>> CalculateVolumeCone([FromQuery]double height,[FromQuery]double radius)
        {
            try
            {
                var result = calculaor.CalculateVolumeCone(height, radius);
                VolumeResult added = new VolumeResult();
                added.height = height;
                added.radius = radius;
                added.volume = result.Result;
                added.type = "Cone";
                calculaor.AddResultAsync(added);
                Console.WriteLine(result);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteResult([FromQuery] int id)
        {
            try
            {
                await calculaor.RemoveVolumeResultAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

    }
}