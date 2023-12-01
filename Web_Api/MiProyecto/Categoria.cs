[Authorize]
public class ProductosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Crear()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Crear(Producto producto)
    {
        return RedirectToAction("Index");
    }

}
