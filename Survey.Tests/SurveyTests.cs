using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Survey.Tests
{
    public class SurveyTests
    {
        [Fact]
        public void Ending_Survey_Should_Set_EndOfSurvey_Instance()
        {
            var survey = new Core.Domain.Survey();
            Core.Domain.Survey endSurvey = null;

            Core.DomainEvent.Register<Core.Events.EndOfSurvey>(
                s =>
                {
                    endSurvey = s.Survey;
                });

            survey.EndSurvey();

            Assert.Equal(endSurvey, survey);
        }
    }
}
