public class Contact
{
	// свойства класса
	public string Name { get; set; }
	public string Phone { get; set; }
	public string Category { get; set; }

	// конструктор класса
	public Contact(string name, string phone, string category)
	{
		Name = name;
		Phone = phone;
		Category = category;
	}

	// переопределяем ToString для отображения в ListBox
	//Ключевое слово override говорит,
	//что мы заменяем реализацию по умолчанию своей собственной
	public override string ToString()
	{
		return $"{Name} ({Category})";
	}
}