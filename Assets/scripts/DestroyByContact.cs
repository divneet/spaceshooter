using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject Explosion;
	public GameObject PlayerExplosion;
	void OnTriggerEnter (Collider other )
	{

			if (other.tag == "Boundary")
			{
				return;
			}
		//Debug.Log (other.name);
		Instantiate (Explosion, transform.position, transform.rotation);
		if (other.tag == "Player") {
						Instantiate (PlayerExplosion, transform.position, transform.rotation);
				}
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
 }
