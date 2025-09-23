using Godot;
using System;

public partial class Killzone : Area2D
{ 
	public void _OnReady() {
	GD.Print("It works");
	}
	
	public void OnBodyEntered(Node2D body) {
	GD.Print("It works")
	}
}
