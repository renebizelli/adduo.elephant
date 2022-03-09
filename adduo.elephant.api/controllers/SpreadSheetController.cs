using adduo.elephant.domain.contracts.services;
using adduo.elephant.domain.requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace adduo.elephant.api.controllers
{
    [Route("v{version:apiVersion}/spreadsheet")]
    public class SpreadSheetController : BaseController
    {
        private readonly ISpreadSheetService service;

        public SpreadSheetController(ISpreadSheetService spreadSheetService)
        {
            this.service = spreadSheetService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] PeriodRequest request)
        {
            var spreadsheet = await service.GetAsync(request);

            return Ok(spreadsheet);
        }
    }
}
