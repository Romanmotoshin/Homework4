void exer29() {
    int[] array = new int[8];

    for (int i = 0; i < 8; i++) {
        Console.WriteLine("Введите элемент массива:");
        int el = int.Parse(Console.ReadLine());

        array[i] = el;
    }

    Console.WriteLine("[{0}]", string.Join(", ", array));
}

exer29();
