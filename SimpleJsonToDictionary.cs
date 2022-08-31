using System;
using Newtonsoft.Json;
using System.Collections.Generic;
public class Program
{
	public static void Main()
	{
		string json = @"{""key1"":""value1"",""key2"":""value2""}";

		var values = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);
		foreach(var valu in values){
		Console.WriteLine(valu.Key);
		Console.WriteLine(valu.Value);
		}
	}
}
