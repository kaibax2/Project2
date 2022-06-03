using UnityEngine;
using System.Collections;

public class Sentaku : MonoBehaviour {

	private int cnt = 1;
	private int Mcnt = 1;
	private int flag = 0;

	private int notcnt = 0;

	private GameObject Mission;
	private GameObject Garage;
	private GameObject Option;
	private GameObject FinishGame;
	private GameObject Credit;

	private GameObject M1;
	private GameObject M2;
	private GameObject M3;
	private GameObject M4;
	private GameObject M5;
	private GameObject M6;
	private GameObject M7;

	private GameObject M1Contents;



	Animator animator1;
	Animator animator2;
	Animator animator3;
	Animator animator4;
	Animator animator5;

	Animator animator6;
	Animator animator7;
	Animator animator8;
	Animator animator9;
	Animator animator10;
	Animator animator11;
	Animator animator12;

	Animator animator13;


	public AudioClip audio1;
	public AudioClip audio2;
	public AudioClip audio3;



	// Use this for initialization
	void Start () {
		Mission    = GameObject.FindWithTag("Mission");
		Garage     = GameObject.FindWithTag("Garage");
		Option     = GameObject.FindWithTag("Option");
		FinishGame = GameObject.FindWithTag("FinishGame");
		Credit     = GameObject.FindWithTag("Credit");

		M1		   = GameObject.FindWithTag("M-1");
		M2		   = GameObject.FindWithTag("M-2");
		M3		   = GameObject.FindWithTag("M-3");
		M4		   = GameObject.FindWithTag("M-4");
		M5		   = GameObject.FindWithTag("M-5");
		M6		   = GameObject.FindWithTag("M-6");
		M7		   = GameObject.FindWithTag("M-7");

		M1Contents = GameObject.FindWithTag("M-1Contents");

		animator1 = Mission.GetComponent<Animator> ();
		animator2 = Garage.GetComponent<Animator> ();
		animator3 = Option.GetComponent<Animator> ();
		animator4 = FinishGame.GetComponent<Animator> ();
		animator5 = Credit.GetComponent<Animator> ();
	
		animator6  = M1.GetComponent<Animator> ();
		animator7  = M2.GetComponent<Animator> ();
		animator8  = M3.GetComponent<Animator> ();
		animator9  = M4.GetComponent<Animator> ();
		animator10 = M5.GetComponent<Animator> ();
		animator11 = M6.GetComponent<Animator> ();
		animator12 = M7.GetComponent<Animator> ();	

		animator13 = M1Contents.GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (cnt);
	if (Input.GetKeyDown (KeyCode.DownArrow)) {
			audio.PlayOneShot(audio1);
			if(flag == 0){
			cnt = cnt + 1;
			if(cnt >= 5)cnt = 5;
			}else{
			Mcnt = Mcnt + 1;
			if(Mcnt >= 7)Mcnt = 7;
			}
				}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			audio.PlayOneShot(audio1);
			if(flag == 0){
			cnt = cnt - 1;
			if(cnt <= 1)cnt = 1;
			}else{
			Mcnt = Mcnt - 1;
			if(Mcnt <= 1)Mcnt = 1;
			}
				}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			audio.Play();
						flag = 0;
						Mcnt = 1;
				}

		//======================================================================
		if (flag == 0) {

			notcnt = 0;
			/*
			M1.guiTexture.color = Color.clear;
			M2.guiTexture.color = Color.clear;
			M3.guiTexture.color = Color.clear;
			M4.guiTexture.color = Color.clear;
			M5.guiTexture.color = Color.clear;
			M6.guiTexture.color = Color.clear;
			M7.guiTexture.color = Color.clear;
			*/

			animator1.SetBool("outcamera", false);
			animator2.SetBool("outcamera", false);
			animator3.SetBool("outcamera", false);
			animator4.SetBool("outcamera", false);
			animator5.SetBool("outcamera", false);

			animator6.SetBool("Mission", false);
			animator7.SetBool("Mission", false);
			animator8.SetBool("Mission", false);
			animator9.SetBool("Mission", false);
			animator10.SetBool("Mission", false);
			animator11.SetBool("Mission", false);
			animator12.SetBool("Mission", false);

			animator13.SetBool("mission1contents", false);
		
		}

		if (flag == 1) {
			Mission.guiTexture.color    = new Color(1f, 1f, 1f, 0.3f);
			Garage.guiTexture.color     = new Color(1f, 1f, 1f, 0.3f);
			Option.guiTexture.color     = new Color(1f, 1f, 1f, 0.3f);
			FinishGame.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
			Credit.guiTexture.color     = new Color(1f, 1f, 1f, 0.3f);

			animator1.SetBool("outcamera", true);
			animator2.SetBool("outcamera", true);
			animator3.SetBool("outcamera", true);
			animator4.SetBool("outcamera", true);
			animator5.SetBool("outcamera", true);

			animator6.SetBool("Mission", true);
			animator7.SetBool("Mission", true);
			animator8.SetBool("Mission", true);
			animator9.SetBool("Mission", true);
			animator10.SetBool("Mission", true);
			animator11.SetBool("Mission", true);
			animator12.SetBool("Mission", true);

				}
		//======================================================================

		if (flag == 0) {
						switch (cnt) {
						case 1://Mission
				audio.Play();
								Mission.guiTexture.color = new Color (1f, 1f, 1f, 1.0f);
								Garage.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Option.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								FinishGame.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
				                Credit.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
								if (flag==0 && Input.GetKeyDown (KeyCode.Return)) {
									flag = 1;
								}
								break;

						case 2://Garage
								Garage.guiTexture.color = new Color (1f, 1f, 1f, 1.0f);
								Mission.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Option.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								FinishGame.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Credit.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
								if (flag==0 && Input.GetKeyDown (KeyCode.Return)) {
					FadeManager.Instance.LoadLevel("GarageScene",0.5f);
					audio.PlayOneShot(audio3);
								}
								break;
				
						case 3://Option
								Mission.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Garage.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Option.guiTexture.color = new Color (1f, 1f, 1f, 1.0f);
								FinishGame.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Credit.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);				
				if (flag==0 && Input.GetKeyDown (KeyCode.Return)) {
					audio.PlayOneShot(audio3);
				}				
				break;

						case 4://FinishGame
								Mission.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Garage.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Option.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								FinishGame.guiTexture.color = new Color (1f, 1f, 1f, 1.0f);
								Credit.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);	
								if(Input.GetKeyDown(KeyCode.Return)){

					Application.Quit();
				}
								break;

						case 5:
								Mission.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Garage.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Option.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								FinishGame.guiTexture.color = new Color (1f, 1f, 1f, 0.3f);
								Credit.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);		
				if (flag==0 && Input.GetKeyDown (KeyCode.Return)) {
					FadeManager.Instance.LoadLevel("CreditScene",0.5f);
				}						
				break;
					}
				}


		if (flag == 1) {
			notcnt++;
			switch(Mcnt){
			case 1:
				audio.Play();
				animator13.SetBool("mission1contents", true);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				if (flag == 1 && notcnt >= 20 && Input.GetKeyDown (KeyCode.Return)) {
					//Debug.Log("ktkr");
					FadeManager.Instance.LoadLevel("testScene",0.5f);
				}
				break;

			case 2:
				animator13.SetBool("mission1contents", false);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				break;

			case 3:
				animator13.SetBool("mission1contents", false);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				break;

			case 4:
				animator13.SetBool("mission1contents", false);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				break;

			case 5:
				animator13.SetBool("mission1contents", false);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				break;

			case 6:
				animator13.SetBool("mission1contents", false);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				break;

			case 7:
				animator13.SetBool("mission1contents", false);
				M1.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M2.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M3.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M4.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M5.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M6.guiTexture.color = new Color(1f, 1f, 1f, 0.3f);
				M7.guiTexture.color = new Color(1f, 1f, 1f, 1.0f);
				break;
			}
				}
	}
}
