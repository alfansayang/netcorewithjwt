using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApps.Models;

namespace WebApps.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<UserModel> _users;
        
        public EmployeeRepository()
        {
            _users = new List<UserModel>()
            {
                new UserModel (){DateOfJoin = DateTime.Now, Email="zahgreat330@gmail.com",Password="iseng30", Username="alfanzah"},
                new UserModel (){DateOfJoin = DateTime.Now, Email="alfanzah@gmail.com",Password="iseng30", Username="arinzah"}
            };
        }

        public List<UserModel> GerUsers()
        {
            return _users;
        }
    }
}
