using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {
    public Transform target;

    private Transform trans;

	void Start () {
        this.trans = transform;
	}

	void Update () {
	   this.trans.LookAt(target);
	}
}
