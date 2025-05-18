using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node camefrom;
    public List<Node> connections;
    public float gScore;
    public float hScore;
    public float FScore()
    {
        return gScore + hScore;
    }
    
}