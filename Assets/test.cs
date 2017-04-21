using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    Transform cube;


	// Use this for initialization
	void Start () {
        cube = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        //上に移動
        cube.position += new Vector3(0, 0.01f, 0);

		
	}
}
