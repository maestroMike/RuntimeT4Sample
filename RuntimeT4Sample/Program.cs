// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics;
using System.IO;

namespace RuntimeT4Sample
{
public static class Program
{
	public static void Main(params string[] args)
	{
		Console.WriteLine( "Enter any words end press enter to generate html page." );
		var userText = Console.ReadLine();

		var generatedHtml = new HtmlPageGenerator( userText ).TransformText();

		var filePath = Path.Combine( Path.GetTempPath(), "htmlReport.html" );
		File.WriteAllText( filePath, generatedHtml );
		Process.Start( filePath );
	}
}
}