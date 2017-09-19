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
 * https://gamedev.stackexchange.com/questions/134000/unity-2d-coordinates
 **/
public class GridColor : MonoBehaviour {
	private Color[] Colors = new Color[4] { Color.red, Color.blue, Color.green, Color.yellow };
	public int index;

	void Awake()
	{
		index = Random.Range(0, Colors.Length);
		var spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.color = Colors[index];
	}

}
