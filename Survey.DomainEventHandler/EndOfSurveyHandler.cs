using Core.Events;
using Core.Services;

namespace Survey.DomainEventHandler
{
    /// <summary>
    /// 事件处理器
    /// </summary>
    public class EndOfSurveyHandler : IDomainHandler<EndOfSurvey>
    {
        public void Handle(EndOfSurvey args)
        {
            args.Survey.QualityChecker = "Ivan Amalo";
            //Send Email To Ivan to check the survey
        }
    }
}
