using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

	[HideInInspector]
	public TankController controller;
	public float shootingTime = 1;
	public float _shootingTimer = 1;
	
	void Start () {
		controller = GetComponent<TankController> ();
	}
	
	void Update () {
		_shootingTimer -= Time.deltaTime;
		
		if (_shootingTimer <= 0) {
			_shootingTimer = shootingTime;
			controller.Shoot();
		}
	}
}
