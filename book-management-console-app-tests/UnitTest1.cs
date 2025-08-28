namespace BookManagementConsoleApp
{

    public class UnitTest1
    {
        [Fact]
        public void isGenreValidTest()
        {
            Assert.True(Book.isGenreValid("horror"));
            Assert.True(Book.isGenreValid("Horror"));
            Assert.False(Book.isGenreValid("Boring"));
        }
    }
}