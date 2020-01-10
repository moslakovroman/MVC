using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface IHomeService
    {
        string GetIndexData();
        string GetContactData();
    }
}
