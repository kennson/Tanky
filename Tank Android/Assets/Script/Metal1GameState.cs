using UnityEngine;
using System.Collections;

public class Metal1GameState : MonoBehaviour {

	private GameObject metal1;
	
	private Metal1SpawnController metal1SpawnCTRL;
	
	private GameObject randMetal1Spawn;
	
	void Awake()
	{
		metal1 = GameObject.FindWithTag("Metal1");
		metal1SpawnCTRL = GameObject.FindGameObjectWithTag("Metal1SpawnCTRL").GetComponent<Metal1SpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randMetal1Spawn = metal1SpawnCTRL.GetRandomMetal1Spawn(randNum);
		
		SpawnMetal1();
	}
	
	void SpawnMetal1()
	{
		metal1.transform.position = randMetal1Spawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}
