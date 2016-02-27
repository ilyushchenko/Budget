using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget
{
    public class Categories
    {
        public Categories()
        {
            LoadCategory();
        } 
        List<string> m_categories = new List<string>();

        public void LoadCategory()
        {
            using(StreamReader sr = new StreamReader("categories.txt"))
            {
                while (!sr.EndOfStream)
                {
                    m_categories.Add(sr.ReadLine());
                }
            }
        }
        public List<string> GetCategoryToFrm()
        {
            return m_categories;
        }

        public void RemoveCategory(int ctg)
        {
            m_categories.RemoveAt(ctg);
        }

        public void AddCategory(string ctg)
        {
            m_categories.Add(ctg);
        }

        public void EditCategory(int index, string nameArt)
        {
            m_categories.Insert(index, nameArt);
        }
        public void SaveCtg()
        {
            using (StreamWriter sw = new StreamWriter("categories.txt"))
            {
                foreach (var category in m_categories)
                {
                    sw.WriteLine(category);
                }
            }
        }
    }
}
