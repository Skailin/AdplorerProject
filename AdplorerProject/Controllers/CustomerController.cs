using AdplorerProject.AdplorerAPIServiceReference;
using AdplorerProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdplorerProject.Controllers
{
    public class CustomerController : Controller
    {
        IServiceAPI _service = new ServiceAPI();

        // GET: Customer
        public ActionResult GetData()
        {
            CustomerDto[] customerData = _service.GetCustomersByQueryWS();

            return View(customerData);
        }
    }
}