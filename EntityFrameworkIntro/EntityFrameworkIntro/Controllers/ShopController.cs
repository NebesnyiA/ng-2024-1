using AutoMapper;
using BLL.Models.AddEntityModels;
using BLL.Models.UpdateEntityModel;
using BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkIntro.Controllers
{
    /// <summary>
    /// Game API.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;
        private readonly IMapper _mapper;

        public ShopController(IShopService shopService, IMapper mapper)
        {
            _shopService = shopService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var shops = await _shopService.GetAllAsync();
            return Ok(shops);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var shop = await _shopService.GetByIdAsync(id);
            return Ok(shop);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(SaveShopModel model)
        {
            var shop = await _shopService.AddAsync(model);
            return Ok(shop);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(UpdateShopModel model)
        {
            var shop = await _shopService.UpdateAsync(model);
            return Ok(shop);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _shopService.DeleteAsync(id);
            return NoContent();
        }
    }
}
