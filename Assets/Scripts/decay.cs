using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decay : MonoBehaviour
{
    
    public float _Durration;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_Durration > 0)
        {
            _Durration -= Time.deltaTime;
        }

        if (_Durration <= 0)
        {
            Destroy(gameObject);
            // Trigger an action when the countdown is finished
        }
    }
}
