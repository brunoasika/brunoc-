using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
        interface Iuser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);

    }
    
    interface Iloggger
    {
        void LogError(string error);
    }
    interface Iemail
    {
        bool sendemail(string emailcontent);
    }
}
