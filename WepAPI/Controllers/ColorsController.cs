using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColor_Service _color_Service;

        public ColorsController(IColor_Service color_Service )
        {
            this._color_Service = color_Service;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _color_Service.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpPost("add")]
        public IActionResult Add(Color_ color)
        {
            var result = _color_Service.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpPost("update")]
        public IActionResult Update(Color_ color)
        {
            var result = _color_Service.Update (color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpPost("delete")]
        public IActionResult Delete(Color_ color)
        {
            var result = _color_Service.Deleted(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {

            var result = _color_Service.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
    }
}
