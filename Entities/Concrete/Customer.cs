using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public string RegisterDate { get; set; }
        public bool Status { get; set; }

    }
}