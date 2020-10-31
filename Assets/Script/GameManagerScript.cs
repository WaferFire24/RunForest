using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

	public List<Transform> backgrounds = new List<Transform> ();

	private float[] skalaParalax;

	public float smoothing;

	private Transform cam;
	private Vector3 prevPosCam;


	void Awake () {
		cam = Camera.main.transform;
	}


	void Start () {
		prevPosCam = cam.position;

		skalaParalax = new float[backgrounds.Count];
		for (int i = 0; i < backgrounds.Count; i++)
		{
			skalaParalax[i] = backgrounds[i].position.z * -1;
		}
	}

	void Update () {

		for (int i = 0; i < backgrounds.Count; i++)
		{
			float parallax = (prevPosCam.x - cam.position.x) * skalaParalax[i];
			float bgTargetPosX = backgrounds[i].position.x + parallax;
			Vector3 bgNewPosition = new Vector3(bgTargetPosX, backgrounds[i].position.y, 
				backgrounds[i].position.z);

			backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, 
			bgNewPosition, 
			smoothing * Time.deltaTime);
		}

		prevPosCam = cam.position;
	}
}
