using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class InformationController : MonoBehaviour
{
    #region PROPERTIES
    private const float SPEED = 6f;
    #endregion

    #region VARIABLES 
    [SerializeField]
    protected Transform m_InfoSection;

    protected Vector3 m_Scale = Vector3.zero;
    #endregion

    #region UNITY EVENTS
    public void Update()
    {
        m_InfoSection.localScale = Vector3.Lerp(m_InfoSection.localScale, m_Scale, Time.deltaTime * SPEED);
    }
    #endregion


    #region PUBLIC API
    public void OpenInfo()
    {
        m_Scale = Vector3.one;
    }

    public void CloseInfo()
    {
        m_Scale = Vector3.zero;
    }
    #endregion
}
