using System;
class Person {
	string name;
	string address;
	int phone;
	string email;
	public Person()
	{

	}
	public Person(string n, string a, int p, string e) {
		name = n;
		address = a;
		phone = p;
		email = e;
	} 
	public string getName() {
		return name;
	}	public string getAddress() {
		return address;
	}	public int getPhone() {
		return phone;
	}	public string getEmail() {
		return email;
	}
	public void setName(string n) {
		name = n;
	}
	public void setAddress(string a) {
		address = a;
	}
	public void setPhone(int p) {
		phone = p;
	}
	public void setEmail(string e) {
		email = e;
	}
	public override string ToString() {
		return "\nName: "+name+"\nAddress: "+address+"\nPhone number: "+phone+"\nEmail address: "+email;
	}
}