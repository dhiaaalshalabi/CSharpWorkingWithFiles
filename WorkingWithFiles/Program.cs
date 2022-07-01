// The Directory class
Directory.CreateDirectory(@"c:\temp\folder1");
var files = Directory.GetFiles(@"c:\src","*.bat",SearchOption.AllDirectories);
foreach (var file in files)
{
    Console.WriteLine(file);
}

var directories = Directory.GetDirectories(@"c:\src", "*.*",SearchOption.AllDirectories);
foreach(var directory in directories){
    Console.WriteLine(directory);
}

Directory.Exists("...path");

// The DirectoryInfo
var directoryInfo = new DirectoryInfo("...");
directoryInfo.GetFiles();
directoryInfo.GetDirectories();