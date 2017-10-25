namespace TextChecker.ViewModels
{
    using System.Collections.Generic;
    using Caliburn.Micro;
    using TextChecker.Models;
    public class ShellViewModel : ITextChecker
    {
       
        public ITextChecker SelectedTextChecker { get; set; }

        public List<ITextChecker> CheckerAuswahl
        {
            get;
            private set;
        }

        public ShellViewModel()
        {
            this.textChecker = new List<ITextChecker>()
            {
                new PalindromeViewModel(), new EvenOrOddViewModel()
            };
            CheckerAuswahl = textChecker;
        }

        public bool Validate( string value )
        {
            return false;
        }

        private List<ITextChecker> textChecker;
    }
}