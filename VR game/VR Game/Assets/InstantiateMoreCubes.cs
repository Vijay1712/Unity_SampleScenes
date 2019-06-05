using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMoreCubes : MonoBehaviour {

    public GameObject cubePreFab;

    public void Cube()
    {
        Instantiate(cubePreFab);
    }
}
