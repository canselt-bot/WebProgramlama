using BussinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryMAnager : ICategoryService
    {
        EfCategoryRepository efCatRep;

        public CategoryMAnager()
        {
            efCatRep = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCatRep.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            efCatRep.Delete(category);  
        }

        public void CategoryUpdate(Category category)
        {
            efCatRep.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return efCatRep.GetListAll();
        }

        public Category GetById(int id)
        {
            return efCatRep.GetByID(id);
        }
    }
}
