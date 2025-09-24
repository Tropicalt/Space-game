using Godot;
using System;


public partial class Killzone : Area2D
{ 
	
	public PackedScene alien_blue;
	public AnimatedSprite2D new_alien;
	
	public void _OnReady() {
	GD.Print("It works");
	 alien_blue = GD.Load<PackedScene>("res://Scenes/alien_blue.tscn");
	 new_alien = (AnimatedSprite2D) alien_blue.Instantiate();
	}
	
	public void OnBodyEntered(Node2D body) {
		GD.Print("It works");
		var parent = GetParent() as Node2D;
		parent.Visible=false;
	}
}
