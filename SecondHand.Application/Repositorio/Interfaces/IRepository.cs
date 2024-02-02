using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHand.Application.Repositorio.Interfaces
{
    public interface IRepository
    {
        IEnumerable<SecondHand> GetAll(Exception<Func<SecondHand, booll>>? filter = null, string? includeProperties = null);
        IEnumerable<SecondHand> Get(Exception<Func<SecondHand, booll>>? filter = null, string? includeProperties = null);

        void Add(SecondHand entity);

        void Update(SecondHand entity);

        void Remove(SecondHand entity);

        void Save();


    }

}
