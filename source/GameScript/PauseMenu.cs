using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	
	private int cnt = 1;

	private int flag = 0;

	private GameObject BacktoGame;
	private GameObject BacktoMenu;
	private GameObject Pause;
	

	void Awake(){

		BacktoGame    = GameObject.FindWithTag("BacktoGame");
		BacktoMenu    = GameObject.FindWithTag("BacktoMenu");
		Pause 		  = GameObject.FindWithTag ("Pause");

		}
	// Use this for initialization
	void Start () {

		BacktoGame.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
		BacktoMenu.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
		Pause.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (cnt);
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
				cnt = cnt + 1;
				if(cnt >= 2)cnt = 2;
		}
		
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
				cnt = cnt - 1;
				if(cnt <= 1)cnt = 1;
		}

		if (flag == 0) {
			BacktoGame.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
			BacktoMenu.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);

				}
		
		if (flag == 1) {
						switch (cnt) {
						case 1://BacktoGame
				
								BacktoGame.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
								BacktoMenu.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.2f);
			
								if (Input.GetKeyDown (KeyCode.Return)) {
										Pause.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
										Time.timeScale = 1;
										flag = 0;
								}
								break;
				
						case 2://BacktoMenu
								BacktoGame.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.2f);
								BacktoMenu.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
				
								if (Input.GetKeyDown (KeyCode.Return)) {
					Time.timeScale = 1;
										FadeManager.Instance.LoadLevel ("SelectScene", 0.5f);
								}
								break;
				
						}
				}
		TimeStop ();
	}
	


	void TimeStop(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Time.timeScale = 0;
			flag = 1;
			Pause.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
		}
	
	}
}
