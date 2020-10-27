using pms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pms.Interface
{
   public interface Ilogin // created interface
    {
        string signin(Personal personal); //creating interface signin method having return type and receiving parameter type of personal..defined in login service
    }
}
