var path = @"c:\src\flutter\analysis_options.yaml";
var extention = path.IndexOf('.');

Path.GetExtension(path);

Console.WriteLine("Extension: "+Path.GetExtension(path));
Console.WriteLine("File Name: "+Path.GetFileName(path));
Console.WriteLine("File Name Without Extension: "+Path.GetFileNameWithoutExtension(path));
Console.WriteLine("Directory Name: "+Path.GetDirectoryName(path));
