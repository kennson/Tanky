using UnityEngine;
using System.Collections;

public class AITankSwitcher : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		AITank AI = transform.parent.GetComponent<AITank> ();

		if (AI) {
			if(AI.controller)
				AI.controller.direction += 1;
		}
	}
}
