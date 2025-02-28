using UnityEngine;

public class MouseControls : MonoBehaviour
{
    public Transform target;
    public float transitionspeed = 95f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse Function

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, ray.direction*100f, Color.red, 1f);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {

            //Lerp Move Between two points at given time
            target.position = Vector3.Lerp(target.position, hit.point, transitionspeed * Time.deltaTime);

            //If Clicked on Enemy object
            if(hit.transform.CompareTag("Enemy") && Input.GetButtonDown("Fire1")) 
            {
                Destroy(hit.transform.gameObject);
                            
            }

        }

    }
}
