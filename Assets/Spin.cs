using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    int speed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
}
