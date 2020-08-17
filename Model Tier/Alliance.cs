using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Alliance
{	// private data fields
	private List<User> users;
	private int metal, oil, bonds, infantry, artillery;

	// constructor
	public Alliance(List<int> users, int metal, int oil, int bonds, int infantry, int artillery)
	{
		this.users = users;
		this.metal = metal;
		this.oil = oil;
		this.bonds = bonds;
		this.infantry = infantry;
		this.artillery = artillery;
	}

	// get methods
	public int GetMetal() { return this.metal; }
	public int GetOil() { return this.oil; }
	public int GetBonds() { return this.bonds; }
	public int GetInfantry() { return this.infantry; }
	public int GetArtillery() { return this.artillery; }
	public List<User> GetUsers() { return this.users; }
	public Boolean HasUser(User user) { return this.users.Contains(user); }

	// changes users
	public void AddUser(User user) { this.users.Add(user); }
	public void RemoveUser(User user)
    {
		this.users.Remove(user);
		int betrayed = this.users.Count;
		user.RemoveMetal(this.metal * betrayed);
		user.RemoveOil(this.oil * betrayed);
		user.RemoveBonds(this.bonds * betrayed);
		user.RemoveInfantry(this.infantry * betrayed);
		user.RemoveArtillery(this.artillery * betrayed);
		foreach (User item in this.users) {
			item.AddMetal(this.metal);
			item.AddOil(this.oil);
			item.AddBonds(this.bonds);
			item.AddInfantry(this.infantry);
			item.AddArtillery(this.artillery);
        }
    }
	// change payments
	public void SetMetal(int metal) { this.metal = metal; }
	public void SetOil(int oil) { this.oil = oil; }
	public void SetBonds(int bonds) { this.bonds = bonds; }
	public void SetInfantry(int infantry) { this.infantry = infantry; }
	public void SetArtillery(int artillery) { this.artillery = artillery; }
}
