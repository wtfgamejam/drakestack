using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrakeStack : MonoBehaviour {

	public GameObject drakePrefab;
	public CameraMovement camera;
	
	private List<GameObject> drakes;
	
	// Use this for initialization
	void Start () {
		drakes = new List<GameObject>();
		drakePrefab.SetActive(false);
		camera = Camera.main.gameObject.GetComponent<CameraMovement>();
		Drake.Fall += EndGame;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0)){
			Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			GameObject drake = (GameObject)Instantiate(drakePrefab, Vector3.zero, Quaternion.identity);	
			drake.transform.SetParent(transform, false);
			drake.transform.localPosition = new Vector3(p.x, p.y, 0f);
			drake.SetActive(true);
			camera.Move(drake.transform.localPosition);
			drakes.Add(drake);
		}
		
	}
	
	void EndGame()
	{
		camera.EndGame();
	}
}
