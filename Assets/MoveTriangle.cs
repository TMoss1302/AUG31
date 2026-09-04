using UnityEngine;

public class MoveTriangle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // "Get" the sister component of type Transform.
        Transform current = GetComponent<Transform>();

        // Get the position.
        Vector3 position = current.position;

        // Update postioion.
        position.x = position.x+0.01f;

        // Update the original.
        current.position = position;
    }
}
