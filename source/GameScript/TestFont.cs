using UnityEngine;
using System.Collections;

public class TestFont : MonoBehaviour {

	private int cnt;

	public int genzai=5000;
	private int max;
	private float HPmax;

	public GameObject HP;

	public GameObject HitTexture;

	private float nagasa;

	private Vector3 texPos = new Vector3(0.5f, 0.5f, 0);


	// Use this for initialization
	void Start () {
		max = genzai;

		nagasa = guiTexture.pixelInset.width;

	}
	
	// Update is called once per frame
	void Update () {
	
		cnt = (int)(((float)genzai/(float)max)*100.0f);

		//guiText.text = cnt.ToString ();
	}

	void HPDown(){
		genzai -= 100;

		GameObject tex = (GameObject)Instantiate (HitTexture, texPos, Quaternion.identity);

		tex.guiTexture.pixelInset = new Rect(-683, -380, 1366, 768);

		Destroy (tex, 0.5f);
	}
}
