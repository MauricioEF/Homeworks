using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanVariables4 : MonoBehaviour
{

    public GameObject cube1;
    public GameObject cube2;
    public bool colorSwitch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colorSwitch = cube1.GetComponent<BooleanVariables2>().colorSwitch && cube2.GetComponent<BooleanVariables3>().colorSwitch;
        GetComponent<MeshRenderer>().material.color = colorSwitch ? Color.white : Color.black;
        
    }
}
