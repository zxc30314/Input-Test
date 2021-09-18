using UnityEngine;

[AddComponentMenu("Camera-Control/3dsMax Camera Style")]
public class CameraControll : MonoBehaviour
{
    [SerializeField] private InputAdaptor _adaptor;
    public Transform target;
    public Vector3 targetOffset;
    public float distance = 5.0f;
    public float maxDistance = 20;
    public float minDistance = .6f;
    public float xSpeed = 200.0f;
    public float ySpeed = 200.0f;
    public int yMinLimit = -80;
    public int yMaxLimit = 80;
    public int zoomRate = 40;
    public float panSpeed = 0.3f;
    public float zoomDampening = 5.0f;
    private float currentDistance;
    private Quaternion currentRotation;
    private float desiredDistance;
    private Quaternion desiredRotation;
    private Vector3 position;
    private Quaternion rotation;

    private float xDeg;
    private float yDeg;

    private void Start()
    {
        Init();
    }

    /*
     * Camera logic on LateUpdate to only update after all character movement logic has been handled. 
     */
    private void LateUpdate()
    {
        var inputData = _adaptor.GetData();
        // If Control and Alt and Middle button? ZOOM!
        if (inputData.GetScrollButton)
            desiredDistance -= inputData.Delta.y * Time.deltaTime * zoomRate * 0.125f *
                               Mathf.Abs(desiredDistance);

        // If middle mouse and left alt are selected? ORBIT
        if (inputData.GetFristButton)
        {
            xDeg += inputData.Delta.x * xSpeed * 0.02f;
            yDeg -= inputData.Delta.y * ySpeed * 0.02f;
            ////////OrbitAngle

            //Clamp the vertical axis for the orbit
            yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);
            // set camera rotation 
            desiredRotation = Quaternion.Euler(yDeg, xDeg, 0);
            currentRotation = transform.rotation;
            rotation = Quaternion.Lerp(currentRotation, desiredRotation, Time.deltaTime * zoomDampening);
            transform.rotation = rotation;
        }

        if (!inputData.GetFristButton && currentRotation != desiredRotation)
        {
            currentRotation = transform.rotation;
            rotation = Quaternion.Lerp(currentRotation, desiredRotation, Time.deltaTime * zoomDampening);
            transform.rotation = rotation;
        }

        ////////Orbit Position
        // affect the desired Zoom distance if we roll the scrollwheel
        desiredDistance -= inputData.Scroll * Time.deltaTime * zoomRate *
                           Mathf.Abs(desiredDistance);
        //clamp the zoom min/max
        desiredDistance = Mathf.Clamp(desiredDistance, minDistance, maxDistance);
        // For smoothing of the zoom, lerp distance
        currentDistance = Mathf.Lerp(currentDistance, desiredDistance, Time.deltaTime * zoomDampening);

        // calculate position based on the new currentDistance 
        position = target.position - (rotation * Vector3.forward * currentDistance + targetOffset);
        transform.position = position;
    }

    private void OnEnable()
    {
        Init();
    }

    public void Init()
    {
        //If there is no target, create a temporary target at 'distance' from the cameras current viewpoint
        if (!target)
        {
            var go = new GameObject("Cam Target");
            go.transform.position = transform.position + transform.forward * distance;
            target = go.transform;
        }

        distance = Vector3.Distance(transform.position, target.position);
        currentDistance = distance;
        desiredDistance = distance;

        //be sure to grab the current rotations as starting points.
        position = transform.position;
        rotation = transform.rotation;
        currentRotation = transform.rotation;
        desiredRotation = transform.rotation;

        xDeg = Vector3.Angle(Vector3.right, transform.right);
        yDeg = Vector3.Angle(Vector3.up, transform.up);
    }

    private static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
        {
            angle += 360;
        }

        if (angle > 360)
        {
            angle -= 360;
        }

        return Mathf.Clamp(angle, min, max);
    }
}

internal struct InputData
{
    public Vector2 Delta;
    public float Scroll;
    public bool GetFristButton;
    public bool GetScrollButton;
}