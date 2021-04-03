using System;
using System.Collections.Generic;

public class Task1
{
	public Task1()
	{

	}

	public static List<object> filterList(List<object> list)
	{
		var filtered = new List<object>();
		foreach (var word in list)
		{
			if (word is int || word is uint)
			{
				filtered.Add(word);
			}
		}
		return filtered;
	}
}
