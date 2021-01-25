using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Math
    // VOORBEELD: Math is een bestaand project - dit is een bestaand project - we willen dat dit
    // automatisch getest gaat worden. "Schrijf eens wat testen voor wat klassen" - vaak gevraagd,
    // maar nooit tijd voor. TESTDRIVEN DEVELOPMENT?

    //UNITTEST klasse heeft verantwoordelijkheid om klasse te testen/
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}