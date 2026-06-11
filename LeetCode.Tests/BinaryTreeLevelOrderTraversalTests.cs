namespace LeetCode.Tests
{
    public class BinaryTreeLevelOrderTraversalTests
    {
        [Theory]
        [InlineData(new int[] { 3, 9, 20, 15, 7 }, "[[3],[9,20],[15,7]]")]
        [InlineData(new int[] { 1 }, "[[1]]")]
        [InlineData(new int[] { }, "[]")]
        public void LevelOrder_WorksAsExpected(int[] rootValue, string expectedString)
        {
            // Arrange
            var root = BuildTree(rootValue);

            // Act
            var result = BinaryTreeLevelOrderTraversal.LevelOrder(root);

            // Assert
            Assert.Equal(expectedString, ConvertToString(result));
        }

        public static IEnumerable<object[]> ComplexTrees =>
        new List<object[]>
        {
            new object[]
            {
                new int[] { 10, 5, 15, 3, 7, 12, 18 },
                "[[10],[5,15],[3,7,12,18]]"
            },
            new object[]
            {
                new int[] { 1, 2, 3, 4, 5 },
                "[[1],[2,3],[4,5]]"
            },
            new object[]
            {
                new int[] { 8, 6, 10, 5, 7, 9, 11 },
                "[[8],[6,10],[5,7,9,11]]"
            }
        };

        [Theory]
        [MemberData(nameof(ComplexTrees))]
        public void LevelOrder_MemberDataTests(int[] values, string expectedString)
        {
            // Arrange
            TreeNode root = BuildTree(values);

            // Act
            var result = BinaryTreeLevelOrderTraversal.LevelOrder(root);

            // Assert
            string resultString = ConvertToString(result);
            Assert.Equal(expectedString, resultString);
        }

        [Fact]
        public void LevelOrder_NullRoot_ReturnsEmptyList()
        {
            // Arrange
            TreeNode root = null;

            // Act
            var result = BinaryTreeLevelOrderTraversal.LevelOrder(root);

            // Assert
            Assert.Empty(result);
        }

        private static TreeNode BuildTree(int[] values)
        {
            if (values.Length == 0) return null;

            var nodes = new List<TreeNode>();
            foreach (var v in values)
                nodes.Add(new TreeNode(v));

            for (int i = 0, j = 1; j < nodes.Count; i++)
            {
                if (nodes[i] != null)
                {
                    if (j < nodes.Count) nodes[i].left = nodes[j++];
                    if (j < nodes.Count) nodes[i].right = nodes[j++];
                }
            }

            return nodes[0];
        }

        // Helper para converter resultado em string legível
        private static string ConvertToString(IList<IList<int>> levels)
        {
            var parts = new List<string>();
            foreach (var level in levels)
            {
                parts.Add("[" + string.Join(",", level) + "]");
            }
            return "[" + string.Join(",", parts) + "]";
        }
    }
}
