using Godot;
using System;

public partial class NewScript : Node
{
}
using Godot;
using System;

public partial class Bullet : Area2D
{
	[Export]
	public float Speed = 500f;

	public Vector2 Direction = Vector2.RIGHT;

	public override void _Process(double delta)
	{
		Position += Direction * Speed * (float)delta;

		// Destroy bullet if off screen
		if (!GetViewportRect().HasPoint(GlobalPosition))
			QueueFree();
	}
}
