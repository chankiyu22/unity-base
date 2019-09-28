using System;
using UnityEngine;

namespace UnityBase.Variable
{
    [CreateAssetMenu(menuName="Unity Base/Variable/Bool")]
    public class BoolVariable: ScriptableObject, ISerializationCallbackReceiver {
        [SerializeField]
        private bool m_value = false;
    
        [NonSerialized]
        public bool value;
    
        public void OnAfterDeserialize() {
            value = m_value;
        }
    
        public void OnBeforeSerialize() {
    
        }
    }
}
