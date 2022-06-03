using UnityEngine;
using System.Collections;

public class ChangeWeapon : MonoBehaviour {

	
	private int cnt = 1;
	private int Mcnt = 1;
	private int flag = 0;
	
	private int notcnt = 0;
	
	private GameObject Weapon;
	private GameObject Back;

	private GameObject M1;
	private GameObject M2;
	private GameObject M3;
	/*private GameObject M4;
	private GameObject M5;
	private GameObject M6;
	private GameObject M7;*/

	private GameObject Select1;
	private GameObject Select2;
	private GameObject Select3;
	
	private GameObject M1Contents;
	
	Animator animator1;
	Animator animator2;
		
	Animator animator6;
	Animator animator7;
	Animator animator8;
		
	//Animator animator13;
	
	
	public AudioClip audio1;
	public AudioClip audio2;
	public AudioClip audio3;

	//=================================================
	private GameObject RedHawk;
	
	private GameObject M4A1;
	
	private GameObject P90;
	
	private int WeaponCnt=0;


	//=================================================
	
	
	// Use this for initialization
	void Start () {
		Weapon    = GameObject.FindWithTag("Mission");
		Back     = GameObject.FindWithTag("Garage");

		
		M1		   = GameObject.FindWithTag("M-1");
		M2		   = GameObject.FindWithTag("M-2");
		M3		   = GameObject.FindWithTag("M-3");

		
		M1Contents = GameObject.FindWithTag("M-1Contents");

		Select1 = GameObject.FindWithTag("Select1");
		Select2 = GameObject.FindWithTag("Select2");
		Select3 = GameObject.FindWithTag("Select3");

		animator1 = Weapon.GetComponent<Animator> ();
		animator2 = Back.GetComponent<Animator> ();

		
		animator6  = M1.GetComponent<Animator> ();
		animator7  = M2.GetComponent<Animator> ();
		animator8  = M3.GetComponent<Animator> ();

		//animator13 = M1Contents.GetComponent<Animator> ();

		//=======================================================
		RedHawk = GameObject.FindWithTag("Redhawk");
		M4A1 = GameObject.FindWithTag("M4A1");
		P90 = GameObject.FindWithTag("P90");
		
		M4A1.SetActive(false);
		RedHawk.SetActive(false);
		P90.SetActive(false);

		Select1.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
		Select2.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
		Select3.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
		//=======================================================
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log (cnt);
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			audio.PlayOneShot(audio1);
			if(flag == 0){
				cnt = cnt + 1;
				if(cnt >= 2)cnt = 2;
			}else{
				Mcnt = Mcnt + 1;
				if(Mcnt >= 3)Mcnt = 3;
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
			WeaponCnt = 0;
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

			
			animator6.SetBool("Mission", false);
			animator7.SetBool("Mission", false);
			animator8.SetBool("Mission", false);

			
			//animator13.SetBool("mission1contents", false);
			
		}
		
		if (flag == 1){
			Weapon.guiTexture.color    = new Color(0.5f, 0.5f, 0.5f, 0.3f);
			Back.guiTexture.color     = new Color(0.5f, 0.5f, 0.5f, 0.3f);

			
			animator1.SetBool("outcamera", true);
			animator2.SetBool("outcamera", true);

			
			animator6.SetBool("Mission", true);
			animator7.SetBool("Mission", true);
			animator8.SetBool("Mission", true);

			
		}
		//======================================================================
		
		if (flag == 0) {
			switch (cnt) {
			case 1://Mission
				audio.Play();
				Weapon.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
				Back.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.2f);

				if (flag==0 && Input.GetKeyDown (KeyCode.Return)) {
					flag = 1;
				}
				break;
				
			case 2://Garage
			Weapon.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.2f);
			Back.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
			
				if (flag==0 && Input.GetKeyDown (KeyCode.Return)) {
					audio.PlayOneShot(audio3);
					FadeManager.Instance.LoadLevel("SelectScene",0.5f);
				}
				break;
		
			}
		}
		
		
		if (flag == 1) {
			notcnt++;
			Debug.Log(notcnt);
			switch(Mcnt){
			case 1:
				audio.Play();
				//animator13.SetBool("mission1contents", true);
			M1.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
			M2.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
			M3.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
				WeaponCnt = 1;
				if (flag == 1 && notcnt >= 20 && Input.GetKeyDown (KeyCode.Return)) {

				}
				break;
				
			case 2:
				//animator13.SetBool("mission1contents", false);
			M1.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
			M2.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
			M3.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
				WeaponCnt = 2;
				break;
				
			case 3:
				//animator13.SetBool("mission1contents", false);
			M1.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
			M2.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);
			M3.guiTexture.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
				WeaponCnt = 3;
				break;
				
			}
		}

		ChangeWeaponSee();
		nowWeapon ();
	}

	void ChangeWeaponSee(){
		switch (WeaponCnt) {
		case 0:
			Select1.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
			Select2.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
			Select3.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
			break;

		case 1:
			M4A1.SetActive(false);
			RedHawk.SetActive(true);
			P90.SetActive(false);
			if(Input.GetKeyDown(KeyCode.Return)){

				testWeaponChange.changeCnt = 2;
			}
			break;

		case 2:
			M4A1.SetActive(true);
			RedHawk.SetActive(false);
			P90.SetActive(false);
			if(Input.GetKeyDown(KeyCode.Return)){

				testWeaponChange.changeCnt = 1;
			}
			break;

		case 3:
			M4A1.SetActive(false);
			RedHawk.SetActive(false);
			P90.SetActive(true);
			if(Input.GetKeyDown(KeyCode.Return)){

				testWeaponChange.changeCnt = 3;
			}
			break;
		}
	}

	void nowWeapon(){
		if(WeaponCnt >= 1){
			switch (testWeaponChange.changeCnt) {
			case 1:
				Select1.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
				Select2.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
				Select3.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
				break;

			case 2:
				Select1.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
				Select2.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
				Select3.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
				break;

			case 3:
				Select1.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
				Select2.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0f);
				Select3.guiTexture.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
				break;
			}
		}
	}
}
