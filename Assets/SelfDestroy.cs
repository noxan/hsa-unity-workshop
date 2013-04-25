using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour {
	public float time;
	
	void Start () {
		Invoke("Delete", time);
	}
	
	void Delete() {
		Destroy(gameObject);
	}
}
