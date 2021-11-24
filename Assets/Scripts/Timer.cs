using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private float initialTime = 60f;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
       if (currentTime > 0)
       {
           currentTime -= Time.deltaTime;

           TimeSpan span = TimeSpan.FromSeconds(currentTime);
           timeText.text = span.ToString(@"mm\:ss");
           return; 
       } 

       Debug.Log("Kill all players!");
    }
}
