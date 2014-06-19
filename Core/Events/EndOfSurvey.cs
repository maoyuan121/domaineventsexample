using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Domain;

namespace Core.Events
{
    public class EndOfSurvey : IDomainEvent
    {
        public Survey Survey { get; set; }
    }
}
