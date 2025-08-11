namespace RBlade.CodeBuilder.Tests.TestUtils;

public static class TestDataLoader {
    public static string Load(params string[] pathSegments) {
        var testData = File.ReadAllText(Path.Combine(new[] { TestContext.CurrentContext.TestDirectory }
                                                     .Concat(pathSegments)
                                                     .ToArray()));
        return testData.Replace("    ", "\t");
    }
}