 

using UnityEngine;

namespace FIRS.CoreModules
{
    /// <summary>
    /// Represents base class for all scriptable mapping.
    /// </summary>
    public abstract class ScriptableMapping : ScriptableObject, IScriptableMapping
    {
        /// <summary>
        /// Get mapping length.
        /// </summary>
        public abstract int GetMappingLength();
    }
}