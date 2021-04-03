using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

public class Task5
{
	struct human
	{
		public string name;
		public string surname;
		public human(string str)
		{
			string[] split_str = str.Split(":");
			name = split_str[0];
			surname = split_str[1];
		}
	}
	public Task5()
	{
	}

	public static string surname_order(string input)
	{
		List<human> list = new List<human>();
		foreach(var str in input.Split(";"))
		{
			list.Add(new human(str));
		}
		var sorted_people = list.OrderBy(h => h.surname).ThenBy(h => h.name).ToList();
		string result = "";
		foreach (var human in sorted_people)
		{
			result = result + "(" + human.surname.ToUpper() + ", " + human.name.ToUpper() + ")";
		}
		return result;
	}
}
