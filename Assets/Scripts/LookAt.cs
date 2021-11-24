using UnityEngine;
 
public class LookAt : MonoBehaviour {
 
    public Transform other;
    private Quaternion originalRotation;

    [HideInInspector]
    public bool startLookAt = false;

    private void Start() {
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        if (!startLookAt) {
            return;
        }

        Debug.DrawLine(transform.position,other.position,Color.cyan);
        transform.LookAt(other);
    }

    public void ResetRotation()
    {
        startLookAt = false;
        transform.localRotation = originalRotation;
    }
}





