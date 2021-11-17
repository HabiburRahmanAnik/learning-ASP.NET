using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo
    {
        static NewsEntities db;

        static NewsRepo()
        {
            db = new NewsEntities();
        }

        public static void AddNews(News n)
        {
            db.News.Add(n);
            db.SaveChanges();
        }

        public static List<News> GetAllNews()
        {
            return db.News.ToList();
        }

        public static News GetNewsById(int id)
        {
            return db.News.FirstOrDefault(n => n.Id == id);
        }

        public static void EditNews(News ns)
        {
            var news = db.News.FirstOrDefault(n => n.Id == ns.Id);
            db.Entry(news).CurrentValues.SetValues(ns);
        }

        public static void DeleteNews(int id)
        {
            var news = db.News.FirstOrDefault(n => n.Id == id);
            db.News.Remove(news);
        }

    }
}
