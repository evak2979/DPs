using System;

namespace DP.Behavioral.Handlers
{
    public class SpamEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new []{"viagra", "pills", "medicines"};
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This is a spam email");
        }
    }

    public class SalesEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new[] { "buy", "purchase" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This is a sales email");
        }
    }

    public class ServiceEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new[] { "service", "repair" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This is a service email");
        }
    }

    public class GeneralEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[0];
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This is a general email");
        }
    }
}
