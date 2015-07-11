using UnityEngine;
using System.Collections;

public class BaseGameState : MonoBehaviour {

	private GameObject bases;
	
	private BaseSpawnController baseSpawnCTRL;
	
	private GameObject randBaseSpawn;
	
	void Awake()
	{
		bases = GameObject.FindWithTag("Base");
		baseSpawnCTRL = GameObject.FindGameObjectWithTag("BaseSpawnCTRL").GetComponent<BaseSpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randBaseSpawn = baseSpawnCTRL.GetRandomBaseSpawn(randNum);
		
		SpawnBase();
	}
	
	void SpawnBase()
	{
		bases.transform.position = randBaseSpawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}
