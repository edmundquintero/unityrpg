using UnityEngine;
using System.Collections;

public class BaseCharacter{
	private string characterName;
	private string characterDescription;
	private int stamina;
	private int intelligence;
	private int endourance;
	private int experience;
	private int level;

	public string CharacterName{
		get{ return characterName; }
		set{ characterName = value; }
	}

	public string CharacterDescription{
		get{ return characterDescription; }
		set{ characterDescription = value; }
	}

}
