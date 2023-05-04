using System.Diagnostics.CodeAnalysis;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Extensions;

public class TestParent : IEquatable<TestParent>
{
    public int Id { get; set; }

#pragma warning disable CS8618
    public string Name { get; set; }
#pragma warning restore CS8618

#pragma warning disable CS8618
    public IEnumerable<TestChild> Children { get; set; }
#pragma warning restore CS8618

    public bool Equals([AllowNull] TestParent other) =>
        other?.Id == Id && other?.Name == Name &&
        (other?.Children is null && Children is null ||
        (other?.Children?.Zip(Children)?.All(t => t.First?.Equals(t.Second) ?? false) ?? false));
}
