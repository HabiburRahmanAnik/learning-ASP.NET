using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    public class CategoryServices
    {
        public static List<CategoryModel> Get()
        {
            var config = new MapperConfiguration(c =>
                c.CreateMap<Category, CategoryModel>()
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CategoryModel>>(CategoryRepo.GetAllCategory());

            return data;
        }


        public static void Add(CategoryModel c)
        {
            var config = new MapperConfiguration(cs => cs.CreateMap<CategoryModel, Category>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(c);
            CategoryRepo.AddCategory(data);
        }

        public static void Delete(int id)
        {
            CategoryRepo.DeleteCategory(id);
        }
    }
}
