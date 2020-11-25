# Euler's Twisted Machine - Pentagonal Formula

Puzzle from Mathologer's video: [The hardest "What comes next?" (Euler's pentagonal formula)](https://www.youtube.com/watch?v=iJ8pnCO0nTY)

```C#
[Fact]
public void Test666()
{
    var machine = new WhatsNext();
    var count = machine.PartitionNumbers(666);
    Assert.Equal(11956824258286445517629485m, count);
}
```

## Author
:fire: [Greg Eakin](https://www.linkedin.com/in/gregeakin)
