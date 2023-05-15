using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;

namespace Project.CoreMVCUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryManager _catMan;
        public CategoryController(ICategoryManager catMan)
        {
            _catMan = catMan;
        }

    }
}
