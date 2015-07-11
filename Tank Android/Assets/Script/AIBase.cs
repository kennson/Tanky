using UnityEngine;
using System.Collections;

public class AIBase : MonoBehaviour {

	[HideInInspector]
	public BaseController controller;
	public float directionSwitcherTime = 3;
	public float _directionSwitcherTimer = 3;
	
	void Start () {
		controller = GetComponent<BaseController> ();
	}
	
	void Update () {
		_directionSwitcherTimer -= Time.deltaTime;
		
		if (_directionSwitcherTimer <= 0) {
			_directionSwitcherTimer = directionSwitcherTime;
			controller.direction = (BaseController.goDirection)Random.Range (0, 4);
		}

	}
}
