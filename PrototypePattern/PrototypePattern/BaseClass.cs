using System;

namespace PrototypePattern
{
    abstract class BaseClass
    {
        protected int Id;

        public BaseClass(int id)
        {
            Id = id;
        }

        public void GetId()
        {
            Console.WriteLine("Создан объект с ID " + Id);
        }

        abstract public BaseClass Clone();
    }
}