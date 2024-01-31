using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMenuImageService
    {
        IDataResult<List<MenuImage>> GetAll();
        IDataResult<MenuImage> GetById(String id);

    }
}
