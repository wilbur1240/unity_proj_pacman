using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;

public class ROS2MessageDebug : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Testing Float32MultiArrayMsg: " + typeof(Float32MultiArrayMsg).FullName);

        var layout = new MultiArrayLayoutMsg();
        var data = new float[] {1.0f, 2.0f};
        var msg = new Float32MultiArrayMsg(layout, data);
        Debug.Log("Created test msg: " + string.Join(", ", msg.data));

        ROSConnection.GetOrCreateInstance().Subscribe<Float32MultiArrayMsg>(
            "/debug_test_pose", TestReceive);
    }

    void TestReceive(Float32MultiArrayMsg msg)
    {
        Debug.Log("Received message from /debug_test_pose: " + string.Join(", ", msg.data));
    }
}
