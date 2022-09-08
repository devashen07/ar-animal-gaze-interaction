using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class GazeInteraction : MonoBehaviour
{
    #region VARIABLES
    protected List<InformationController> m_InformationList = new List<InformationController>();
    #endregion

    #region UNITY EVENTS
    public void Start()
    {
        m_InformationList = FindObjectsOfType<InformationController>().ToList();
    }

    public void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInformation"))
            {
                OpenInfo(go.GetComponent<InformationController>());
            }
            else
            {
                CloseAll();
            }
        }
    }
    #endregion

    #region HELPER FUNCTIONS
    private void OpenInfo(InformationController desiredInfo)
    {
        foreach (var info in m_InformationList)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    private void CloseAll()
    {
        foreach (var info in m_InformationList)
        {
            info.CloseInfo();
        }
    }
    #endregion
}
