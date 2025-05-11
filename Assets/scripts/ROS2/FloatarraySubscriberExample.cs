using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;

public class FloatarraySubscriberExample : MonoBehaviour
{
    // [Tooltip("Transform to be moved according to received ROS message")]
    public Transform Transform_target;

    // [Tooltip("ROS topic to subscribe to (e.g., /pacman_pose)")]
    public string topicName;

    private ROSConnection ros;
    private float[] data;
    private bool isMessageReceived = false;

    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        ros.Subscribe<Float32MultiArrayMsg>(topicName, ReceiveMessage);
    }

    void Update()
    {
        if (isMessageReceived)
        {
            ProcessMessage();
            isMessageReceived = false;
        }
    }

    void ReceiveMessage(Float32MultiArrayMsg message)
    {
        data = message.data;
        isMessageReceived = true;
    }

    void ProcessMessage()
    {
        if (data != null && data.Length >= 2 && Transform_target != null)
        {
            Debug.Log("Received Pacman position: " + string.Join(", ", data));
            Transform_target.position = new Vector3(data[0], Transform_target.position.y, data[1]);
        }
    }
}
