void exer25() {
    Console.WriteLine("Введите число A:");
    int numberA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int numberB = int.Parse(Console.ReadLine());
    int answer = 1;

    for(int i = 0; i < numberB; i++) {
        answer *= numberA;
    }
    Console.WriteLine(answer);
}

exer25();
