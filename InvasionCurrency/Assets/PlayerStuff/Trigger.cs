using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    private UnityEvent healthDrain;
    public UnityEvent triggerExitEvent;
    public UnityEvent triggerEnterEvent;
 public void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

   public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        Debug.Log("I have eneterd");
    }

    public void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
        
        Debug.Log("I have left");
    }
}
