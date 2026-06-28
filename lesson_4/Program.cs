// Ex - 1

//public struct Article
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
//class Program
//{
//    static void Main(string[] args)
//    {
//        Article article1 = new Article(1, "C# Programming", 29.99);
//        Console.WriteLine($"Article ID: {article1.id}, Title: {article1.title}, Price: {article1.price}");
//    }
//}

// Ex - 2

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

//class Program
//{
//    static void Main(string[] args)
//    {
//        Client client1 = new Client(1, "John", "Doe", "Smith", "123 Main St", "555-1234", 5, 250.75);
//        Console.WriteLine($"Client ID: {client1.id}," +
//            $" Name: {client1.name} {client1.surname} {client1.patronymic}," +
//            $" Address: {client1.address}," +
//            $" Telephone: {client1.telephone_number}," +
//            $" Number of Orders: {client1.num_of_orders}," +
//            $" Total Amount of Orders: {client1.total_amount_of_orders}");
//    }
//}

// Ex - 3

//class Article
//{
//    public string name;
//    public double price;
//    public Article()
//    {
//        this.name = "Default Name";
//        this.price = 0.0;
//    }
//    public Article(string name, double price)
//    {
//        this.name = name;
//        this.price = price;
//    }
//}

//struct RequestItem
//{
//    public Article article;
//    public int quantity;
//    public RequestItem()
//    {
//        this.article = new Article();
//        this.quantity = 0;
//    }
//    public RequestItem(Article article, int quantity)
//    {
//        this.article = article;
//        this.quantity = quantity;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Article article1 = new Article("Item 1", 29.99);
//        Article article2 = new Article("Item 2", 39.99);
//        RequestItem item1 = new RequestItem(article1, 5);
//        RequestItem item2 = new RequestItem(article2, 10);
//        Console.WriteLine($"Request Item 1: Name: {item1.article.name}, Price: {item1.article.price}, Quantity: {item1.quantity}");
//        Console.WriteLine($"Request Item 2: Name: {item2.article.name}, Price: {item2.article.price}, Quantity: {item2.quantity}");
//    }
//}

// Ex - 4

//class Article
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
//struct RequestItem
//{
//    public Article article;
//    public int quantity;
//    public RequestItem()
//    {
//        this.article = new Article();
//        this.quantity = 0;
//    }
//    public RequestItem(Article article, int quantity)
//    {
//        this.article = article;
//        this.quantity = quantity;
//    }
//}
//struct Request
//{
//    public int id;
//    public Article client_name;
//    public string order_date;
//    public RequestItem[] request_items;
//    public double order_amount;
//    public Request()
//    {
//        this.id = 0;
//        this.client_name = new Article();
//        this.order_date = "Default Date";
//        this.request_items = new RequestItem[0];
//        this.order_amount = 0.0;
//    }
//    public Request(int id, Article client_name, string order_date, RequestItem[] request_items, double order_amount)
//    {
//        this.id = id;
//        this.client_name = client_name;
//        this.order_date = order_date;
//        this.request_items = request_items;
//        this.order_amount = order_amount;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Article article1 = new Article(1, "C# Programming", 29.99);
//        RequestItem item1 = new RequestItem(article1, 5);
//        Request request1 = new Request(1, article1, "2024-06-01", new RequestItem[] { item1 }, 149.95);
//        Console.WriteLine($"Request ID: {request1.id}, Client Name: {request1.client_name.title}, Order Date: {request1.order_date}, Order Amount: {request1.order_amount}");
//    }
//}

// Ex - 5

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
//class Program
//{
//    static void Main(string[] args)
//    {
//        Article article = new Article(1, "C# Programming", 29.99, ArticleType.Books);
//        Console.WriteLine($"Article ID: {article.id}, Title: {article.title}, Price: {article.price}, Type: {article.type}");
//    }
//}
// Ex - 6
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

//class Program
//{
//    static void Main(string[] args)
//    {
//        Client client1 = new Client(1, "John", "Doe", "Smith", "123 Main St", "555-1234", 5, 250.75, ClientType.VIP);
//        Console.WriteLine($"Client ID: {client1.id}," +
//            $" Name: {client1.name} {client1.surname} {client1.patronymic}," +
//            $" Address: {client1.address}," +
//            $" Telephone: {client1.telephone_number}," +
//            $" Number of Orders: {client1.num_of_orders}," +
//            $" Total Amount of Orders: {client1.total_amount_of_orders}," +
//            $" Type: {client1.type}");
//    }
//}

