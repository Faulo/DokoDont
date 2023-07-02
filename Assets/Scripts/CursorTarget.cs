using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public sealed class CursorTarget : MonoBehaviour, IPointerDownHandler {
    [SerializeField]
    UnityEvent<GameObject> onMouseDown = new();

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log(this);
        onMouseDown.Invoke(gameObject);
    }

    public void DestroySelf() {
        Destroy(gameObject);
    }
}
