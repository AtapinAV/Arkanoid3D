using UnityEngine;

public class TriggerGates : MonoBehaviour
{
    [Tooltip("Жизни первого игрока")]
    [SerializeField, Range(1f, 100f)] private int _heal;
    private void OnTriggerEnter(Collider other)
    {
        _heal--;
        if (_heal <= 0)
        {
            Debug.Log("Win player 2");            
            UnityEditor.EditorApplication.isPaused = true;
        }       
    }
}
