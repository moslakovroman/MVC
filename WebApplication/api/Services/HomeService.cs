using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.Interfaces;

namespace api.Services
{
    public class HomeService : IHomeService
    {
        public string GetIndexData()
        {
            return "Helo world!";
        }

        public string GetContactData()
        {
            return "Hz chto";
        }
    }
}
