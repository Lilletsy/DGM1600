using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

public Rigidbody projectile;
public Transform Spawnpoint;
public int shootSpeed;

// Use this for initialization
void Start () {

}

// Update is called once per frame
void Update () {
	if(Input.GetButtonDown("Fire1")){
		Rigidbody clone;
		clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);
		clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);
	}
}
}
