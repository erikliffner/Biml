<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.VisualBasic.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.dll</Reference>
  <Namespace>Microsoft.VisualBasic.FileIO</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

//using Microsoft.VisualBasic.Strings


void Main()
{
	for(int i = 1; i < 65000; i++) {
		Console.WriteLine(Convert.ToChar(i).ToString() + " is a " + CharGuess(Convert.ToChar(i).ToString()));
	}
}

// Define other methods and classes here
SqlDbType CharGuess(string input, bool debug = false) {
	//since the source is already a string, our job is to just return char or nchar
	//the calling function can see all the values in a column to make the (variable) length guess
	
	if(input.Any(c => c > 255)) 
		return SqlDbType.NChar;
	else
		return SqlDbType.Char;

}