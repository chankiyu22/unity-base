using System;
using UnityEngine;

namespace UnityBase.Variable
{
    [CreateAssetMenu(menuName="Unity Base/Variable/String")]
    public class StringVariable: ScriptableObject, ISerializationCallbackReceiver {
        [SerializeField]
        private string m_value = "";
    
        [NonSerialized]
        public string value;
    
        public void OnAfterDeserialize() {
            value = m_value;
        }
    
        public void OnBeforeSerialize() {
    
        }
    }
}
