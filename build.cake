#addin LibGit2Sharp

using LibGit2Sharp;

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  Information("Reproducing problem");
  var repo = new Repository("./.git");
  Information("If you see this message then the problem was not reproduced :(");
});

RunTarget(target);