using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public abstract class State 
{
    public StateMachine sm;
    public State Enter() {}
    public State Exit() {}
    public State Think() {}
}

public class StateMachine : MonoBehaviour
{
    public State currentState;
    public State globalState;
    public State previousState;

    private IEnumerator coroutine;
    public int updatesPS = 5;

    public void OnEnable() 
    {
    
    StartCoroutine(Think());

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeStateDelayed(State newState, float delay) 
    {
        coroutine = ChangeStateCoRoutine(newState, delay);
        StartCoroutine(coroutine);
    }
    public void CancelDelayedStateChange() 
    {
        if(coroutine != null) 
        {
            StopCoroutine(coroutine);
        }
    }
    IEnumerator ChangeStateCoRoutine(State newState, float delay) 
    {
        yield return new WaitForSeconds(delay);
        ChangeState(newState);
    }
    public void ChangeState(State newState) 
    {
        previousState = currentState;
        if(currentState != null) 
        {
            currentState.Exit();
        }
        currentState = newState;
        currentState.sm =this;
        currentState.Enter();
    }
    System.Collections.IEnumerator Think() 
    {
        yield return new WaitForSeconds(Random.Range(0, 0.5f));
        while (true) 
        {
            if(globalState != null) 
            {
                globalState.Think();
            }
            if(currentState != null) 
            {
                currentState.Think();
            }
            yield return new WaitForSeconds(1.0f / (float)updatesPS);
        }
    }
    public void RevertToPrevState() 
    {
        ChangeState(previousState);
    }
    
}*/

