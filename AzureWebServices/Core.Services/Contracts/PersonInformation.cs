<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PersonService.Contracts
{
    [DataContract]
    public class PersonListInformation
    {
        [DataMember(IsRequired = true)] public Guid Id { get; set; }
        [DataMember(IsRequired = true)] public string Name { get; set; }
        [DataMember(IsRequired = true)] public string Email { get; set; }
        [DataMember(IsRequired = true)] public string Phone { get; set; }
        [DataMember(IsRequired = true)] public string PersonType { get; set; }
    }

    [DataContract]
    public class PersonDetailInformation
    {
        [DataMember(IsRequired = true)] public Guid Id { get; set; }
        [DataMember(IsRequired = true)] public string FirstName { get; set; }
        [DataMember(IsRequired = true)] public string LastName { get; set; }
        [DataMember(IsRequired = true)] public string Email { get; set; }
        [DataMember(IsRequired = true)] public string Phone { get; set; }
        [DataMember(IsRequired = true)] public Guid PersonTypeId { get; set; }
    }

    [DataContract]
    public class PersonTypeInformation
    {
        [DataMember(IsRequired = true)] public Guid Id { get; set; }
        [DataMember(IsRequired = true)] public string Description { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PersonService.Contracts
{
    [DataContract]
    public class PersonListInformation
    {
        [DataMember(IsRequired = true)] public Guid Id { get; set; }
        [DataMember(IsRequired = true)] public string Name { get; set; }
        [DataMember(IsRequired = true)] public string Email { get; set; }
        [DataMember(IsRequired = true)] public string Phone { get; set; }
        [DataMember(IsRequired = true)] public string PersonType { get; set; }
    }

    [DataContract]
    public class PersonDetailInformation
    {
        [DataMember(IsRequired = true)] public Guid Id { get; set; }
        [DataMember(IsRequired = true)] public string FirstName { get; set; }
        [DataMember(IsRequired = true)] public string LastName { get; set; }
        [DataMember(IsRequired = true)] public string Email { get; set; }
        [DataMember(IsRequired = true)] public string Phone { get; set; }
        [DataMember(IsRequired = true)] public Guid PersonTypeId { get; set; }
    }

    [DataContract]
    public class PersonTypeInformation
    {
        [DataMember(IsRequired = true)] public Guid Id { get; set; }
        [DataMember(IsRequired = true)] public string Description { get; set; }
    }
}
>>>>>>> 744737003b437ddbd924bd4a4a0f3885ec50bce9
