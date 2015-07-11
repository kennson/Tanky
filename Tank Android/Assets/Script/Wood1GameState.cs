using UnityEngine;
using System.Collections;

public class Wood1GameState : MonoBehaviour {

	private GameObject wood1;
	
	private Wood1SpawnController wood1SpawnCTRL;
	
	private GameObject randWood1Spawn;
	
	void Awake()
	{
		wood1 = GameObject.FindWithTag("Wood1");
		wood1SpawnCTRL = GameObject.FindGameObjectWithTag("Wood1SpawnCTRL").GetComponent<Wood1SpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randWood1Spawn = wood1SpawnCTRL.GetRandomWood1Spawn(randNum);
		
		SpawnWood1();
	}
	
	void SpawnWood1()
	{
		wood1.transform.position = randWood1Spawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}
