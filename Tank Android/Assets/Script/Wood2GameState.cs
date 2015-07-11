using UnityEngine;
using System.Collections;

public class Wood2GameState : MonoBehaviour {

	private GameObject wood2;
	
	private Wood2SpawnController wood2SpawnCTRL;
	
	private GameObject randWood2Spawn;
	
	void Awake()
	{
		wood2 = GameObject.FindWithTag("Wood2");
		wood2SpawnCTRL = GameObject.FindGameObjectWithTag("Wood2SpawnCTRL").GetComponent<Wood2SpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randWood2Spawn = wood2SpawnCTRL.GetRandomWood2Spawn(randNum);
		
		SpawnWood2();
	}
	
	void SpawnWood2()
	{
		wood2.transform.position = randWood2Spawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}
