using Godot;
using System;

public class Dog : Node2D
{

	private AnimatedSprite animatedSprite;

	public override void _Ready()
	{
		animatedSprite = GetNode<AnimatedSprite>("Area2D/AnimatedSprite");
	}

	public override void _Process(float delta)
	{
		
	}
	
	public void ChangeAnimation() 
	{
		animatedSprite.Animation = animatedSprite.Animation == "walk" ? "sniff" : "walk";
	}
}
