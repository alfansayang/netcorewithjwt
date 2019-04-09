using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApps.Models;

namespace WebApps.Repository
{
    public interface  IEmployeeRepository
    {
        List<UserModel> GerUsers();
    }
}
