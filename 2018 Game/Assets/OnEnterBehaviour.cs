using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Events;

public class OnEnterBehaviour : StateMachineBehaviour {
	public GameEvent Event;
	 override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	Event.Raise();
	}

}
