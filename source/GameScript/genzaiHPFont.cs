using UnityEngine;
using System.Collections;

public class genzaiHPFont : MonoBehaviour {
	
	private int kari=0;

	public GameObject HP;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		kari = HP.GetComponent<TestFont> ().genzai;
		if (kari <= 0)
						kari = 0;

		guiText.text = kari.ToString();
	}
}
