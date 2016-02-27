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
                if (art.Date.Date <= toDate.Date && art.Date >= fromDate.Date)
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

        public void RemoveArticle(Article aricleToRemove)
        {
            foreach (Article article in m_articles)
            {
                if (article.Date.Date == aricleToRemove.Date &&
                    article.Category == aricleToRemove.Category &&
                    article.NameArt == aricleToRemove.NameArt &&
                    article.CommentAtr == aricleToRemove.CommentAtr &&
                    article.PriceArt == aricleToRemove.PriceArt &&
                    article.AmountArt == aricleToRemove.AmountArt &&
                    article.IsIncome == aricleToRemove.IsIncome)
                {
                    m_articles.Remove(article);
                    break;
                }
            }
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

        public decimal GetIncome(bool isIncome, DateTime fromDate, DateTime toDate)
        {
            decimal sum = 0;
            foreach (Article article in m_articles)
            {
                if (article.IsIncome == isIncome && article.Date.Date <= toDate.Date && article.Date >= fromDate.Date)
                {
                    sum += article.PriceArt * article.AmountArt;
                }
            }
            return sum;
        }
    }
}
