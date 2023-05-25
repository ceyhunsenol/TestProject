using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Process : MonoBehaviour
{
    public void WalkProcess(IWalking walk)
    {
        walk.Walk();
    }
}