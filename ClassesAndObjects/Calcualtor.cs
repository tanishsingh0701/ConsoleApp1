namespace ClassesAndObjects
{
    public class Calcualtor 
    {
        

        public int Add(params int[] numbers) 
        {
            // params modifier
            return 0;
        }

        public static void TryParseExample() 
        {
            int number;
            // This is used when there is need to accept only the desired type value like int in this case
            // TryParse dont throw exception
            var result= int.TryParse("abc", out number);
            if (result) 
            {
                System.Console.WriteLine(number);
            }
            else
            {
                System.Console.WriteLine("Convertsion Failed");
            }
        }

        // and for calling it 
        //object.Add(1,2,3,4);
        // if not use params then need to call like this:- object.Add(new num[]{1,2,3,4,5});


    }
}
