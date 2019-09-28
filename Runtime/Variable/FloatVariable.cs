using System;
using UnityEngine;

namespace UnityBase.Variable
{
    [CreateAssetMenu(menuName="Unity Base/Variable/Float")]
    public class FloatVariable: ScriptableObject, ISerializationCallbackReceiver {
        [SerializeField]
        private float m_value = 0;
    
        [NonSerialized]
        public float value;
    
        public void OnAfterDeserialize() {
            value = m_value;
        }
    
        public void OnBeforeSerialize() {
    
        }
    }
}
