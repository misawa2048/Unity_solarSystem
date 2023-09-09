using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sol
{
    public class SOL_Panel : MonoBehaviour
    {
        public GameObject sunGo;
        public GameObject targetGo;
        [SerializeField,Range(0,1)] float m_lerpRate=0.1f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 p2t = (targetGo.transform.position - transform.position).normalized;
            Vector3 p2s = (sunGo.transform.position - transform.position).normalized;
            Quaternion rot = Quaternion.LookRotation((p2t + p2s)*0.5f);
            transform.rotation = Quaternion.Lerp(transform.rotation, rot, m_lerpRate);
        }
    }
}
