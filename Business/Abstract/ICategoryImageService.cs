using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryImageService
    {
        IDataResult<List<CategoryImage>> GetAll();
        IDataResult<CategoryImage> GetById(String id);
    }
}
