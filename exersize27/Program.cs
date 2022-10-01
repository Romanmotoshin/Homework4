void exer27() {
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    int answer = 0;
    
    while (number > 0) {
        answer += number % 10;
        number = number / 10;
    }
    Console.WriteLine(answer);
}

exer27();
