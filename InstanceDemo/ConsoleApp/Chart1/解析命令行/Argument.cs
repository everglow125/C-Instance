using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace ConsoleApp.Chart1
{
    public sealed class Argument
    {
        public string Original { get; }
        public string Switch { get; private set; }
        public ReadOnlyCollection<string> SubArguments { get; }
        private List<string> subArguments;
        public Argument(string original)
        {
            Original = original;
            Switch = string.Empty;
            subArguments = new List<string>();
            SubArguments = new ReadOnlyCollection<string>(subArguments);
            Parse();
        }
        private void Parse()
        {
            if (string.IsNullOrEmpty(Original))
            {
                return;
            }
            char[] switchChars = { '/', '-' };
            if (!switchChars.Contains(Original[0]))
            {
                return;
            }
            string switchString = Original.Substring(1);
            string subArgsString = string.Empty;
            int colon = switchString.IndexOf(':');
            if (colon >= 0)
            {
                subArgsString = switchString.Substring(colon + 1);
                switchString = switchString.Substring(0, colon);
            }
            Switch = switchString;
            if (!string.IsNullOrEmpty(subArgsString))
                subArguments.AddRange(subArgsString.Split(';'));
        }

        public bool IsSimple => SubArguments.Count == 0;
        public bool IsSimpleSwitch =>
            !string.IsNullOrEmpty(switch) && SubArguments.Count == 0;
    }
}
