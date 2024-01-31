using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(string id);
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(string id);
    }
}
