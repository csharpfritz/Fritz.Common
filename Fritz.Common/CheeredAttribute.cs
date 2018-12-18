using System;

//[Cheered(100, "someone", 2018, 12, 10)]
namespace Fritz.Common
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class CheeredAttribute : Attribute
    {
        private int bits;
        private string name;
        private int year, month, day;

        public CheeredAttribute(int bits, string name, int year, int month, int day)
        {
            this.bits = bits;
            this.name = name;
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public virtual int Bits { get { return bits; } }
        public virtual string Name { get { return name; } }

        public virtual DateTime CheeredOn
        {
            get
            {
                return new DateTime(year, month, day);
            }
        }
    }
}