// Ex - 7

//class Article
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
//class RequestItem
//{
//    public Article article;
//    public int quantity;
//    public RequestItem()
//    {
//        this.article = new Article();
//        this.quantity = 0;
//    }
//    public RequestItem(Article article, int quantity)
//    {
//        this.article = article;
//        this.quantity = quantity;
//    }
//}
//struct Request
//{
//    public int id;
//    public Article client_name;
//    public string order_date;
//    public RequestItem[] request_items;
//    public double order_amount;
//    public PayType pay_type;
//    public Request()
//    {
//        this.id = 0;
//        this.client_name = new Article();
//        this.order_date = "Default Date";
//        this.request_items = new RequestItem[0];
//        this.order_amount = 0.0;
//        this.pay_type = PayType.CreditCard;
//    }
//    public Request(int id, Article client_name, string order_date, RequestItem[] request_items, double order_amount, PayType pay_type)
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
//class Program
//{
//    static void Main(string[] args)
//    {
//        Article client = new Article(1, "John Doe", 100.0);
//        RequestItem[] requestItems = {
//            new RequestItem(new Article(2, "Item 1", 50.0), 2),
//            new RequestItem(new Article(3, "Item 2", 99.95), 1)
//        };
//        Request request1 = new Request(1, client, "2024-06-01", requestItems, 149.95, PayType.PayPal);
//        Console.WriteLine($"Request ID: {request1.id}," +
//            $" Client Name: {request1.client_name.title}," +
//            $" Order Date: {request1.order_date}," +
//            $" Order Amount: {request1.order_amount}," +
//            $" Payment Type: {request1.pay_type}");
//    }
//}


// Ex - 8

//struct Student
//{
//    public string name;
//    public string surname;
//    public string patronymic;
//    public string group;
//    public int age;
//    public int[][] jagged = new int[3][];
//    public double average_score;

//    private string[] grades = { "Math", "Physics", "Programming" };
//    public Student()
//    {
//        this.name = "Default Name";
//        this.surname = "Default Surname";
//        this.patronymic = "Default Patronymic";
//        this.group = "Default Group";
//        this.age = 0;
//        this.average_score = 0.0;
//        for (int i = 0; i < 3; i++)
//        {
//            jagged[i] = new int[0];
//        }
//    }
//    public Student(string name, string surname, string patronymic, string group, int age, double average_score)
//    {
//        this.name = name;
//        this.surname = surname;
//        this.patronymic = patronymic;
//        this.group = group;
//        this.age = age;
//        this.average_score = average_score;
//        for (int i = 0; i < 3; i++)
//        {
//            jagged[i] = new int[0];
//        }
//    }

//    // ============== Methods ==============

//    public void SetGrades(int studentIndex, int grade)
//    {
//        int[] grades = new int[jagged[studentIndex].Length + 1];
//        Array.Copy(jagged[studentIndex], grades, jagged[studentIndex].Length);
//        grades[jagged[studentIndex].Length] = grade;
//        jagged[studentIndex] = grades;
//    }
//    public int GetGrades(int studentIndex, int gradeIndex)
//    {
//        return jagged[studentIndex][gradeIndex];
//    }
//    public double CalculateAverageScore(int subjectIndex)
//    {   
//        int[] grades = jagged[subjectIndex];
//        if ( grades.Length == 0)
//        {
//            average_score = 0.0;
//            return average_score;
//        }
//        int sumGrades = 0;
//        foreach (var grade in grades)
//        {
//             sumGrades += grade;
//        }
//        average_score = (double)sumGrades / grades.Length;
//        return average_score;
//    }
//    public void PrintInfo()
//    {
//        Console.WriteLine($"Name: {name} {surname} {patronymic}");
//        Console.WriteLine($"Group: {group}");
//        for (int i = 0; i < jagged.Length; i++)
//        {
//            Console.WriteLine($"{grades[i]}: {string.Join(", ", jagged[i])}");
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student1 = new Student("John", "Doe", "Smith", "CS101", 20, 0.0);
//        student1.SetGrades(0, 85);
//        student1.SetGrades(1, 90);
//        student1.SetGrades(2, 95);
//        double average = student1.CalculateAverageScore(0);
//        student1.PrintInfo();
//        Console.WriteLine($"Average Score: {average}");
//    }
//}
