using System.IO;
using System.Text;

namespace CIB.PhoneBook.Shared.Utilities
{
    public class StringEncoder : StringWriter
    {
        public StringEncoder(Encoding encoding)
        {
            this.Encoding = encoding;
        }

        public override Encoding Encoding { get; }
    }
}
