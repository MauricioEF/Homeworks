using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreationAwake : MonoBehaviour
{

    public GameObject cubeToCreate;

    private void Awake()
    {
        
        var cube = Instantiate<GameObject>(cubeToCreate);
        cube.transform.position = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
