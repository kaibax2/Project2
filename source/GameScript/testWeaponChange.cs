using UnityEngine;
using System.Collections;

public class testWeaponChange : MonoBehaviour {


	private GameObject RedHawk;

	private GameObject M4A1;

	private GameObject P90;

	public static int changeCnt=1;

	void Awake(){

		RedHawk = GameObject.FindWithTag("Redhawk");
		M4A1 = GameObject.FindWithTag("M4A1");
		P90 = GameObject.FindWithTag("P90");
	}
	// Use this for initialization
	void Start () {


		M4A1.SetActive(true);
		RedHawk.SetActive(false);
		P90.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.F1)) {
			changeCnt = 1;
				}

	if (Input.GetKeyDown (KeyCode.F2)) {
			changeCnt = 2;
	}

	if (Input.GetKeyDown (KeyCode.F3)) {
			changeCnt = 3;
	}
		WeaponChange ();
	}

	void WeaponChange(){
		switch (changeCnt) {
		case 1:
			M4A1.SetActive(true);
			RedHawk.SetActive(false);
			P90.SetActive(false);
			break;

		case 2:
			M4A1.SetActive(false);
			RedHawk.SetActive(true);
			P90.SetActive(false);
			break;

		case 3:
			M4A1.SetActive(false);
			RedHawk.SetActive(false);
			P90.SetActive(true);
			break;
				}
		}
}
