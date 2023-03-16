namespace tests;

public class HiTest
{
    [Fact]
    public void TrueIsTrue() { Assert.True(true); }

    [Fact]
    public void SayHiReturnsHi()
    {
        var hi = new lib.Hi();
        Assert.Equal("Hi from lib", hi.SayHi());
    }
}