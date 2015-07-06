using UnityEngine;
using System.Collections;

public class BaseStatistic {

	private string name;
	private string description;
	private int value;

	public string Name{ 
		get{ return name; }
		set{ name = value; }
	}
	public string Description{ 
		get{ return description; }
		set{ description = value; }
	}
	public int Value{ get; set; }

	public BaseStatistic(string newName){
		name = newName;
		description = "";
		value = 1;
	}
	public BaseStatistic(string newName, string newDescription){
		name = newName;
		description = newDescription;
		value = 1;
	}
	public BaseStatistic(string newName, string newDescription, int newValue){
		name = newName;
		description = newDescription;
		value = newValue;
	}

}
