using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Atirar : MonoBehaviour
{
    public GameObject spellPrefab;
    static public bool p1Shot;
    static public bool p2Shot;
    public float forceSpeed;
    private float currentForce;
    [SerializeField] private float minForce;
    [SerializeField] private float addForce;
    [SerializeField]private float maxForce;
    [SerializeField]private LineRenderer lineRenderer;
    [SerializeField]private Transform offset;
    [SerializeField] private int trajectorySteps;
    [SerializeField] private float timeStep;    

    // Start is called before the first frame update
    void Start()
    {
        p1Shot = false;
        p2Shot = false;
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Vertical");
        currentForce += input * forceSpeed * Time.deltaTime;
        currentForce = Mathf.Clamp(currentForce, minForce, maxForce);

        ShowTrajectory();
        if (!Turnos.playerTurn && Input.GetKeyDown(KeyCode.LeftShift))
        {            
             Bolas();
            Debug.Log(Turnos.turno);
        }

        if (Turnos.playerTurn && Input.GetKeyDown(KeyCode.RightShift))
        {
            Bolas();
            Debug.Log(Turnos.turno);
        }
    }

    public void ShowTrajectory()
    {

        Vector2 dire = new Vector2(0, 0);
        if (gameObject.CompareTag("P1"))
        {
            dire = offset.right.normalized;
        }
        else if (gameObject.CompareTag("P2"))
        {
            dire = -offset.right.normalized;
        }
        Vector2 startVel = dire * currentForce;
        Vector2 startPos = offset.position;

        lineRenderer.positionCount = trajectorySteps;

        for (int i = 0; i < trajectorySteps; i++)
        {            
                float t = i * timeStep;

            Vector2 pos = startPos + startVel * t + 0.5f * Physics2D.gravity * t * t;

            lineRenderer.SetPosition(i, pos);
        }
    }

    public void Bolas()
    {
        GameObject ball = Instantiate(spellPrefab, offset.position, Quaternion.identity);

        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 flado = new Vector2 (0,0);
            if (gameObject.CompareTag("P1"))
            {
                flado = offset.right.normalized * currentForce;
            }
            else if (gameObject.CompareTag("P2"))
            {
                flado = -offset.right.normalized * currentForce;
            }
                rb.AddForce(flado, ForceMode2D.Impulse);

        }

    }
}
