using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class StartController : MonoBehaviour {

	private const int counterReset = 3;
	public static int counterForAds = counterReset;
	
	void Awake() {
		if (Advertisement.isSupported) {
			Advertisement.allowPrecache = true;
			Advertisement.Initialize("37033", false);
		}
	}
	
	public static void resetCounter() {
		counterForAds = counterReset;
	}

	void Start() {
		counterForAds--;
		if (counterForAds <= 0) {
			resetCounter();
			Advertisement.Show(null, new ShowOptions{
				pause = true,
				resultCallback = result => {
					
				}
			});
		}
	}
	public void StartGame() {
	
		Application.LoadLevel("Tank");
	}
	
	public void QuitGame()
	{
		Application .Quit();
	}
}
