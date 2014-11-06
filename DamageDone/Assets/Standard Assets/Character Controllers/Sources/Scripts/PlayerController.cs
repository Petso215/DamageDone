using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{	
	public float speed = 6f;
	public float left = 0;
	public float right = 0;
	Animator anim;



	
	// START - Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// UPDATE is called once per frame
	void Update () 
		


	{


		// Moves player left, right, up, down. No collision.

		float x = Input.GetAxis("Horizontal") * Time.smoothDeltaTime * speed;
		float y = Input.GetAxis("Vertical") * Time.smoothDeltaTime * speed;
		anim.SetFloat("speed", Input.GetAxis ("Horizontal"));

		/*if (Input.GetAxis ("Horizontal") < 0) {
			//transform.Translate(x,0,y,Space.Self);
			//transform.eulerAngles = new Vector2(0, 0);
			anim.SetFloat ("left", Mathf.Abs (Input.GetAxis ("Horizontal")));
		}
		if (Input.GetAxis ("Horizontal") > 0) {
			//transform.Translate(x,0,y,Space.Self);
			//transform.eulerAngles = new Vector2(0, 180);
			anim.SetFloat ("right", Mathf.Abs (Input.GetAxis ("Horizontal")));
		}
		if (Input.GetAxis ("Horizontal") == 0) {
			//transform.Translate(x,0,y,Space.Self);
			//transform.eulerAngles = new Vector2(0, 180);
			anim.SetFloat ("Idol", Mathf.Abs (Input.GetAxis ("Horizontal")));
		}*/

		transform.Translate(x,0,y,Space.Self);
	}
}