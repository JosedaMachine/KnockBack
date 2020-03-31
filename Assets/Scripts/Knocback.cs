using UnityEngine;

public class Knocback : MonoBehaviour {
	#region Variables
	public bool knockBack;
	public float thrust;

	Rigidbody2D rb;
	#endregion

	#region Unity Methods
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
	}

    void Update()
    {
		//if (knockBack)
		//{
		//	knockBack = !knockBack;
		//	rb.AddForce(transform.right * thrust, ForceMode2D.Force);
		//}

		if (knockBack)
		{
			knockBack = !knockBack;
			//Ahora habria que poner segun el punto de contacto, hacia donde empujar.
			rb.AddForce(transform.right * -thrust);
			rb.AddForce(transform.up * thrust);
		}
	}
	#endregion

	#region Personal Methods
	#endregion

}
