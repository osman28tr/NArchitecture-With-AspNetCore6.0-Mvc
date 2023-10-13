using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Application.Features.Models.Queries.GetListModelByDynamic;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ModelsController : BaseController
	{
		[HttpGet]
		public async Task<ActionResult> GetList([FromQuery]PageRequest pageRequest)
		{
			GetListModelQuery getListModelQuery = new GetListModelQuery { PageRequest = pageRequest };
			ModelListModel modelListModel = await Mediator.Send(getListModelQuery);
			return Ok(modelListModel);
		}
		[HttpPost("GetList/ByDynamic")]
		public async Task<ActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest,[FromBody] Dynamic dynamic)
		{
			GetListModelByDynamicQuery getListByDynamicModelQuery = new GetListModelByDynamicQuery { PageRequest = pageRequest, Dynamic = dynamic };
			ModelListModel modelListModel = await Mediator.Send(getListByDynamicModelQuery);
			
			return Ok(modelListModel);
		}
	}
}
