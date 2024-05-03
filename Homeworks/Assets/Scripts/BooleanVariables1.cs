using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanVariables1 : MonoBehaviour
{
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
        GetComponent<MeshRenderer>().material.color = colorSwitch ? Color.white : Color.black;
    }
}
