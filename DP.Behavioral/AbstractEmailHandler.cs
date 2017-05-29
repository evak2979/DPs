using DP.Behavioral.Handlers;

namespace DP.Behavioral
{
    public interface IEmailHandler
    {
        IEmailHandler NextHandler { set; }
        void ProcessHandler(string email);
    }

    //Avoid coupling the sender of a request to its receiver, by giving more than one object a chance to handle the request.Chain
    //the receiving objects and pass the request along the chain until an object handles it.
    public abstract class AbstractEmailHandler : IEmailHandler
    {
        private IEmailHandler _nextHandler;
        private bool _wordFound;

        public IEmailHandler NextHandler
        {
            set => _nextHandler = value;
        }

        public void ProcessHandler(string email)
        {
            if (MatchingWords().Length == 0)
            {
                _wordFound = true;
            }
            else
            {
                foreach (string word in MatchingWords())
                {
                    if (email.IndexOf(word) >= 0)
                    {
                        _wordFound = true;
                        break;
                    }
                }
            }

            if (_wordFound)
            {
                HandleHere(email);
            }
        }

        protected internal abstract string[] MatchingWords();
        protected internal abstract void HandleHere(string email);

        public static void Handle(string email)
        {
            IEmailHandler spam = new SpamEmailHandler();
            IEmailHandler sales = new SalesEmailHandler();
            IEmailHandler service = new ServiceEmailHandler();
            IEmailHandler general = new GeneralEmailHandler();

            spam.NextHandler = sales;
            sales.NextHandler = service;
            service.NextHandler = general;

            spam.ProcessHandler(email);
        }
    }
}
