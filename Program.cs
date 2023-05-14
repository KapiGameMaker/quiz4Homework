class quiz4 {
    static public void Main(String[] args)
    {
       int row = int.Parse(Console.ReadLine());
       int range = int.Parse(Console.ReadLine());
       int checkRange = 1 + range * 2;
       int[] people = new int[row];
       int[] store = new int[row - checkRange + 1];
       for (int i = 0; i < row; i++)
       {
            people[i] = int.Parse(Console.ReadLine());
       }
       
       for (int i = 0 ; i < row - checkRange + 1 ; i ++)
       {
            for(int i2 = 0 ; i2 < checkRange ; i2++)
            {
                store[i] += people[i2 + i];
            }         
       }
       Max(store);
    }
    static void Max(int[] array)
    {
        int max = 0;
        for(int i = 0 ; i < array.Length ; i++)
        {
            if(max >= array[i]) max = max;
            else max = array[i];               
        }
        Console.WriteLine(max);
    }
}
