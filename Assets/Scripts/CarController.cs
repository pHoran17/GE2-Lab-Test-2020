/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //public Spawner spawn;
    public float targetDistance;
    public GameObject targetLight;
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<StateMachine>().ChangeState(new FindTargetState());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class FindTargetState: State 
{
    Vector3 destPos;
    public override void Enter() 
    {
        GameObject[] lights = GameObject.FindGameObjectsWithTag("GreenLight");
        GameObject dest;
        int index = Random.Range(0, lights.Length);
        dest = lights[index].transform;
        /*foreach(TrafficLight l in lights) 
        {
            Color tlColor = l.gameObject.GetComponent<Renderer>().material.color;
            while(tlColor == Color.green) 
            {
                dest = l.gameObject;
            }
        }*/
        /*
        Vector3 toLight = sm.transform.position - dest.transform.position;
        toLight.Normalize();
        destPos = dest.transform.position + toLight * (sm.GetComponent<CarController>().targetDistance);
        sm.GetComponent<Arrive>().targetPosition = toLight;
        sm.GetComponent<Arrive>().enabled = true;
        sm.GetComponent<CarController>().targetLight = dest;

    }
    public override void Exit() 
    {
        sm.GetComponent<Arrive>().enabled = false;
    }
    public override void Think() 
    {
        if(Vector3.Distance(owner.transform.position, attackPos) < 2.0f) 
        {
            sm.GetComponent<StateMachine>().ChangeState(new ArrivalState());
        }
    }
}
public class ArrivalState: State 
{
    
}

*/

