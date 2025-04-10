using UnityEngine;

public class WindowRotation : MonoBehaviour
{
    public GameObject window; // Ваш объект окна
    private Transform pivot; // Пустой объект

    void Start()
    {
        // Создаем пустой объект и устанавливаем его как родительский
        pivot = new GameObject("RotationPivot").transform;
        pivot.position = window.transform.position + new Vector3(window.transform.localScale.x / 2, -window.transform.localScale.y / 2, 0);
        window.transform.SetParent(pivot, true);
    }

    void Update()
    {
        // Вращаем пустой объект
        pivot.Rotate(Vector3.up * Time.deltaTime * 20); // Пример вращения
    }
}