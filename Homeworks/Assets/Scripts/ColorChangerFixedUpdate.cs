using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerFixedUpdate : MonoBehaviour
{
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
        GetComponent<MeshRenderer>().material.color = new Color(Random.value,Random.value, Random.value);
    }
}
