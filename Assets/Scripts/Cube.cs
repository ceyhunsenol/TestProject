using UnityEngine;

public class Cube : MonoBehaviour, IWalking
{
    public void Start()
    {
        InvokeRepeating(nameof(Walk), 2F, 2F);
    }

    public void Walk()
    {
        print("Cube.Walk");
        transform.position = Vector3.up * 1;
    }
}