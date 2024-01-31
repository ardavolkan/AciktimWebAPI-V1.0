using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
        IResult UpDate(Order order);
        IResult Delete(string id);
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(string id);
        IDataResult<Order> GetByName(string name);
        IDataResult<Order> GetByDate(string orderDate);


    }
}
