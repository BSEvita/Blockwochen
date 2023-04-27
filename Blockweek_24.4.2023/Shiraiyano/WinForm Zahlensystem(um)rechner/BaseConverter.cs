using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Zahlensystem_um_rechner
{
	internal class BaseConverter
	{
        /// <summary>
        /// Converts Numbers between bases
        /// </summary>
        /// <param name="num">The Number</param>
        /// <param name="fromBase">From what base the conversion happens</param>
        /// <param name="toBase">To what base the conversion happens</param>
        /// <returns></returns>
        public static string ConvertBases(string num, int fromBase, int toBase)
        {
            try
            {
                return Convert.ToString(Convert.ToInt32(num, fromBase), toBase);
            }
            catch (Exception e)
            {
                MessageBox.Show("Die angegebene zahl ist zu groß!", "Fehler: " + e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }
        }
    }
}
