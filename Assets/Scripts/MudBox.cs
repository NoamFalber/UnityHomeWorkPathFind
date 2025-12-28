using System;
using UnityEngine;
using UnityEngine.AI;
public class MudBox : MonoBehaviour
{
    [SerializeField] private GameObject mainAgentObj;
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == mainAgentObj)
        {
            Debug.Log($"{collision.gameObject.name}");
            mainAgentObj.GetComponent<NavMeshAgent>().speed /= 2;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject == mainAgentObj)
        {
            mainAgentObj.GetComponent<NavMeshAgent>().speed *= 2;
        }
    }
}