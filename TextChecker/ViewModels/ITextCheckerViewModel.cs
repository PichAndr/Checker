using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChecker.Models
{
    public interface ITextChecker
    {
        /// <summary>
        /// Interface für StringValidierungen
        /// </summary>
        
        /// <summary>
        /// Validiert einen String und liefert das Ergebnis als bool
        /// </summary>
        /// <param name="value">Der zu überprüfende Wert</param>
        /// <returns>Das Ergebnis des Checks</returns>
        bool Validate( string value );
    }
}
