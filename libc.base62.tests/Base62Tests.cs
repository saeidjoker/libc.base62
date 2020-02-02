using System;
using Xunit;
namespace libc.base62.tests {
    public class Base62Tests {
        [Fact]
        public void Ascii() {
            var ascii = "Hello I'm ASCII";
            var base62 = Base62.Encode62(ascii);
            var ascii_back = Base62.Decode62(base62);
            Assert.Equal(ascii, ascii_back, StringComparer.Ordinal);
        }
        [Fact]
        public void Unicode() {
            var ascii = "سلام من اسکی هستم";
            var base62 = Base62.Encode62(ascii);
            var ascii_back = Base62.Decode62(base62);
            Assert.Equal(ascii, ascii_back, StringComparer.Ordinal);
        }
    }
}