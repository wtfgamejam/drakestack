using UnityEngine;
using System.Collections;

public class Drake : MonoBehaviour {

	public static System.Action Fall = ()=>{};
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.localPosition.x > 10f || transform.localPosition.x < -10f)
		{
			Fall();
			Debug.Log("fall");
			Destroy(this);
		}
	}
}
