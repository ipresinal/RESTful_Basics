using System;
using Domain.Common;

namespace Domain.Entities
{
    public class Client : AuditableBaseEntity
    {
        private int _age;

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int Age {
            get
            {
                if (this._age <= 0)
                {
                    _age = new DateTime(DateTime.Now.Subtract(DateOfBirth).Ticks).Year - 1;
                }

                return _age;
            }
        }
    }
}
