using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Repo
{
    public class Repository<T>
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)
        {
            if(item == null)
            throw new ArgumentNullException(nameof(item));

            _items.Add(item);

        }

        public bool Remove(T item)
        {
            if(item == null)
               return false;

            return _items.Remove(item);
        }

        public IReadOnlyList<T> GetAll()
        {
            return _items.AsReadOnly();
        }
        public T? Find(Func<T, bool>predicate)
        {
            if(predicate == null)
              throw new ArgumentNullException(nameof(predicate));
            return _items.FirstOrDefault(predicate);


        }
        public int Count => _items.Count;
    }
}
