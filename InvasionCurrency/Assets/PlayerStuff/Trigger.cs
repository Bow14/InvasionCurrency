using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    private UnityEvent healthDrain;
    public UnityEvent triggerExitEvent;
    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        healthDrain.Invoke();
    }

    public void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
