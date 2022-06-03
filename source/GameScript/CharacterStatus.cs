using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour {
	public int HP = 100;
	public int MaxHP = 100;

	public int Power = 10;

	//最後に攻撃した対象
	public GameObject lastAttackTarget = null;

	public bool attacking=false;
	public bool died= false;

}
