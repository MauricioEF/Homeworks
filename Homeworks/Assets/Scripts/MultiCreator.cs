using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiCreator : MonoBehaviour
{
    public GameObject preferedPrefab;
    public List<GameObject> objectsList;
    public float scaleFactor;
    public int numObjects;
    private PrimitiveType[] randomizedTypes =
    {
        PrimitiveType.Cube,
        PrimitiveType.Capsule,
        PrimitiveType.Cylinder,
        PrimitiveType.Sphere
    };

    // Start is called before the first frame update
    void Start()
    {
        objectsList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numObjects++;
        GameObject tempGameObject;

        if (preferedPrefab)
        {
            tempGameObject = Instantiate<GameObject>(preferedPrefab);
        }
        else
        {
            tempGameObject = GameObject.CreatePrimitive(randomizedTypes[Random.Range(0, 3)]);
            
        }
        if(tempGameObject.GetComponent<Rigidbody>() == null)
        {
            tempGameObject.AddComponent<Rigidbody>();
        }
        
        tempGameObject.name = "Object-" + numObjects;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = transform.position + Random.insideUnitSphere * 5;
        objectsList.Add(tempGameObject);

        List<GameObject> objectsToDelete = new List<GameObject>();

        foreach(GameObject obj in objectsList)
        {
            float scale = obj.transform.localScale.x;
            scale *= scaleFactor;
            obj.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objectsToDelete.Add(obj);
            }
        }

        foreach(GameObject objectToDelete in objectsToDelete)
        {
            objectsList.Remove(objectToDelete);
            Destroy(objectToDelete);
        }
    }
}
