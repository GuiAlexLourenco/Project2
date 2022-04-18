using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoachMove : MonoBehaviour
{
    public WinLose winScript;

    [SerializeField] private float moveSpeed = 1.0f;
    [SerializeField] private float radius = 3.0f;
    
    private float timeCount = 0;

    public void Update()
    {
        timeCount += Time.deltaTime * moveSpeed;

        float x = Mathf.Cos(timeCount)*radius;
        float y = 2.09f;
        float z = Mathf.Sin(timeCount)*radius;

        transform.position = new Vector3(x, y, z);
    }
}
