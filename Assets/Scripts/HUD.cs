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

    void Start() {
        idlingModality.TryStart(default);
    }

    void Update() {
        if (!currentModality.CanOpen(out _)) {
            currentModality = idlingModality;
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
