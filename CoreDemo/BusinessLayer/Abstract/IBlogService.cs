using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {

        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogByWriter(int id);
        List<Blog> GetLast3Blog();
        List<Blog> GetBlogById(int id);
        public List<Blog> GetListByCategoryWriterBM(int id);
    }
}
