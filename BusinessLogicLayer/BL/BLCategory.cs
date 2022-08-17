using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using FacadeLayer.Dal;

namespace BusinessLogicLayer.BL
{
    public class BLCategory
    {
        public static List<EntityCategory> BLCategoryList()
        {
            return DalCategory.CategoryList();
        }
        public void BLCategoryAdd(EntityCategory entityCategory)
        {
            if(entityCategory.Categoryname!="" && entityCategory.Categoryname.Length<=30 && entityCategory.Categoryname.Length>=5)
            {
                DalCategory.AddCategory(entityCategory);
            }
            else
            {
                //hata
            }
        }


        public void BLCategoryDelete(int id)
        {
            if(id!=0)
            {
                DalCategory.DeleteCategory(id);
            }
            else
            {
                //hata mesajı
            }
        }


        public void BLCategoryUpdate(EntityCategory entityCategory)
        {
            if(entityCategory.Categoryname!="" && entityCategory.Categoryname.Length>=5)
            {
                DalCategory.UpdateCategory(entityCategory);
            }
        }
    }
}
