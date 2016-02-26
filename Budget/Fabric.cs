using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Fabric
    {
        private Articles m_articles = new Articles();

        public Articles GetArticles()
        {
            return m_articles;
        }
    }
}
