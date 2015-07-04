using UnityEngine;
using System.Collections;

public class baseMageCharacter : BaseCharacter {

	public void MageClass(){
		CharacterName = "Mage";
		CharacterDescription = "Magic weilding individual.";

		Intelligence = 10;
		Endourance = 5;
		Stamina = 8;
		Strength = 3;

		Experience = 0;
		Level = 1;
	}

}
