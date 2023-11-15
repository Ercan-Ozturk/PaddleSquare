using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Extents => extents;

    [SerializeField, Min(0f)]
	float
        maxXSpeed = 20f,
		startXSpeed = 8f,
		constantYSpeed = 10f,
        extents = 0.5f;

	Vector2 position, velocity;
    public Vector2 Velocity => velocity;
    
	public void SetXPositionAndSpeed (float start, float speedFactor, float deltaTime)
	{
		velocity.x = maxXSpeed * speedFactor;
		position.x = start + velocity.x * deltaTime;
	}

	
	public Vector2 Position => position;
	public void UpdateVisualization () =>
		transform.localPosition = new Vector3(position.x, 0f, position.y);


    public void Move () => position += velocity * Time.deltaTime;

    public void StartNewGame ()
	{
		position = Vector2.zero;
		UpdateVisualization();
		velocity = new Vector2(startSpeed, -constantYSpeed);
	}

    public void BounceX (float boundary)
	{
		position.x = 2f * boundary - position.x;
		velocity.x = -velocity.x;
	}

	public void BounceY (float boundary)
	{
		position.y = 2f * boundary - position.y;
		velocity.y = -velocity.y;
	}
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
