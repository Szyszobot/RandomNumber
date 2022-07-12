Random rnd = new Random();
int num = rnd.Next(0, 100);
Console.WriteLine(num);
String str = Convert.ToString(num);
File.WriteAllText(@"C:\Users\jedrzej.szyszka\Desktop\Results\randomnumber.txt", str);

