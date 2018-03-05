using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Events;

public class JumpBehaviour : StateMachineBehaviour {

	public GameEvent Event;
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (Input.GetKeyDown(KeyCode.Space)){
			Event.Raise();
		}
	}

}
