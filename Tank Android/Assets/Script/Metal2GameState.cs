using UnityEngine;
using System.Collections;

public class Metal2GameState : MonoBehaviour {

	private GameObject metal2;
	
	private Metal2SpawnController metal2SpawnCTRL;
	
	private GameObject randMetal2Spawn;
	
	void Awake()
	{
		metal2 = GameObject.FindWithTag("Metal2");
		metal2SpawnCTRL = GameObject.FindGameObjectWithTag("Metal2SpawnCTRL").GetComponent<Metal2SpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randMetal2Spawn = metal2SpawnCTRL.GetRandomMetal2Spawn(randNum);
		
		SpawnMetal2();
	}
	
	void SpawnMetal2()
	{
		metal2.transform.position = randMetal2Spawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}
