using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject player;
	public Texture btnTexture;
	private Quaternion initialRot;

	void OnGUI() {

			if (GUI.RepeatButton (new Rect (Screen.width * 0.1f, Screen.height * 0.8f, 50, 50), btnTexture)) 
			{
				player.transform.position += Vector3.left * Time.deltaTime;
				player.transform.rotation = initialRot;
				player.transform.Rotate (new Vector3 (0, 90, 0));
			}
			
			if (GUI.RepeatButton (new Rect (Screen.width * 0.2f, Screen.height * 0.8f, 50, 50), btnTexture)) 
			{
				player.transform.position += Vector3.right * Time.deltaTime;
				player.transform.rotation = initialRot;
				player.transform.Rotate (new Vector3 (0, -90, 0));
			}
			
			if (GUI.RepeatButton (new Rect (Screen.width * 0.8f, Screen.height * 0.7f, 50, 50), btnTexture)) 
			{
				player.transform.position += Vector3.up * Time.deltaTime;
				player.transform.rotation = initialRot;
				player.transform.Rotate (new Vector3 (90, 0, 0));
			}
			
			if (GUI.RepeatButton (new Rect (Screen.width * 0.8f, Screen.height * 0.85f, 50, 50), btnTexture)) 
			{
				player.transform.position += Vector3.down * Time.deltaTime;
				player.transform.rotation = initialRot;
				player.transform.Rotate (new Vector3 (-90, 0, 0));
			}
	}
}
