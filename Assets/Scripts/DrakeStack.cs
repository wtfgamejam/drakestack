using UnityEngine;
using System.Collections;

public class DrakeStack : MonoBehaviour {

	public GameObject drakePrefab;
	// Use this for initialization
	void Start () {
		drakePrefab.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0)){
			Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			GameObject drake = (GameObject)Instantiate(drakePrefab, Vector3.zero, Quaternion.identity);	
			drake.transform.SetParent(transform, false);
			drake.transform.localPosition = new Vector3(p.x, p.y, 0f);
			drake.SetActive(true);
		}
		
	}
}
