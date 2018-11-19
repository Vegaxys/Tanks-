using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete {
	public class PowerUp : MonoBehaviour {

		void OnTriggerEnter(Collider other){
			if (other.tag == "Tank") {
				other.GetComponent<TankHealth> ().EnableShield ();
				Destroy (this.gameObject);
			}
		}
	}
}
