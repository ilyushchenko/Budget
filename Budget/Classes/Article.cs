using System;
using System.IO;

namespace Budget
{
    public class Article
    {
        private DateTime m_date;
        private string m_Category;
        private string m_NameArt;
        private decimal m_PriceArt;
        private int m_AmountArt;
        private string m_CommentArt;
        private bool m_Isincome;

        public Article(DateTime date, string name, decimal price, int amount, string comment, bool isincome)
        {
            m_date = date;
            m_NameArt = name;
            m_PriceArt = price;
            m_AmountArt = amount;
            m_CommentArt = comment;
            m_Isincome = isincome;
        }

        public Article(){}
        
        public DateTime Date
        {
            get { return m_date; }
        }
        public string Category
        {
            get { return m_Category; }
            set { m_Category = value; }
        }
        public string NameArt
        {
            get { return m_NameArt; }
        }
        public string CommentAtr
        {
            get { return m_CommentArt; }
        }
        public decimal PriceArt
        {
            get { return m_PriceArt; }
        }
        public int AmountArt
        {
            get { return m_AmountArt; }
        }
        public bool IsIncome
        {
            get { return m_Isincome; }
        }

        public void Save(StreamWriter sw)
        {
            sw.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}", m_date, m_Category, m_NameArt, m_PriceArt, m_AmountArt, m_CommentArt, m_Isincome);
        }

        public void Load(StreamReader sr)
        {
            string[] data = sr.ReadLine().Split('#');
            m_date = DateTime.Parse(data[0]);
            m_Category = data[1];
            m_NameArt = data[2];
            m_PriceArt = decimal.Parse(data[3]);
            m_AmountArt = int.Parse(data[4]);
            m_CommentArt = data[5];
            m_Isincome = bool.Parse(data[6]);
        }
    }
}