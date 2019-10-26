using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager2D : MonoBehaviour
{

    public bool IsTrigger;
    public string TargetObjectTagName = "Target";
    
    public UnityEngine.Events.UnityEvent OnHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsTrigger && collision.tag == TargetObjectTagName)
            OnHit.Invoke();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
}
