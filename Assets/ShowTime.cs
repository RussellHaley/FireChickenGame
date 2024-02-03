using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTime : MonoBehaviour
{
    public TMP_Text clockText;

    // Start is called before the first frame update
    void Start()
    {
        clockText = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // textmeshPro = GetComponent<TextMeshPro>();
        clockText.SetText(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
    }
}
