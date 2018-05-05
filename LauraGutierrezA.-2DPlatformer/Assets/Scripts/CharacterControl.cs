using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour {

	public float speed = 0.1f;

	int coins = 0;
	int hearts = 0;
	public Text componenteCoins;
	public Text componenteHearts;


	public void ClickEnElBoton () {
		print ("El usuario hizo click en el boton");

		this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 5, ForceMode2D.Impulse);
	}


	// Use this for initialization
	void Start () {
		
	}
	//esta funcion es  invocada cuando el collider
	// agregado a este gameobject toca otro collider. Sale "impacto" en el console. 
	void OnCollisionEnter2D(Collision2D coll) {
	 


		if (coll.collider.gameObject.tag == "Coins") {

			// Eliminamos la moneda
			GameObject.Destroy(coll.collider.gameObject);

			//Aumentamos la cantidad de monedas que tiene el personaje
			coins = coins + 1;

			//Mostramos la cantidad de monedas en el comoponente TextCoins
			componenteCoins.text = coins.ToString();
		}

		if (coll.collider.gameObject.tag == "Hearts") {

			// Eliminamos la corazon
			GameObject.Destroy(coll.collider.gameObject);

			//Aumentamos la cantidad de monedas que tiene el personaje
			hearts = hearts + 1;

			//Mostramos la cantidad de monedas en el comoponente TextCoins
			componenteHearts.text = hearts.ToString();
		}
	}

	
	// Update is called once per frame
	void Update () {

		//Movimiento a la derecha
		if (Input.GetKey(KeyCode.RightArrow)) {

			this.transform.Translate (speed, 0, 0);
}

		//Movimiento a la izquierda
		if (Input.GetKey (KeyCode.LeftArrow)) {

			transform.Translate (-speed, 0, 0);
		}

		//Si la tecla  de espacio esta presionada, Salta
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			//le agrego una fuerza hacia arriba 
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 10, ForceMode2D.Impulse);
		}

	}
}
