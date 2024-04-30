using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisableCreator : MonoBehaviour
{
    public bool alreadyInstantiatedAnObject;

    private void Awake()
    {
        alreadyInstantiatedAnObject = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = transform.position + Random.insideUnitSphere;
            cube.SetActive(false);
            cube.AddComponent<EnableAndDisableCreator>();

    }

    private void OnDisable()
    {

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = transform.position + Random.insideUnitSphere;
            cube.AddComponent<EnableAndDisableCreator>();
        
    }
}
