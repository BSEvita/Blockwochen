using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensytemumrechner
{
    public class Calculator
    {
        /// <summary>
        /// Converts Numbers between bases
        /// </summary>
        /// <param name="num">The Number</param>
        /// <param name="fb">From what base the conversion happens</param>
        /// <param name="tb">To what base the conversion happens</param>
        /// <returns></returns>
        public static string ConvertBases (string num, int fb, int tb)
        {
            try
            {
                return Convert.ToString(Convert.ToInt32(num, fb), tb);
            }
            catch (Exception e)
            {
                MessageBox.Show("Die angegebene zahl ist zu groß!", "Fehler: " + e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
        }
    }
}
