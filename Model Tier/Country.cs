using System;

public class Country
{	// static data
	private String name;
	private int id, metal, oil, bonds;
	private int[] neighbors;
	// dynamic data
	private int user, infantry, artillery;

	//constructor
	public Country(String name, int id, int[] neighbors, int metal, int oil, int bonds)
	{
		this.name = name;
		this.id = id;
		this.neighbors = neighbors;
		this.metal = metal;
		this.oil = oil;
		this.bonds = bonds;
		this.user = this.infantry = this.artillery = 0;
	}

	// get static data functions
	public String GetName() { return this.name; }
	public int GetId() { return this.id; }
	public int GetMetal() { return this.metal; }
	public int GetOil() { return this.oil; }
	public int GetBonds() { return this.bonds; }
	public int[] GetNeighbors() { return this.neighbors; }

	public Boolean IsNeighbor(int country) 
	{
		for (int i = 0; i < this.neighbors.Length; i++)
			if (neighbors[i] = country)
				return true;
		return false;
	}

	// get dynamic data functions
	public int GetUser() { return this.user; }
	public int GetInfantry() { return this.infantry; }
	public int GetArtillery() { return this.artillery; }
	// change dynamic data functions
	public void SetUser(int user) { this.user = user; }
	public void SetInfantry(int infantry) { this.infantry = infantry; }
	public void AddInfantry(int num) { this.infantry += num; }
	public void RemoveInfantry(int num) { this.infantry -= num; }
	public void SetArtillery(int artillery) { this.artillery = artillery; }
	public void AddArtillery(int num) { this.artillery += num; }
	public void RemoveArtillery(int num) { this.artillery -= num; }
}
