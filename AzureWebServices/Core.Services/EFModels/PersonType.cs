<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace Core.Services.EFModels
{
    public partial class PersonType
    {
        public PersonType()
        {
            Person = new HashSet<Person>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace Core.Services.EFModels
{
    public partial class PersonType
    {
        public PersonType()
        {
            Person = new HashSet<Person>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
>>>>>>> 744737003b437ddbd924bd4a4a0f3885ec50bce9
