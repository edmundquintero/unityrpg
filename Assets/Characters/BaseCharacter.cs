using UnityEngine;
using System.Collections;

public class BaseCharacter{
	private string characterName;
	private string characterDescription;

	private int stamina;
	private int intelligence;
	private int endourance;
	private int strength;

	private int experience;
	private int level;

	private int statPointsToAllocate;

	public int StatePointToAllocate{ get; set; }

	public string CharacterName{
		get{ return characterName; }
		set{ characterName = value; }
	}
	public string CharacterDescription{
		get{ return characterDescription; }
		set{ characterDescription = value; }
	}

	public int Stamina{
		get{ return stamina; }
		set{ stamina = value; }
	}
	public int Intelligence{
		get{ return intelligence; }
		set{ intelligence = value; }
	}
	public int Endourance{
		get{ return endourance; }
		set{ endourance = value; }
	}
	public int Strength{
		get{ return strength; }
		set{ strength = value; }
	}

	public int Experience{
		get{ return experience; }
		set{ experience = value; }
	}
	public int Level{
		get{ return level; }
		set{ level = value; }
	}

}
