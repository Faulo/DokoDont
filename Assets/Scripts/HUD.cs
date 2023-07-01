using UnityEngine;

public sealed class HUD : MonoBehaviour {
    [SerializeField]
    ModalityBase idlingModality;
    [SerializeField]
    ModalityBase marketingModality;
    [SerializeField]
    ModalityBase jammingModality;
    [SerializeField]
    ModalityBase sleepingModality;

    [Space]
    [SerializeField]
    GameObject buttons;
    [SerializeField]
    GameObject credits;

    [Space]
    [SerializeField]
    int abortTime = 60;

    void Start() {
        idlingModality.TryStart(default);
        buttons.SetActive(true);
        credits.SetActive(false);
    }

    void Update() {
        if (!currentModality.CanOpen(out _)) {
            currentModality = idlingModality;
        }

        if (GameClock.time >= abortTime) {
            GameClock.isEnabled = false;
            buttons.SetActive(false);
            credits.SetActive(true);
        }
    }

    public static ModalityBase currentModality {
        get => m_currentModality;

        set {
            if (m_currentModality != value) {
                if (m_currentModality) {
                    m_currentModality.Close();
                }

                m_currentModality = value;

                if (m_currentModality) {
                    m_currentModality.Start();
                }
            }
        }
    }
    static ModalityBase m_currentModality;

    public static string status;

}
