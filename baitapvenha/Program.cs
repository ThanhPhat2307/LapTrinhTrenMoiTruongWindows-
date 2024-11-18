using baitapvenha;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
            {
                new Student(1, "Alice", 16),
                new Student(2, "Bob", 17),
                new Student(3, "Anna", 15),
                new Student(4, "David", 19),
                new Student(5, "Alex", 18)
            };

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("a. Danh sach toan bo hoc sinh:");
        students.ForEach(student => student.Display());

        // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
        Console.WriteLine("\nb. Danh sach hoc sinh co tuoi tu 15 đen 18:");
        var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
        ageRangeStudents.ToList().ForEach(student => student.Display());

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        Console.WriteLine("\nc. Danh sach hac sinh co ten bat dau bang chu 'A':");
        var nameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
        nameStartsWithA.ToList().ForEach(student => student.Display());

        // d. Tính tổng tuổi của tất cả học sinh
        Console.WriteLine("\nd. Tong tuoi cua tat ca hoc sinh:");
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"Tổng tuổi: {totalAge}");

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        if (oldestStudent != null)
            oldestStudent.Display();

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
        Console.WriteLine("\nf. Danh sach hoc sinh sap xep theo tuoi tang dan:");
        var sortedStudents = students.OrderBy(s => s.Age);
        sortedStudents.ToList().ForEach(student => student.Display());
    }
}