using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * GridCreation that creates 3D based on data from CityDataManager
 * 
 * Author: 		Dongwon(Shawn) Kim
 * Date(Cr): 	2017-09-18
 * Date(Mo):	2017-09-18 
 * Reference:	
 * http://answers.unity3d.com/questions/718778/trying-to-create-a-grid.html
 * https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
 * http://answers.unity3d.com/questions/25352/add-texture-to-gameobject-through-code.html
 * https://www.youtube.com/watch?v=810UVUWGlWw
 **/
public class GridCreation : MonoBehaviour {

	public Transform CellPrefab;
	public Vector3 Size;
	public int GridWidth;
	public int GridHeight;

	// Use this for initialization
	void Start () {
		CreateGrid ();
	}

	void CreateGrid(){
//		GameObject text = new GameObject();
//		TextMesh t = text.AddComponent<TextMesh>();
//		t.text = "1";
//		t.fontSize = 30;

		Debug.Log (CellPrefab.localScale.x +", " + CellPrefab.localScale.z);

		for(int x = 0; x < Size.x; x++){
			for(int z = 0; z < Size.z; z++){
				Instantiate(CellPrefab, new Vector3(x + CellPrefab.localScale.x*x,
													0,
													z+CellPrefab.localScale.z*z),
													Quaternion.identity);
			}
		}
	}
}