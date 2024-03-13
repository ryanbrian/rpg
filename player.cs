using Godot;
using System;
using "character.cs";

public partial class player : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		character player;
		print(player.atk);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
