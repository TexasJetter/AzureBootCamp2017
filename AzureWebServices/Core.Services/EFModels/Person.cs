using System;
using System.Collections.Generic;

namespace Core.Services.EFModels
{
    public partial class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid? PersonTypeId { get; set; }

        public virtual PersonType PersonType { get; set; }
    }
}
