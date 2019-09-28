using System;
using UnityEngine;

namespace UnityBase.Variable
{
    [CreateAssetMenu(menuName="Unity Base/Variable/Int")]
    public class IntVariable: ScriptableObject, ISerializationCallbackReceiver {
        [SerializeField]
        private int m_value = 0;
    
        [NonSerialized]
        public int value;
    
        public void OnAfterDeserialize() {
            value = m_value;
        }
    
        public void OnBeforeSerialize() {
    
        }
    }
}
