using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BrandEntity
    {
        private string _name;
        public int? Id { get; private set; } //INT? tipo nulleable
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) //NO ESTE VACIO, NO ESPACIO, NO NULL
                {
                    throw new ArgumentException("Name cannot be null or empty.", nameof(value));
                }
                _name = value;
            }
        }
        public BrandEntity(string name) //SOLO NOMBRE
        {
            Name = name;
        }
        public BrandEntity(int? id, string name)
        {
            if(id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id debe ser positivo. ");
            }
            Id = id;
            Name = name;
        }
 
    }
}
