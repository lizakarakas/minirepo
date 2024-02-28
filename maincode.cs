using System;
using System.ComponentModel;
using System.Linq;
using Nuke.Common.Tooling;

[TypeConverter(typeof(TypeConverter<Configuration>))]//augh
public class Configuration : Enumeration
{
    public static Configuration Debug = new Configuration { Value = nameof(Debug) };
    public static Configuration Release = new Configuration { Value = nameof(Release) };

    public static implicit operator string(Configuration configuration)
    {
 
    public ReleaseNotes(Version version, IEnumerable<string> notes, string rawVersionLine)
        : this(
            version ?? throw new ArgumentNullException(nameof(version)),
            new SemVersion(version.Major, version.Minor, version.Build),
            notes,
            rawVersionLine)
    {
    }
//good
    private ReleaseNotes(Version version, SemVersion semVersion, IEnumerable<string> notes, string rawVersionLine)
    {
        Version = version ?? throw new ArgumentNullException(nameof(version));
        SemVersion = semVersion ?? throw new ArgumentNullException(nameof(semVersion));
        RawVersionLine = rawVersionLine;
        _notes = new List<string>(notes ?? Enumerable.Empty<string>());
    }
