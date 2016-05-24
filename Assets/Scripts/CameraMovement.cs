using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float duration = 0.5f;
	public GameObject resetButton;
	private Vector3 startPos;
	private Vector3 endPos;
	private float currentLerpTime = 0f;
	private bool lerp= false;
	
	// Use this for initialization
	void Awake () {
		startPos = transform.localPosition;
		endPos = new Vector3(startPos.x, 160f, startPos.z);
		resetButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(lerp)
		{
			currentLerpTime += Time.deltaTime;
			
			if(currentLerpTime >= duration)
			{
				lerp = false;
			}
		
			float perc = currentLerpTime / duration;
			transform.position = Vector3.Lerp(startPos, endPos, perc);
		}
		
	}
	
	public void Move(Vector3 dest)
	{
		if(dest.y < transform.localPosition.y) return;
		currentLerpTime = 0f;
		startPos = transform.localPosition;
		endPos = new Vector3(transform.localPosition.x, dest.y, transform.localPosition.z);
		lerp = true;
	}
	
	public void Play()
	{
		currentLerpTime = 0f;
		// transform.localPosition = startPos;
		// lerp = true;
	}
	
	public void EndGame()
 	{
		lerp = false;
		resetButton.SetActive(true);
	}
}
