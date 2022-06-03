using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {
	public GameObject clear;
	public GameObject gekiha;
	public GameObject gekihaScore;
	public GameObject hp;
	public GameObject goukei;


	public static int gekihasuu=0;
	public static int clearScore=10000;
	public static int nokoriHP=0;

	public static int score = 0;
	public int Gscore=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Screen.showCursor = false;
		Gscore = gekihasuu * 100;

		score = clearScore + Gscore + nokoriHP;

		clear.guiText.text = clearScore.ToString ();
		gekiha.guiText.text = gekihasuu.ToString ();
		gekihaScore.guiText.text = Gscore.ToString ();
		hp.guiText.text = nokoriHP.ToString ();
		goukei.guiText.text = score.ToString ();

		if (Input.GetKeyDown (KeyCode.Return)) {
			GameOverClear.GOCflag = 0;
			FadeManager.Instance.LoadLevel("SelectScene",0.5f);
				}
	}
}
