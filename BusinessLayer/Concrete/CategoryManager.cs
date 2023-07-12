using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService

    {
        ECategoryRepository ECategoryRepository;


        public CategoryManager() 
        {
            ECategoryRepository = new ECategoryRepository();
        
        }



        GenericRepositories<Category> repo = new GenericRepositories<Category>();

        public void CategoryAdd(Category category)
        {
            ECategoryRepository.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            ECategoryRepository.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            ECategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return ECategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return ECategoryRepository.GetListAll();
        }
    }
}
