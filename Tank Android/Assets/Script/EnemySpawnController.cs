using UnityEngine;
using System.Collections;

public class EnemySpawnController : MonoBehaviour {

	public GameObject[] enemyArray;
	private int randNum;
	
	void Awake()
	{
		enemyArray = GameObject.FindGameObjectsWithTag("EnemySpawn");
	}
	
	public GameObject GetRandomEnemySpawn(int randNum)
	{
		randNum = Random.Range(0, (enemyArray.Length));
		
		if (enemyArray.Length > 0)
		{
			return enemyArray[randNum];
		}
		else
		{
			return null;
		}
	}
}
