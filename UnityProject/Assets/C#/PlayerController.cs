using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (isLocalPlayer)
		{
			if(Input.GetKey(KeyCode.Q))
			{
				transform.position -= new Vector3(0.01f,0,0);
			}
			if(Input.GetKey(KeyCode.D))
			{
				transform.position += new Vector3(0.01f,0,0);
			}
		}
	}
}
