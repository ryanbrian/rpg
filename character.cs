using System;
using Godot;
public class character{
		public int atk,spatk,def,spdef,agi,hlth,luck;
		public string name;
		public enum job_type{
			Spanker,
			Doinker,
			Spankee,
			Zoinks
		}
		public job_type job=job_type.Spanker; 

	public void init(){
		switch (job){
			case job_type.Spanker:
				atk=1;
				spatk=1;
				def=1;
				spdef=1;
				agi=1;
				hlth=1;
				luck=1;
			break;
			case job_type.Doinker:
				atk=1;
				spatk=1;
				def=1;
				spdef=1;
				agi=1;
				hlth=1;
				luck=1;
			break;
			case job_type.Spankee:
				atk=1;
				spatk=1;
				def=1;
				spdef=1;
				agi=1;
				hlth=1;
				luck=1;
			break;
			case job_type.Zoinks:
				atk=2;
				spatk=2;
				def=2;
				spdef=2;
				agi=2;
				hlth=2;
				luck=2;
			break;
		}
	}
}

