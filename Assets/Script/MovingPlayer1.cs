using UnityEngine;

public class MovingPlayer1 : MonoBehaviour
{
    [Tooltip("Скорость перемещения платформы")]
    [SerializeField, Range(0, 50)] private float _speedrotation;
    private void Update()
    {
        var translate = new Vector3();

        if (Input.GetKey(KeyCode.W))
        {
            translate.z += 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            translate.z -= 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            translate.x += 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            translate.x -= 1f;
        }

        transform.position += translate * _speedrotation * Time.deltaTime;
    }
}
