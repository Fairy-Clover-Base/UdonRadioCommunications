
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon.Common.Interfaces;

namespace UdonRadioCommunication
{
    public class Transmitter : UdonSharpBehaviour
    {
        [UdonSynced][HideInInspector] public bool active;
        [UdonSynced] public float frequency = 122.6f;

        public void Activate()
        {
            active = true;
            Debug.Log($"[{gameObject.name}] Activated");
        }
        public void Deactivate()
        {
            active = false;
            Debug.Log($"[{gameObject.name}] Deactivated");
        }
    }
}
