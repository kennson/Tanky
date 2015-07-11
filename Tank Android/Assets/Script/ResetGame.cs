using UnityEngine;

using System.Collections;

public class ResetGame : MonoBehaviour {

	public GameObject playerTank;
	public GameObject explosion;

	public void TakeDamage(GameObject shooter) {

		DestroyObjects();
		Application.LoadLevel("StartScene");
	}

	void DestroyObjects()
	{
		Instantiate (explosion, transform .position, transform .rotation);
		Destroy(gameObject);
	}
}
