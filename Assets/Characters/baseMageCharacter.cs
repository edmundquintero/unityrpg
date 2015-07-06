using UnityEngine;
using System.Collections;

public class BaseMageCharacter : BaseCharacter {

	public BaseMageCharacter(){
		CharacterName = "Mage";
		CharacterDescription = "Magic weilding individual.";

		Intelligence.Value = 10;
		Endourance = 5;
		Stamina.Value = 8;
		Strength = 3;

		Experience = 0;
		Level = 1;
	}

}
