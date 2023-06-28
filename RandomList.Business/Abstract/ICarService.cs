using RandomList.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList.Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void AddUnique(Car car);
        void Delete(Car car);
        List<Car> GetAll();
    }
}
