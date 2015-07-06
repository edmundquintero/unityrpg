using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

//	private int classSelection;
//	private string[] classSelectionNames = new string[] { "Mage", "Warrior", "Archer", "Paladin", "Priest" };

	private BaseMageCharacter mage = new BaseMageCharacter();

	public void DisplayClassSelections(){
//		classSelection = GUI.SelectionGrid (new Rect (50, 50, 250, 300), classSelection, classSelectionNames, 2);

		GUI.Label (new Rect (50, 50, 100, 300), mage.Stamina.Name);
		GUI.Label (new Rect (150, 50, 100, 300), mage.Stamina.Value.ToString());
		GUI.Label (new Rect (50, 65, 100, 300), mage.Stamina.Description);

		GUI.Label (new Rect (50, 100, 100, 300), mage.Intelligence.Name);
		GUI.Label (new Rect (150, 100, 100, 300), mage.Intelligence.Value.ToString());
		GUI.Label (new Rect (50, 115, 100, 300), mage.Intelligence.Description);
	

	}



	public void DisplayStatAllocation(){


		
	}


	public void DisplayFinalSetup(){
		
	}
}
