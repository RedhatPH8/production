using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SIMPL.Models;

namespace SIMPL.Controllers
{
    public class AdminUsersController : Controller
    {
        private UserManager<AspNetUsers> userManager;

        public AdminUsersController(UserManager<AspNetUsers> usrMgr)
        {
            userManager = usrMgr;
        }
        public ViewResult Index() => View(userManager.Users);
    }
}