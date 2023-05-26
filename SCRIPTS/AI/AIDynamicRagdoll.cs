 

using FIRS.Attributes;
using FIRS.SystemModules;
using UnityEngine;

namespace FIRS.AIModules
{
    [HideScriptField]
    [AddComponentMenu("FIRS/AI Modules/Common/Dynamic Ragdoll/AI Dynamic Ragdoll")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Animator))]
    public sealed class AIDynamicRagdoll : DynamicRagdoll
    {
        /// <summary>
        /// Override this method to return animator component of the ragdoll character.
        /// Use GetComponent<Animator>() method.
        /// </summary>
        /// <param name="animator">Animator component of the ragdoll character.</param>
        protected override void CopyAnimator(out Animator animator)
        {
            animator = GetComponent<Animator>();
        }
    }
}