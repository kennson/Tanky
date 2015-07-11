using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed;
	public GameObject owner;

	void Start () {
		rigidbody.AddForce (-transform.forward * speed, ForceMode.Impulse);
	}
	
	void OnCollisionEnter(Collision col) {
		col.gameObject.SendMessage ("TakeDamage", this.owner, SendMessageOptions.DontRequireReceiver);
		DestroyObject (gameObject);
	}
}
