using UnityEngine;
using System.Collections;

public class PlayerTank : MonoBehaviour {

	public float speed = 20f;
	public Vector2 maxVelocity = new Vector2(3,5);
	private bool standing;
	public float tankSpeed = 20f;
	
	private Animator animator;
	private PlayerTankController controller;
	
	void Start(){
		animator = GetComponent<Animator> ();
		controller = GetComponent<PlayerTankController> ();
	}
	
	void OnCollisionEnter(Collision target){
		if (!standing) {
			var absVelX = Mathf.Abs(rigidbody.velocity.x);
			var absVelY = Mathf.Abs(rigidbody.velocity.y);
		}
	}
	
	void Update () {
		var forceX = 0f;
		var forceY = 0f;
		var absVelX = Mathf.Abs (rigidbody.velocity.x);
		var absVelY = Mathf.Abs (rigidbody.velocity.y);
		
		if (absVelY < .2f) {
			standing = true;	
		} else {
			standing = false;
		}
		
		if (controller.moving.x != 0) {
			if (absVelX < maxVelocity.x) {
				forceX = standing ? speed * controller.moving.x : (speed * controller.moving.x);
				transform.localScale = new Vector3 (forceX > 0 ? 1 : -1, 1, 1);
			}	
		} 
		
		if (controller.moving.y > 0) {
			
			if (absVelY < maxVelocity.y)
				forceY = tankSpeed * controller.moving.y;
		} 
		
		rigidbody.AddForce(new Vector2(forceX,forceY));
	}
}
