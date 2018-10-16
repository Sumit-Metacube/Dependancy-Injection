using Services;
using System.Web.Mvc;

namespace DI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _iCustomerService;

        // Constructor injection
        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        // Property injection
        public ICustomerService Service
        {
            set { this._iCustomerService = value; }
        }

        //Method injection
        public void Start(ICustomerService service)
        {
            service.GetCustomers();
        }
        public ActionResult Index()
        {
            return View(_iCustomerService.GetCustomers());
        }
    }
}