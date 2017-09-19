using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * GridColor that color sprite renderer to represent zone
 * 
 * Author: 		Dongwon(Shawn) Kim
 * Date(Cr): 	2017-09-18
 * Date(Mo):	2017-09-18 
 * Reference:
 * https://docs.unity3d.com/ScriptReference/Material-color.html
 **/
public class GridColor : MonoBehaviour {
	
//	public Color colorStart = Color.red;
//	public Color colorEnd = Color.green;
//	public float duration = 1.0F;
//	public float minRange = 1.0f;
//	public float maxRange = 2.0f;

	public Renderer rend;	
	public int colorIndex = 0;

	public Color32[] colors = {
		Color.grey,
		Color.red,
		Color.yellow,
		Color.green
	};


	void Start() {
		
		rend = GetComponent<Renderer>();
	}
//for fun
//	void Update() {
//		float lerp = Mathf.PingPong(Time.time, duration) / Random.Range (minRange, maxRange);
//		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
//	}

	void Update(){
		rend.material.color = colors [colorIndex];
	}
}
