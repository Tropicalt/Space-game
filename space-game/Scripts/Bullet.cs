using Godot;
using System;

public partial class Bullet : Area2D
{
	[Export]
	public float Speed = 500f;

	public Vector2 Direction = new Vector2(0,-1);
	
	
	_on_area_2d_body_entered();
	GD.print("shot")
}
