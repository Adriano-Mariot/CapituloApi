using CapituloApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapituloApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _iLivroRepository;

        public LivroController(ILivroRepository iLivroRepository)
        {
            _iLivroRepository = iLivroRepository;
        }
        [HttpGet]
        public IActionResult Listar() 
        {
            try 
            {
                return Ok(_iLivroRepository.ler());
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }
    }
}
