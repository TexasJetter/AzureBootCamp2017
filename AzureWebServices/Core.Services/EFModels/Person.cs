<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 744737003b437ddbd924bd4a4a0f3885ec50bce9
