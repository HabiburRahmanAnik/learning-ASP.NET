using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class NewsServices
    {
        public static List<NewsModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<Category, CategoryModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(NewsRepo.GetAllNews());

            return data;
        }

        public static void Edit(NewsModel n)
        {
            var config = new MapperConfiguration(c => c.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            NewsRepo.EditNews(data);
        }


        public static void Add(NewsModel n)
        {
            var config = new MapperConfiguration(c => c.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            NewsRepo.AddNews(data);
        }

        public static void Delete(int id)
        {
            NewsRepo.DeleteNews(id);
        }
    }
}
