using System;
using System.Collections;
using System.Collections.Generic;

public class User
{	// private data fields
	private String name;
	private int id, metal, oil, bonds, infantry, artillery;
	private List<int> countries;

	// constructor
	public User(String name, int id)
	{
		this.name = name;
		this.id = id;
		this.metal = this.oil = this.bonds = this.infantry = this.artillery = 0;
		this.countries = new List<int>();
	}

	// get methods
	public String GetName() { return this.name; }
	public int GetId() { return this.id; }
	public int GetMetal() { return this.metal; }
	public int GetOil() { return this.oil; }
	public int GetBonds() { return this.bonds; }
	public int GetInfantry() { return this.infantry; }
	public int GetArtillery() { return this.artillery; }
	public List<int> GetCountries() { return this.countries; }
	public Boolean HasCountry(int country) { return this.countries.Contains(country); }
	// set methods
	public void SetMetal(int metal) { this.metal = metal; }
	public void SetOil(int oil) { this.oil = oil; }
	public void SetBonds(int bonds) { this.bonds = bonds; }
	public void SetInfantry(int infantry) { this.infantry = infantry; }
	public void SetArtillery(int artillery) { this.artillery = artillery; }
	public void SetCountries(List<int> countries) { this.countries = countries; }
	// add methods
	public void AddMetal(int num) { this.metal += num; }
	public void AddOil(int num) { this.oil += num; }
	public void AddBonds(int num) { this.bonds += num; }
	public void AddInfantry(int num) { this.infantry += num; }
	public void AddArtillery(int num) { this.artillery += num; }
	public void AddCountry(int country) { this.countries.Add(country); }
	// remove methods
	public void RemoveMetal(int num) { this.metal -= num; }
	public void RemoveOil(int num) { this.oil -= num; }
	public void RemoveBonds(int num) { this.bonds -= num; }
	public void RemoveInfantry(int num) { this.infantry -= num; }
	public void RemoveArtillery(int num) { this.artillery -= num; }
	public void RemoveCountry(int country) { this.countries.Remove(country); }
}
