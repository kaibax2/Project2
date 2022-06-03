using UnityEngine;
using System.Collections;

public class GunAttackArea : MonoBehaviour {
	CharacterStatus status;

	void Start () {
		status = transform.root.GetComponent<CharacterStatus>();
	}
	
	public class AttackInfo{
		public int attackPower;		//この攻撃の攻撃力
		public Transform attacker;	//攻撃者
	}

	AttackInfo GetAttackInfo(){
		AttackInfo attackInfo = new AttackInfo ();
		//攻撃力の計算
		//attackInfo.attackPower = status.Power;

		//attackInfo.attacker = transform.root;

		return attackInfo;
	}

	//当たった
	void OnTriggerEnter(Collider other){

		switch (other.tag) {
		case "kabe":
			Debug.Log("ok");
			Destroy(gameObject);
			break;
			
		case "Enemy1":
			Debug.Log("Enemy1");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy2":
			Debug.Log("Enemy2");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy3":
			Debug.Log("Enemy3");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy4":
			Debug.Log("Enemy4");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy5":
			Debug.Log("Enemy5");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy6":
			Debug.Log("Enemy6");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy7":
			Debug.Log("Enemy7");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		case "Enemy8":
			Debug.Log("Enemy8");
			//攻撃が当たった相手のDamageメッセージを送る
			other.SendMessage ("Damage", GetAttackInfo ());
			//攻撃した対象を保存
			//status.lastAttackTarget = other.transform.root.gameObject;
			Destroy(gameObject);
			break;
			
		}



	}

	//攻撃判定を有効にする
	void OnAttack(){
		collider.enabled = true;
	}

	//攻撃判定を無効にする
	void OnAttackTermination(){
		collider.enabled = false;
	}

}
