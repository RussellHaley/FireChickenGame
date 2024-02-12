using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GamePause : MonoBehaviour
{
    public UnityEvent GamePaused;

    public UnityEvent GameResumed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private bool _paused;
    public void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            _paused = !_paused;

            if (_paused)
            {
                Time.timeScale = 0;
                GamePaused.Invoke();
            }
            else
            {
                Time.timeScale = 1;
                GameResumed.Invoke();
            }
        }
    }
}
