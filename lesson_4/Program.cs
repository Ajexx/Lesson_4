// Ex - 1

//Article article = new Article(1, "C# Programming", 29.99);
//struct Article
//{
//    public int id;
//    public string title;
//    public double price;

//    public Article()
//    {
//        this.id = 0;
//        this.title = "Default Title";
//        this.price = 0.0;
//    }
//    public Article(int id, string title, double price)
//    {
//        this.id = id;
//        this.title = title;
//        this.price = price;
//    }
//}

// Ex - 2

//Client client1 = new Client(1, "John", "Doe", "Smith", "123 Main St", "555-1234", 5, 250.75);
//struct Client
//{
//    public int id;
//    public string name;
//    public string surname;
//    public string patronymic;
//    public string address;
//    public string telephone_number;
//    public int num_of_orders;
//    public double total_amount_of_orders;
//    public Client()
//    {
//        this.id = 0;
//        this.name = "Default Name";
//        this.surname = "Default Surname";
//        this.patronymic = "Default Patronymic";
//        this.address = "Default Address";
//        this.telephone_number = "Default Telephone Number";
//        this.num_of_orders = 0;
//        this.total_amount_of_orders = 0.0;
//    }

//    public Client(int id, string name, string surname, string patronymic, string address, string telephone_number, int num_of_orders, double total_amount_of_orders)
//    {
//        this.id = id;
//        this.name = name;
//        this.surname = surname;
//        this.patronymic = patronymic;
//        this.address = address;
//        this.telephone_number = telephone_number;
//        this.num_of_orders = num_of_orders;
//        this.total_amount_of_orders = total_amount_of_orders;
//    }
//}

// Ex - 3

//RequestItem requestItem1 = new RequestItem("Item A", 10);
//struct RequestItem
//{
//    public string name;
//    public int quantity;
//    public RequestItem()
//    {
//        this.name = "Default Name";
//        this.quantity = 0;
//    }
//    public RequestItem(string name, int quantity)
//    {
//        this.name = name;
//        this.quantity = quantity;
//    }
//}

// Ex - 4

//struct Request
//{
//    public int id;
//    public string client_name;
//    public string order_date;
//    public string[] request_items;
//    public double order_amount;
//    public Request()
//    {
//        this.id = 0;
//        this.client_name = "Default Name";
//        this.order_date = "Default Date";
//        this.request_items = new string[0];
//        this.order_amount = 0.0;   
//    }
//    public Request(int id, string client_name, string order_date, string[] request_items, double order_amount)
//    {
//        this.id = id;
//        this.client_name = client_name;
//        this.order_date = order_date;
//        this.request_items = request_items;
//        this.order_amount = order_amount;
//    }
//}

// Ex - 5

//Article article = new Article(1, "C# Programming", 29.99, ArticleType.Books);
//struct Article
//{
//    public int id;
//    public string title;
//    public double price;
//    public ArticleType type;

//    public Article()
//    {
//        this.id = 0;
//        this.title = "Default Title";
//        this.price = 0.0;
//        this.type = ArticleType.Electronics;
//    }
//    public Article(int id, string title, double price, ArticleType type)
//    {
//        this.id = id;
//        this.title = title;
//        this.price = price;
//        this.type = type;
//    }
//}
//enum ArticleType
//{
//    Electronics,
//    Clothing,
//    Books,
//    HomeAppliances,
//    Toys
//}

// Ex - 6

//Client client1 = new Client(1, "John", "Doe", "Smith", "123 Main St", "555-1234", 5, 250.75, ClientType.VIP);
//struct Client
//{
//    public int id;
//    public string name;
//    public string surname;
//    public string patronymic;
//    public string address;
//    public string telephone_number;
//    public int num_of_orders;
//    public double total_amount_of_orders;
//    public ClientType type;
//    public Client()
//    {
//        this.id = 0;
//        this.name = "Default Name";
//        this.surname = "Default Surname";
//        this.patronymic = "Default Patronymic";
//        this.address = "Default Address";
//        this.telephone_number = "Default Telephone Number";
//        this.num_of_orders = 0;
//        this.total_amount_of_orders = 0.0;
//        this.type = ClientType.Regular;
//    }

//    public Client(int id, string name, string surname, string patronymic, string address, string telephone_number, int num_of_orders, double total_amount_of_orders, ClientType type)
//    {
//        this.id = id;
//        this.name = name;
//        this.surname = surname;
//        this.patronymic = patronymic;
//        this.address = address;
//        this.telephone_number = telephone_number;
//        this.num_of_orders = num_of_orders;
//        this.total_amount_of_orders = total_amount_of_orders;
//        this.type = type;
//    }
//}

//enum ClientType
//{
//    Regular,
//    VIP,
//    New
//}

// Ex - 7

//struct Request
//{
//    public int id;
//    public string client_name;
//    public string order_date;
//    public string[] request_items;
//    public double order_amount;
//    public PayType pay_type;
//    public Request()
//    {
//        this.id = 0;
//        this.client_name = "Default Name";
//        this.order_date = "Default Date";
//        this.request_items = new string[0];
//        this.order_amount = 0.0;
//        this.pay_type = PayType.CreditCard;
//    }
//    public Request(int id, string client_name, string order_date, string[] request_items, double order_amount, PayType pay_type)
//    {
//        this.id = id;
//        this.client_name = client_name;
//        this.order_date = order_date;
//        this.request_items = request_items;
//        this.order_amount = order_amount;
//        this.pay_type = pay_type;
//    }
//}

//enum PayType
//{
//    CreditCard,
//    PayPal,
//    BankTransfer,
//    CashOnDelivery
//}

// Ex - 8

struct Student
{
    public string name;
    public string surname;
    public string patronymic;
    public string group;
    public int age;
    public int[][] jagged = new int[3][];
    public double average_score;
    public Student()
    {
        this.name = "Default Name";
        this.surname = "Default Surname";
        this.patronymic = "Default Patronymic";
        this.group = "Default Group";
        this.age = 0;
        this.average_score = 0.0;
        for (int i = 0; i < 3; i++)
        {
            jagged[i] = new int[0];
        }
    }
    public Student(string name, string surname, string patronymic, string group, int age, double average_score)
    {
        this.name = name;
        this.surname = surname;
        this.patronymic = patronymic;
        this.group = group;
        this.age = age;
        this.average_score = average_score;
        for (int i = 0; i < 3; i++)
        {
            jagged[i] = new int[0];
        }
    }

    // ============== Methods ==============

    public void AddGrades(int[] grades)
    {
        int[][] newJagged = new int[jagged.Length + 1][];
        for (int i = 0; i < jagged.Length; i++)
        {
            newJagged[i] = jagged[i];
        }
        newJagged[jagged.Length] = grades;
        jagged = newJagged;
    }

    public void GetGrades()
    {
        Console.WriteLine("Grades:");
        foreach (var gradeArray in jagged)
        {
            Console.WriteLine(string.Join(", ", gradeArray));
        }
    }

    public void CalculateAverageScore()
    {
        int totalGrades = 0;
        int sumGrades = 0;
        foreach (var gradeArray in jagged)
        {
            foreach (var grade in gradeArray)
            {
                sumGrades += grade;
                totalGrades++;
            }
        }
        if (totalGrades > 0)
        {
            average_score = (double)sumGrades / totalGrades;
        } 
        else 
        {
            average_score = 0.0;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name} {surname} {patronymic}");
        Console.WriteLine($"Group: {group}");
        Console.WriteLine($"Average Score: {average_score:F2}");
    }
}