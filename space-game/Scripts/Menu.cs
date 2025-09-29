using Godot;
using System;


public partial class Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	var main= ResourceLoader.Load<PackedScene>("res://Scenes/main.tscn").Instantiate();
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void StartButtonPressed() {
		GetTree().ChangeSceneToFile("res://Scenes/main.tscn");
		GD.Print("pressed");
	}
	
	public void ExitButtonPressed() {
		
	}
}
