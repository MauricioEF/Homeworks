using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanVariables3 : MonoBehaviour
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
        
    }

    private void FixedUpdate()
    {
        colorSwitch = cube1.GetComponent<BooleanVariables1>().colorSwitch || cube2.GetComponent<BooleanVariables1>().colorSwitch;
        GetComponent<MeshRenderer>().material.color =  colorSwitch ? Color.white : Color.black;
    }
}
