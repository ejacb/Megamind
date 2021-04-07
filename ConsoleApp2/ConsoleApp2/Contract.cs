using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface Contract
    {
        IEnumerable<User> FindAll();
        User FindbyId(User u);
        void Create();
        void Update(User u);
        void Delete(User u);
    }
}

