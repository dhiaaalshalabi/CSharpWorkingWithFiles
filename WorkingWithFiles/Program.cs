// The File class
var path = @"c:\somefile\myfile\myfile.jpg";
File.Copy(@"c:\temp\myfile\myfile.jpg",@"d:\temp\myfile.jpg",true);
File.Delete(path);
if (File.Exists(path))
{
    //
}

var content = File.ReadAllText(path);
 
// The FileInfo class
 
var fileInfo = new FileInfo(path);
fileInfo.CopyTo("...");
fileInfo.Delete();
if (fileInfo.Exists)
{
    //
}