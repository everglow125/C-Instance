using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Logic.Command
{
    public sealed class Argument
    {
        public string Original { get; private set; }
        public string Switch { get; private set; }
        public ReadOnlyCollection<string> SubArguments { get; private set; }
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
        public bool IsSimple
        {
            get { return SubArguments.Count == 0; }
        }
        public bool IsSimpleSwitch
        {
            get { return !string.IsNullOrEmpty(Switch) && SubArguments.Count == 0; }
        }
        public bool IsCompoundSwitch
        {
            get
            {
                return !string.IsNullOrEmpty(Switch) && SubArguments.Count == 1;
            }
        }
        public bool IsComplexSwitch
        {
            get
            {
                return !string.IsNullOrEmpty(Switch) && SubArguments.Count > 0;
            }
        }
    }
}
