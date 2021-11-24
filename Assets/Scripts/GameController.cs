using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int timeToDead = 10;
    private float prevTime = 0f;
    
    public bool startTimer = true;
    public float timeUpDuration = 6f;

    public GameObject boss;
    private LookAt lookAt;

    void Start()
    {
        lookAt = boss.GetComponent<LookAt>();
        lookAt.startLookAt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer) {
            prevTime = prevTime + Time.deltaTime;
        }
        
        if (startTimer && prevTime >= timeToDead) {
            prevTime = 0f;
            startTimer = false;
            lookAt.startLookAt = true;
            Invoke("StopLookAt", timeUpDuration);
        } 
        
    }

    void StopLookAt() {
        startTimer = true;
        lookAt.ResetRotation();

    }
}









