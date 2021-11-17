using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static NewsEntities db;

        static CategoryRepo()
        {
            db = new NewsEntities();
        }

        public static void AddCategory(Category c)
        {
            db.Categorys.Add(c);
            db.SaveChanges();
        }

        public static List<Category> GetAllCategory()
        {
            return db.Categorys.ToList();
        }

        public static Category GetCategoryById(int id)
        {
            return db.Categorys.FirstOrDefault(n => n.Id == id);
        }

        public static void EditCategory(Category ns)
        {
            var category = db.Categorys.FirstOrDefault(n => n.Id == ns.Id);
            db.Entry(category).CurrentValues.SetValues(ns);
            db.SaveChanges();
        }

        public static void DeleteCategory(int id)
        {
            var category = db.Categorys.FirstOrDefault(n => n.Id == id);
            db.Categorys.Remove(category);
            db.SaveChanges();
        }

    }
}
