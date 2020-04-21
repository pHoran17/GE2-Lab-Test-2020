using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    public Vector3 force = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;
    public Vector3 velocity = Vector3.zero;
    public float mass = 1;
    public float damping = 0.01f;
    public float banking = 0.1f;
    public float maxSpeed = 5.0f;
    public float maxForce = 10.0f;
    public float weight = 1.0f;
    public GameObject[] lights;
    public GameObject[] gLights;
    Transform dest;


    // Start is called before the first frame update
    void Start()
    {
        //lights = new GameObject[10];
        //spawn = GameObject.Find("Spawner").GetComponent<LightBehaviour>();
        Debug.Log(lights);
        chooseTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (dest.gameObject.tag != "GreenLight")
        {
            chooseTarget();
        }
        
        force = Calculate();
        acceleration = force / mass;
        velocity = acceleration * Time.deltaTime;
        if (velocity.magnitude > float.Epsilon)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking), Time.deltaTime * 3.0f);
            transform.LookAt(transform.position + velocity, tempUp);
            transform.position += velocity * Time.deltaTime;
            velocity *= (1.0f - (damping * Time.deltaTime));
        }
    }
    Vector3 Calculate()
    {
        force = Vector3.zero;
        force += (dest.transform.position - this.transform.position);
        return force;
    }
    public void chooseTarget() 
    {
        /*for(int i = 0; i < lights.Length; i++) 
        {
            //lights[i] = GameObject.FindGameObjectsWithTag("GreenLight");
            lights[i] = GameObject.Find("GreenLight");
            Debug.Log(lights[i]);
        }*/
        //NullPointerException, array not being allocated objects
        lights = GameObject.FindGameObjectsWithTag("GreenLight");
        Debug.Log(lights.Length);
        int index = Random.Range(0, lights.Length - 1);
        dest = lights[index].transform;
    }

    //Code for steering behaviour from lectures
    public Vector3 SeekForce(Vector3 target)
    {
        Vector3 desired = target - transform.position;
        desired.Normalize();
        desired *= maxSpeed;
        return desired - velocity;
    }
    public Vector3 ArriveForce(Vector3 target, float slowDist = 15.0f)
    {
        Vector3 toTarget = target - transform.position;
        float distance = toTarget.magnitude;
        if (distance < 0.1f)
        {
            return Vector3.zero;
        }
        float ramped = maxSpeed * (distance / slowDist);
        float clamped = Mathf.Min(ramped, maxSpeed);
        Vector3 desired = clamped * (toTarget / distance);
        return desired - velocity;
    }
}
