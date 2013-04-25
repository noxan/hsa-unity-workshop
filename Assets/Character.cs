using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
    private Transform trans;

    public GameObject rocket;

    private float lastTime = Time.time;

    private void Start () {
        this.trans = transform;
    }

    private void Update () {
        if(Input.GetKey(KeyCode.W)) {
            trans.Translate(Vector3.forward);
        } else if(Input.GetKey(KeyCode.S)) {
            trans.Translate(-Vector3.forward);
        }

        if(Input.GetKey(KeyCode.A)) {
            trans.Rotate(Vector3.down);
        } else if(Input.GetKey(KeyCode.D)) {
            trans.Rotate(Vector3.up);
        }

        if(Input.GetKey(KeyCode.Space) && (Time.time - lastTime) > 0.2f) {
            lastTime = Time.time;
            Vector3 offset = trans.rotation * Vector3.forward;
            GameObject.Instantiate(rocket, this.trans.position + offset, this.trans.rotation);
        }
    }
}
