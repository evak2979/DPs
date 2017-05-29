using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Structural.Composite
{
    //Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects
    //uniformly
    public interface IItem
    {
        string Description { get; }
        int Cost { get; }
        void AddItem(IItem item);
        void RemoveItem(IItem item);
        IItem[] Items { get; }
    }

    public class Item : IItem
    {
        public string Description => string.Empty;
        public int Cost => 0;
        public void AddItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public IItem[] Items => new IItem[0];
    }

    public class Part : IItem
    {
        private readonly string _description;
        private readonly int _cost;

        public Part(string description, int cost)
        {
            _description = description;
            _cost = cost;
        }

        public string Description => _description;
        public int Cost => _cost;
        public void AddItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public IItem[] Items => new IItem[0];
    }

    public class Assembly : IItem
    {
        private readonly string _description;
        private IList<IItem> _items;

        public Assembly(string description)
        {
            _description = description;
            _items = new List<IItem>();
        }

        public string Description => _description;

        public int Cost => _items.Sum(x => x.Cost);

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
        }

        public IItem[] Items { get; }
    }
}
