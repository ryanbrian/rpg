using Godot;
using System;
//using character;

public partial class player : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		character a= new character();
		a.init();
		GD.Print(a.atk);
		GD.Print("hi");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionPressed("ui_up")){
			Position+=new Vector2(0,-1);
		}
		if(Input.IsActionPressed("ui_down")){
			Position+=new Vector2(0,1);
		}
		if(Input.IsActionPressed("ui_left")){
			Position+=new Vector2(-1,0);
		}
		if(Input.IsActionPressed("ui_right")){
			Position+=new Vector2(1,0);
		}
	}
}
