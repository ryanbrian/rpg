using Godot;
using System;
//using character;

public partial class player : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		character a= new character();
		a.job = character.job_type.Spanker;
		a.init();
		GD.Print(a.atk);
		GD.Print("hi");
	}

	public partial class playerBody:Area2D{
		/*private void onBodyEnter(PhysicsBody2D body){
			GD.Print("it had happened");
		}*/


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
