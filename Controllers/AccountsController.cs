#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepositoryWithMVC.Data;
using RepositoryWithMVC.Data.BLL;
using RepositoryWithMVC.Models;

namespace RepositoryWithMVC.Controllers
{
    public class AccountsController : Controller
    {
        private AccountBusinessLogic accountBL;
        public AccountsController(RepositoryWithMVCContext context)
        {
            accountBL = new AccountBusinessLogic(new AccountRepository(context));
        }

        public IActionResult Index()
        {
            return View(accountBL.GetAll());
        }
       
    }
}
