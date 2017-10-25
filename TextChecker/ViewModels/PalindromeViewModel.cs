using System.Windows;
using Caliburn.Micro;

namespace TextChecker.ViewModels
{
    public class PalindromeViewModel : Screen
    {
        private string _text;
        public void HaveResult()
        {
            string reversedText = "";

            for( int i = text.Length - 1; i >= 0; --i )
            {
                reversedText = reversedText + text[i];
            }

            if( text.ToLower().Replace( " ", "" ).Replace( ".", "" ).Replace( ",", "" ).Replace( ";", "" ) == reversedText.ToLower().Replace( " ", "" ).Replace( ".", "" ).Replace( ",", "" ).Replace( ";", "" ) )
            {
                MessageBox.Show( "Ihre Eingabe ist ein Palindrom" + "\n\nGRÜN" );
            }
            else
            {
                MessageBox.Show( "Ihre Eingabe ist kein Palindrom" + "\n\nROT" );
            }
        }
        public string text
        {
            get { return _text; }
            set
            {
                _text = value;
                NotifyOfPropertyChange( () => text );
                NotifyOfPropertyChange( () => CanHaveResult );
            }
        }
        public bool CanHaveResult
        {
            get { return !string.IsNullOrWhiteSpace( text ); }
        }
    }
}
