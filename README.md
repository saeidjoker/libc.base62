# libc.base62
## Encoder / Decoder for base-62 format

### Why we need this?
- We need to encode / decode base62 string in csharp

### How does it work?
- Simply uses a BitStream class (find it in the code) to do the operation (really simple)

### Usage:
Just add this [nuget package](https://www.nuget.org/packages/libc.base62/) to your project and use as below:
```
[Fact]
public void Ascii() {
    var ascii = "Hello I'm ASCII";
    var base62 = libc.base62.Base62.Encode62(ascii);
    var ascii_back = libc.base62.Base62.Decode62(base62);
    Assert.Equal(ascii, ascii_back, StringComparer.Ordinal);
}
[Fact]
public void Unicode() {
    var ascii = "سلام من اسکی هستم";
    var base62 = libc.base62.Base62.Encode62(ascii);
    var ascii_back = libc.base62.Base62.Decode62(base62);
    Assert.Equal(ascii, ascii_back, StringComparer.Ordinal);
}
```
