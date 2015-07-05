using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string[] classSelectionNames = new string[] { "Mage", "Warrior", "Archer", "Paladin", "Priest", "test", "test", "test", "test", "test", "test", "test"};

	public void DisplayClassSelections(){
		classSelection = GUI.SelectionGrid (new Rect (50, 50, 250, 300), classSelection, classSelectionNames, 2);
	}
	public void DisplayStatAllocation(){
		
	}
	public void DisplayFinalSetup(){
		
	}
}
