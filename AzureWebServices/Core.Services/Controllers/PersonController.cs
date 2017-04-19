<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Net;
using System.Net.Http;
using PersonService.Contracts;
using Core.Services.EFModels;

namespace PersonService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        public List<PersonListInformation> GetPeopleList()
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    return context.Person
                        .OrderBy(p => p.FirstName)
                        .Select(p => new PersonListInformation
                        {
                            Id = p.Id,
                            Name = p.FirstName + " " + p.LastName,
                            Phone = p.Phone,
                            Email = p.Email,
                            PersonType = p.PersonType.Description
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }
        }

        [Route("Search/{searchText}")]
        [HttpGet]
        public List<PersonListInformation> SearchPeople(string searchText)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    return context.Person
                        .Where(p => p.FirstName.StartsWith(searchText)
                        || p.LastName.StartsWith(searchText)
                        || p.Email.StartsWith(searchText)
                        || p.Phone.StartsWith(searchText))
                        .OrderBy(p => p.FirstName)
                        .Select(p => new PersonListInformation
                        {
                            Id = p.Id,
                            Name = p.FirstName + " " + p.LastName,
                            Phone = p.Phone,
                            Email = p.Email,
                            PersonType = p.PersonType.Description
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }

        }

        [Route("PersonType")]
        [HttpGet]
        public List<PersonTypeInformation> GetPersonType(Guid id)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    return context.PersonType
                        .OrderBy(p => p.Description)
                        .Select(p => new PersonTypeInformation
                        {
                            Id = p.Id,
                            Description = p.Description
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }

        }

        [Route("Person/{id}")]
        [HttpGet]
        public PersonDetailInformation GetPerson(Guid id)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    var person = context.Person.FirstOrDefault(p => p.Id == id);
                    if (person == null)
                    {
                        return new PersonDetailInformation();
                    }
                    return new PersonDetailInformation
                    {
                        Id = person.Id,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        Phone = person.Phone,
                        Email = person.Email,
                        PersonTypeId = person.PersonTypeId == null ? Guid.Empty : person.PersonTypeId.Value
                    };
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }

        }


        [Route("SavePerson")]
        [HttpPost]
        public Guid SavePerson([FromBody]PersonDetailInformation person)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    var editPerson = context.Person.FirstOrDefault(p => p.Id == person.Id);
                    if (editPerson == null)
                    {
                        editPerson = new Person { Id = Guid.NewGuid() };
                        context.Person.Add(editPerson);
                    }
                    editPerson.FirstName = person.FirstName;
                    editPerson.LastName = person.LastName;
                    editPerson.Email = person.Email;
                    editPerson.Phone = person.Phone;
                    editPerson.PersonTypeId = person.PersonTypeId;
                    context.SaveChanges();
                    return editPerson.Id;
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }
        }

        [Route("DeletePerson")]
        [HttpPost]
        public Boolean DeletePerson([FromBody]Guid personId)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    var editPerson = context.Person.FirstOrDefault(p => p.Id == personId);
                    if (editPerson == null) return false;
                    context.Person.Remove(editPerson);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }
        }
    }
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Net;
using System.Net.Http;
using PersonService.Contracts;
using Core.Services.EFModels;

namespace PersonService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        public List<PersonListInformation> GetPeopleList()
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    return context.Person
                        .OrderBy(p => p.FirstName)
                        .Select(p => new PersonListInformation
                        {
                            Id = p.Id,
                            Name = p.FirstName + " " + p.LastName,
                            Phone = p.Phone,
                            Email = p.Email,
                            PersonType = p.PersonType.Description
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }
        }

        [Route("Search/{searchText}")]
        [HttpGet]
        public List<PersonListInformation> SearchPeople(string searchText)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    return context.Person
                        .Where(p => p.FirstName.StartsWith(searchText)
                        || p.LastName.StartsWith(searchText)
                        || p.Email.StartsWith(searchText)
                        || p.Phone.StartsWith(searchText))
                        .OrderBy(p => p.FirstName)
                        .Select(p => new PersonListInformation
                        {
                            Id = p.Id,
                            Name = p.FirstName + " " + p.LastName,
                            Phone = p.Phone,
                            Email = p.Email,
                            PersonType = p.PersonType.Description
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }

        }

        [Route("PersonType")]
        [HttpGet]
        public List<PersonTypeInformation> GetPersonType(Guid id)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    return context.PersonType
                        .OrderBy(p => p.Description)
                        .Select(p => new PersonTypeInformation
                        {
                            Id = p.Id,
                            Description = p.Description
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }

        }

        [Route("Person/{id}")]
        [HttpGet]
        public PersonDetailInformation GetPerson(Guid id)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    var person = context.Person.FirstOrDefault(p => p.Id == id);
                    if (person == null)
                    {
                        return new PersonDetailInformation();
                    }
                    return new PersonDetailInformation
                    {
                        Id = person.Id,
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        Phone = person.Phone,
                        Email = person.Email,
                        PersonTypeId = person.PersonTypeId == null ? Guid.Empty : person.PersonTypeId.Value
                    };
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }

        }


        [Route("SavePerson")]
        [HttpPost]
        public Guid SavePerson([FromBody]PersonDetailInformation person)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    var editPerson = context.Person.FirstOrDefault(p => p.Id == person.Id);
                    if (editPerson == null)
                    {
                        editPerson = new Person { Id = Guid.NewGuid() };
                        context.Person.Add(editPerson);
                    }
                    editPerson.FirstName = person.FirstName;
                    editPerson.LastName = person.LastName;
                    editPerson.Email = person.Email;
                    editPerson.Phone = person.Phone;
                    editPerson.PersonTypeId = person.PersonTypeId;
                    context.SaveChanges();
                    return editPerson.Id;
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }
        }

        [Route("DeletePerson")]
        [HttpPost]
        public Boolean DeletePerson([FromBody]Guid personId)
        {
            try
            {
                using (var context = new DockerSampleContext())
                {
                    var editPerson = context.Person.FirstOrDefault(p => p.Id == personId);
                    if (editPerson == null) return false;
                    context.Person.Remove(editPerson);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                var logThis = ex.Message;
                throw;
            }
        }
    }
>>>>>>> 744737003b437ddbd924bd4a4a0f3885ec50bce9
}