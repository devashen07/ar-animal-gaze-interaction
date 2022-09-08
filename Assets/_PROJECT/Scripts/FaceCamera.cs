using UnityEngine;

[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour
{
    #region VARIABLES
    protected Transform m_Camera;
    protected Vector3 targetAngle = Vector3.zero;
    #endregion

    #region UNITY EVENTS
    public void Start()
    {
        m_Camera = Camera.main.transform;
    }

    public void Update()
    {
        transform.LookAt(m_Camera);
        targetAngle = transform.localEulerAngles;
        targetAngle.x = 0;
        targetAngle.z = 0;
        transform.localEulerAngles = targetAngle;
    }
    #endregion
}
