var target = Argument("target", "Build");
var configuration = Argument("configuration", "Debug");
var projectname = "ConsoleApp2";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////


Information("Beginning cleaning application.....");
Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does(() =>
{
    CleanDirectory($"./bin/{configuration}");
});

Information("Beginning building application.....");

Task("Build")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetBuild($"./{projectname}.sln", new DotNetCoreBuildSettings
    {
        Configuration = configuration,
    });
});


Information("Running tests .....");

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetCoreTest($"./{projectname}.sln", new DotNetCoreTestSettings
    {
        Configuration = configuration,
        NoBuild = true,
    });
});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);