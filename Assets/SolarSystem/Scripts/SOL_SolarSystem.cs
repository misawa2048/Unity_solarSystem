using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sol
{
    public class SOL_SolarSystem : MonoBehaviour
    {
        [SerializeField] GameObject m_panelPrefab;
        [SerializeField] GameObject m_sunGo;
        [SerializeField] GameObject m_targetGo;

        // Start is called before the first frame update
        void Start()
        {
            for(int y = -5; y < 6; y++)
            {
                for(int x = -10; x < 10; x++)
                {
                    SOL_Panel panel = Instantiate(m_panelPrefab).GetComponent<SOL_Panel>();
                    panel.transform.SetParent(transform, false);
                    panel.transform.localPosition = new Vector3(x, y, 0f);
                    panel.targetGo = m_targetGo;
                    panel.sunGo = m_sunGo;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
