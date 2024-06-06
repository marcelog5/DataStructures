using DataStructure.Trees;

namespace DataStructureTests
{
    public class TreeTests
    {
        [Fact]
        public void MustGetTheTreeDepth()
        {
            // Arrange
            Tree tree = new Tree(null);
            tree.Initiate(new int[] { 20, 5, 12, 40, 1 });

            // Act
            int height = tree.GetDepth();
           
            // Assert
            Assert.Equal(3, height);
        }

        [Fact]
        public void MustGetTheTreeRevert()
        {
            // Arrange
            Tree tree = new Tree(null);
            tree.Initiate(new int[] { 20, 5, 12, 40, 1 });
        }
    }
}