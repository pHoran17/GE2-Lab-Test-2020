using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLights : MonoBehaviour
{
    List<GameObject> tLights;
    int amtLights = 10;
    public float radius = 10;
    // Start is called before the first frame update
    void Start()
    {
        CreateCircleOfLights();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateCircleOfLights() 
    {
        tLights = new List<GameObject>();
        float theta = (Mathf.PI * 2.0f) / amtLights; 
        for(int i =0; i < amtLights; i++) 
        {
            Vector3 pos = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius);
            pos = transform.TransformPoint(pos);
            Quaternion quater = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            quater = transform.rotation * quater;
            GameObject tl = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            tl.transform.SetPositionAndRotation(pos, quater);
            tl.transform.parent = this.transform;
            tLights.Add(tl);
        }
    }
}
