using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Repository : Contract
    {
        public IEnumerable<User> FindAll(){

            List<User> u = new List<User>();

            return u;
            
        }

        public User FindbyId(User u) {

            User user = new User();

            return user;

        }
        public void Create() 
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindAll(User u)
        {
            throw new NotImplementedException();
        }

        public void Update(User u)
        {
            throw new NotImplementedException();
        }

        public void Delete(User u)
        {
            throw new NotImplementedException();
        }
    }
}
