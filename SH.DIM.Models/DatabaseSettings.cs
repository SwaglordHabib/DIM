
using SH.DIM.Models.Contracts;
using System.Diagnostics.CodeAnalysis;

namespace SH.DIM.Models;

public class DatabaseSettings : IDatabaseSettings
{
    [NotNull]
    public string? CollectionName { get; set; }
    [NotNull]
    public string? ConnectionString { get; set; }
    [NotNull]
    public string? DatabaseName { get; set; }
}
