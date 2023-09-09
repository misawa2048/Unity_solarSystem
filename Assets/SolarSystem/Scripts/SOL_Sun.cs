using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sol
{
    [SelectionBase]
    public class SOL_Sun : MonoBehaviour
    {
        [SerializeField] GameObject m_targetGo;
        [SerializeField, Range(0, 1)] float m_lerpRate = 1f; 

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Quaternion lookRot = Quaternion.LookRotation(m_targetGo.transform.position - transform.position); 
            transform.rotation = Quaternion.Lerp(transform.rotation,lookRot,m_lerpRate);
        }
    }
}
