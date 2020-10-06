using System;
namespace Exceptions
{
    public class LectureGetsLess : Exception
    {
        public LectureGetsLess() { }
        public LectureGetsLess(string message) : base(message) { }
    }
    public class BonusIsMore: Exception
    {
        public BonusIsMore(string message): base(message){}
    }
}