using UnityEngine;
using System.Collections;

public class CreatePlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates{
	  CLASSSELECTION,
	  STATALLOCATION,
	  FINALSETUP
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
	public static CreateAPlayerStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CreateAPlayerStates.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.STATALLOCATION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		}
	
	}

	void OnGUI(){
		if (currentState == CreateAPlayerStates.CLASSSELECTION) {
			//displat class selection
			displayFunctions.DisplayClassSelections();
		}
		if (currentState == CreateAPlayerStates.STATALLOCATION) {
			//displat class selection
			displayFunctions.DisplayStatAllocation();
		}
		if (currentState == CreateAPlayerStates.FINALSETUP) {
			//displat class selection
			displayFunctions.DisplayFinalSetup();
		}
	}
}
