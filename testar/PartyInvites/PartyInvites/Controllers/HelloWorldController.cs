using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Esta é a minha açao padrao";
        } 
        public string Bem vinda()
        {
            return " metodu de ação bem vinda"
        }
    }
}