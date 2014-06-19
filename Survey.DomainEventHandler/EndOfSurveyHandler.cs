using Core;
using Core.Events;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.DomainEventHandler
{
    public class EndOfSurveyHandler:IDomainHandler<EndOfSurvey>
    {
        public void Handle(EndOfSurvey args)
        {
            args.Survey.QualityChecker = "Ivan Amalo";
            //Send Email To Ivan to check the survey
        }
    }
}
