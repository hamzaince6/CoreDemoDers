﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IBlogService
    {
        void BlogAdd(Blog blog);

        void BlogyDelete(Blog blog);

        void BlogUpdate(Blog blog);

        List<Blog> GetList();

        Blog GetById(int id);

        List<Blog> GetBlogListWithCategory();
    }
}
