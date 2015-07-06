using UnityEngine;
using System.Collections;

public class baseWarriorCharacter : BaseCharacter {

	public void WarriorClass(){
		CharacterName = "Warrior";
		CharacterDescription = "Weapon weilding individual.";

		Intelligence.Value = 3;
		Endourance = 7;
		Stamina.Value = 12;
		Strength = 15;

		Experience = 0;
		Level = 1;
	}

}
