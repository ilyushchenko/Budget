
namespace Budget
{
    public class Fabric
    {
        private Articles m_articles = new Articles();

        private Categories m_categories = new Categories();

        public Articles GetArticles()
        {
            return m_articles;
        }

        public Categories GetCategories()
        {
            return m_categories;
        }
    }
}
