using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    Wander,
    Flee,
    Seek,
}

public class EnemyManager : MonoBehaviour
{
    EnemyState state;
    public Transform target;
    public float fleeDistance;
    public  EnemyFlee fleeComponent;
    public EnemySeek seekComponent;
    public EnemyMove wanderComponent;

    // Start is called before the first frame update
    void Start()
    {
        state = EnemyState.Wander;
        fleeComponent = fleeComponent.gameObject.GetComponent<EnemyFlee>();
        wanderComponent = wanderComponent.gameObject.GetComponent<EnemyMove>();
        seekComponent = seekComponent.gameObject.GetComponent<EnemySeek>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case EnemyState.Wander:
                {
                    if (Vector3.Distance(transform.position, target.position) < fleeDistance)
                    {
                        Debug.Log("switching to Flee");
                        state = EnemyState.Flee;
                        fleeComponent.enabled = true;
                        wanderComponent.enabled = false;
                        seekComponent.enabled = false;
                    }
                        break;
                }
            case EnemyState.Flee:
                {
                    if (Vector3.Distance(transform.position, target.position) >= fleeDistance)
                    {
                        Debug.Log("switching to Wander");
                        state = EnemyState.Wander;
                        fleeComponent.enabled = false;
                        wanderComponent.enabled = true;
                        seekComponent.enabled = false;
                    }
                    break;
                }


        }
    }
}
