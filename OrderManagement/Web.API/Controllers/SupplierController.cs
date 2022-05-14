using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.SupplierDtos;
using Services.IServices;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _SupplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _SupplierService = supplierService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _SupplierService.GetSupplier();
            return Ok(suppliers);
        }

        [HttpGet()]
        public async Task<IActionResult> GetSupplier(int supplierId)
        {
            if (supplierId <= 0)
            {
                return BadRequest(
                    new ErrorResult()
                    {
                        Title = "Invalid Request",
                        ErrorMessage = "Invalid supplierId",
                        StatusCode = StatusCodes.Status400BadRequest
                    }
                );
            }
            var suppliers = await _SupplierService.GetSupplier(supplierId);

            if (suppliers == null)
            {
                return BadRequest(
                    new ErrorResult()
                    {
                        Title = "Invalid Request",
                        ErrorMessage = "Invalid supplierId",
                        StatusCode = StatusCodes.Status404NotFound
                    }
                );
            }
            return Ok(suppliers);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSupplierDto supplier)
        {
            if (ModelState.IsValid)
            {
                var result = await _SupplierService.CreateSupplier(supplier);
                return Ok(result);
            }
            else
            {
                return BadRequest(
                    new ErrorResult() { ErrorMessage = "Error while processing the request" }
                );
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateSupplierDto supplier)
        {
            if (ModelState.IsValid)
            {
                var result = await _SupplierService.UpdateSupplier(supplier);
                return Ok(result);
            }
            else
            {
                return BadRequest(
                    new ErrorResult() { ErrorMessage = "Error while processing the request" }
                );
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int supplierId)
        {
            if (ModelState.IsValid)
            {
                var result = await _SupplierService.DeleteSupplier(supplierId);
                return Ok(result);
            }
            else
            {
                return BadRequest(
                    new ErrorResult() { ErrorMessage = "Error while processing the request" }
                );
            }
        }
    }
}
