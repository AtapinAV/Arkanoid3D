using UnityEngine;

public class MovingPlayer2 : MonoBehaviour
{
    [Tooltip("Скорость перемещения платформы")]
    [SerializeField, Range(0, 50)] private float _speedrotation;
    private void Update()
    {
        var translate = new Vector3();

        if (Input.GetKey(KeyCode.UpArrow))
        {
            translate.z += 1f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            translate.z -= 1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            translate.x += 1f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            translate.x -= 1f;
        }

        transform.position += translate * _speedrotation * Time.deltaTime;
    }
}
