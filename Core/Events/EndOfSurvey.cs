using Core.Domain;

namespace Core.Events
{
    /// <summary>
    /// 调查结束事件
    /// </summary>
    public class EndOfSurvey : IDomainEvent
    {
        public Survey Survey { get; set; }
    }
}
