using UnityEngine;

public sealed class CanvasController : MonoBehaviour {
    public void InstantiatePrefab() {
        InstantiatePrefab(default);
    }
    public void InstantiatePrefab(GameObject context) {
        Instantiate(gameObject);
        if (context) {
            Destroy(context.transform.root.gameObject);
        }
    }
    public void QuitGame() {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
