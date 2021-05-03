﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    interface ICategoryDal
    {
        List<Category> List();

        void Insert(Category p);
        void Update(Category p);
        void Delet(Category p);


    }
}
    