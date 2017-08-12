using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfect : MonoBehaviour {

	// This code helps make the game pixel perfect
	// If you don't know what that is google it
	// but in short, pixel perfect allows the art
	// in the game too look like what the artist intends
	// it too look
	// - Stephen

	void Start () {
		Camera cam = GetComponent<Camera> ();
		if (cam.orthographic) {
			cam.orthographicSize = Screen.height / 100f / 2f;
		}
	}
}
