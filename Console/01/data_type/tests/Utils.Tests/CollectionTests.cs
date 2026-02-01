namespace Utils.Tests;

public class CollectionTests
{
    [Fact]
    public void AsIntListFact()
    {
        //Arrange
        int[] values = [4, 3, 2, 1];

        //Act
        List<int> result = Collection.AsList(values);

        //Assert
        Assert.Equal([4, 3, 2, 1], result);
    }
}