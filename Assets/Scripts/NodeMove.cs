using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMove : MonoBehaviour
{
    public Transform nodes;
    public float movespeed = 2f;
    public float waittime = 2f;
    private bool loopnodes = true;

    private Transform[] waypoints;
    private int currentnodeindex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waypoints = new Transform[nodes.childCount];
        for (int i = 0; i < nodes.childCount; i++)
        {
            waypoints[i] = nodes.GetChild(i);

        }

    }

    // Update is called once per frame
    void Update()
    {
        MoveToWaypoint();
    }
    void MoveToWaypoint()
    {
        Transform target = waypoints[currentnodeindex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, movespeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            StartCoroutine(WaitAtWaypoint());
        }
    }
    IEnumerator WaitAtWaypoint()
    {
        yield return new WaitForSeconds(waittime);
        currentnodeindex = loopnodes ? (currentnodeindex + 1) % waypoints.Length : Mathf.Min(currentnodeindex + 1, waypoints.Length);
        
    }
}

