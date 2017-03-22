using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParseDataExample : MonoBehaviour {

	void Start () {
		print(PD.DATA ["Example"] ["1"] ["id"]);
		print(PD.DATA ["Example"] ["1"] ["name"]);
		print(PD.DATA ["Example"] ["1"] ["price"]);
		print(PD.DATA ["Example"] ["1"] ["des"]);
		print(PD.DATA ["Example"] ["2"] ["name"]);

	}

	void Update () {
		
	}
}
