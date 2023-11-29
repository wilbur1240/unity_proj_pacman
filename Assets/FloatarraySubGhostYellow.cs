using UnityEngine;
using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient
{
    public class FloatarraySubGhostYellow : UnitySubscriber<MessageTypes.Std.Float32MultiArray>
    {
        public Transform Transform_target;
        private float[] data;
        private bool isMessageReceived;

        protected override void Start()
        {
            base.Start();
        }

        private void Update()
        {
            if (isMessageReceived)
                ProcessMessage();
        }

        private void ProcessMessage()
        {
            // Access the received Float32MultiArray data
            if (data != null)
            {
                Debug.Log("Received GhostYellow position: " + string.Join(", ", data));
                Transform_target.position = new Vector3((float)data[0], Transform_target.position.y , (float)data[1]);
                
            }
            isMessageReceived = false;
        }

        protected override void ReceiveMessage(Float32MultiArray message)
        {
            // Handle the received Float64MultiArray message
            data = message.data;
            isMessageReceived = true;
        }
    }
}
