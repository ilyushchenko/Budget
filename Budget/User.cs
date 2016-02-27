using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class User
    {
        private string m_UserName = "345";
        private string m_Password = "123qwer";
        
        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }

        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }
    }
}
