# The hardest "What comes next?" (Euler's pentagonal formula)

Puzzle from Mathologer's video: [The hardest "What comes next?" (Euler's pentagonal formula)](https://www.youtube.com/watch?v=iJ8pnCO0nTY)

```C#
[Fact]
public void Test666()
{
    var next = new WhatsNext();
    var buffer = next.PartitionNumbers(666);
    Assert.Equal(11956824258286445517629485m, buffer);
}
```

## Author
:fire: [Greg Eakin](https://www.linkedin.com/in/gregeakin)
