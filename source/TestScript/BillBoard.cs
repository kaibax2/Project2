using UnityEngine;
using System.Collections;

public class BillBoard : MonoBehaviour {
	public Transform Target;
	
	Transform this_t_;
	
	void Awake() {
		this_t_ = this.transform;
	}
	
	void Update() {
		if ( Target == null ) return;
		Vector3 target_pos = Target.position;
		Vector3 vec = target_pos - this_t_.position;
		vec.x = vec.y = 0.0f;
		this_t_.LookAt(target_pos - vec); 
	}
}
