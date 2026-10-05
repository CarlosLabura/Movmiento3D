using Unity.Cinemachine;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float ZoomBounds = 3;
    private float DefualtZoom;
    [SerializeField] CinemachineFollow CMF;
    void Start()
    {
        DefualtZoom = CMF.FollowOffset.z;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) && CMF.FollowOffset.z > DefualtZoom - ZoomBounds)
        {
            CMF.FollowOffset.z -= Time.deltaTime*2;
        } 
        else if (Input.GetKey(KeyCode.X) && CMF.FollowOffset.z < DefualtZoom + ZoomBounds)
        {
            CMF.FollowOffset.z += Time.deltaTime*2;
        }
    }
}
