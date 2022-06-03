using UnityEngine;
using System.Collections;

public class GameOverClear : MonoBehaviour {

	public static int GOCflag=0;
	public GameObject MissionComplete;
	public GameObject MissionFailed;
	public GameObject PlayerHP;

	private int cnt=0;
	private int hp=0;

	// Use this for initialization
	void Start () {
		MissionComplete.guiText.color = new Color(1f, 1f, 1f, 0.0f);
		MissionFailed.guiText.color   = new Color(1f, 1f, 1f, 0.0f);


	}
	
	// Update is called once per frame
	void Update () {
		Screen.showCursor = false;
		if (GOCflag >= 4) {
			Result.clearScore = 10000;
			Result.gekihasuu = GOCflag;
			Result.nokoriHP = PlayerHP.GetComponent<TestFont> ().genzai;

			cnt++;
			MissionComplete.guiText.color = new Color(1f, 0.3f, 0.3f, cnt);
			if(cnt >= 320)
				FadeManager.Instance.LoadLevel("ResultScene",0.5f);
		}


		hp = PlayerHP.GetComponent<TestFont> ().genzai;

		if (hp <= 0) {
			Result.clearScore = 0;
			Result.gekihasuu = GOCflag;
						cnt++;
						MissionFailed.guiText.color = new Color (0.0f, 0.3f, 1.0f, 1.0f);

						if (cnt >= 320)
				FadeManager.Instance.LoadLevel("ResultScene",0.5f);

				}
	}
}