using Microsoft.AspNetCore.Mvc;

namespace Oneiros.API.Controllers.Base
{
    public interface ICrudController
    {
        public Task<JsonResult> GetAll();
        public Task<JsonResult> Get(int id);
        public Task<IActionResult> Delete(int id);
        public Task<IActionResult> Update();
        public Task<IActionResult> Create();
    }
}
