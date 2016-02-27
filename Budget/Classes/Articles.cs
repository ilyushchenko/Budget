using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Budget
{
    public class Articles
    {
        private List<Article> m_articles = new List<Article>();

        public List<Article> ListArticles
        {
            get { return m_articles; }
            set { m_articles = value; }
        }

        public void LoadArticles(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    Article art = new Article();
                    art.Load(sr);
                    m_articles.Add(art);
                }
            }
        }
        public void GetAtrToDataGW(VisitDelegate visiter)
        {
            foreach (Article art in m_articles)
            {
                visiter(art);
            }
        }

        public void GetAtrToDataGW(VisitDelegate visiter, DateTime fromDate, DateTime toDate)
        {
            foreach (Article art in m_articles)
            {
                if (art.Date <= toDate && art.Date >= fromDate)
                {
                    visiter(art);
                }
            }
        }

        public delegate void VisitDelegate(Article article);

        public void SaveArticles(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var article in m_articles)
                {
                    article.Save(sw);
                }
            }
        }
        public void AddNewArticle(Article article)
        {
            m_articles.Add(article);
        }

        public decimal GetIncome(bool isIncome)
        {
            decimal sum = 0;
            foreach (Article article in m_articles)
            {
                if (article.IsIncome == isIncome)
                {
                    sum += article.PriceArt * article.AmountArt;
                }                
            }
            return sum;
        }
    }
}
