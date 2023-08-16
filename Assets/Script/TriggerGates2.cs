using UnityEngine;

public class TriggerGates2 : MonoBehaviour
{
    [Tooltip("Жизни второго игрока")]
    [SerializeField, Range(1f, 100f)] private int _heal;
    private void OnTriggerEnter(Collider other)
    {
        _heal--;
        if (_heal <= 0)
        {
            Debug.Log("Win player 1");
            UnityEditor.EditorApplication.isPaused = true;
        }
    }
}
