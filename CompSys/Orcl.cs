using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompSys
{
    [Serializable()]
    class Orcl
    {
        public string dataSource;
        public string username;
        public string password;

        public Orcl()
        {
            this.dataSource = "Oracle";
            this.username = "t00152975";
            this.password = "empty";
        }

        public Orcl(string dataSource, string username, string password)
        {
            setDataSource(dataSource);
            setUsername(username);
            setPassword(password);
        }

        public void setDataSource(string dataSource)
        {
            this.dataSource = dataSource;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
