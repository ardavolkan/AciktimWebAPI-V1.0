using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PasswordRecovery : IEntity
    {
        public string Id { get; set; }
        public string MailAddress { get; set; }
        public string PrivateKey { get; set; }
    }
}
