using UnityEngine;
using Unity.Robotics.ROSTCPConnector;

public class ROSManager : MonoBehaviour
{
    private static ROSManager instance;

    void Awake()
    {
        // Check if there's already an instance and we're not it
        if (instance != null && instance != this)
        {
            Debug.LogWarning("🟡 Duplicate ROSManager found. Skipping initialization.");
            return;  // ✅ Don’t destroy or re-initialize
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        ROSConnection ros = ROSConnection.GetOrCreateInstance();
        Debug.Log($"✅ ROSManager initialized. ROSConnection ID: {ros.GetHashCode()}");
    }

    public static ROSConnection Ros => ROSConnection.GetOrCreateInstance();
}
