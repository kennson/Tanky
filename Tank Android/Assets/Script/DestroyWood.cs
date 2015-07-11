using UnityEngine;
using System.Collections;

public class DestroyWood : MonoBehaviour {

	public GameObject explosion;

	public void TakeDamage(GameObject shooter) {
		if ((shooter.GetComponent<AITank> () != null) && (GetComponent<AITank> () != null)) {
			return;
		}

		DestroyObjects();
		//Application.LoadLevel (Application.loadedLevel);
		DestroyObject (this.gameObject);
	}

	void DestroyObjects()
	{
		Instantiate (explosion, transform .position, transform .rotation);
		Destroy(gameObject);
	}
}
