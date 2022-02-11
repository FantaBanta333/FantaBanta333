using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        #region Fields
        private int _capacity = 0;
        private List<FantasyWeapon> _items = new List<FantasyWeapon>();
        #endregion

        #region Properties
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                if (value > 0)
                    _capacity = value;
            }
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }


        #endregion

        #region Constructors
        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            Capacity = capacity;
            Items = items.ToList();//clone the list
        }
        #endregion

        #region Methods
        public void AddItem(FantasyWeapon item)
        {
            if(_capacity > _items.Count)//do I have space?
                _items.Add(item);
            else
                throw new Exception("Inventory is full.");
        }

        public void PrintInventory()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                FantasyWeapon fw = _items[i];
                Console.WriteLine($"Rarity: {fw.Rarity} Level: {fw.Level} Max Damage: {fw.MaxDamage} Cost: {fw.Cost}");
                if(fw is BowWeapon bow)//downcasting
                    Console.WriteLine($"Arrow Capacity: {bow.ArrowCapacity} Arrow Count: {bow.ArrowCount}");

                Console.WriteLine();
            }
        }
        #endregion
    }
}
