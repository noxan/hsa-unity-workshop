using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
    private Transform trans;

    public GameObject explosion;

    private void Start () {
        this.trans = transform;
        this.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        Invoke("Delete", 2f);
    }

    private void Update () {
        this.trans.Translate(Vector3.forward);
    }

    private void Delete() {
        GameObject e = (GameObject)GameObject.Instantiate(explosion, this.trans.position, this.trans.rotation);
        e.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider collisionInfo) {
        Delete();
    }
}
