using System;
using Godot;
public class character{
		public int atk,spatk,def,spdef,agi,hlth,luck;
		string name;
		enum job{
			spanker,
			doinker,
			spankee,
			zoinks
		}

	public void init(){
			atk=1;
			spatk=1;
			def=1;
			spdef=1;
			agi=1;
			hlth=1;
			luck=1;
	}
}

