using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using TextChecker.Models;

namespace TextChecker.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, 
    {
        public void LoadPalindrome()
        {
            ActivateItem( new PalindromeViewModel() );
        }
        public void LoadEvenOrOdd()
        {
            ActivateItem( new EvenOrOddViewModel() );
        }
        public void LoadPageOne()
        {
            ActivateItem( new FirstChildViewModel() );
        }
        public void LoadPageTwo()
        {
            ActivateItem( new SecondChildViewModel() );
        }
    }
}