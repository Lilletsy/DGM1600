using UnityEngine;
using System.Collections;

public class Destroy_crates : MonoBehaviour {
    public GameObject debris;


void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag == "Projectile"){
    Instantiate(debris,transform.position,transform.rotation);
    Destroy (gameObject);
}
}

// Update is called once per frame
void Update () {
//Destroy (gameObject, countDown);
}
}