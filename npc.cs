using Godot;
using System;

public partial class npc : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		character thisdude = new character();
		thisdude.job=character.job_type.Zoinks;
		thisdude.init();
		GD.Print(thisdude.atk+"this is the attack of enemy");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
