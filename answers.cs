//Question One
//1-Sum of Biggest Neighbor 
public static int Challenge(int[] input)
    {

        var distinct = input.Distinct().ToArray();
        var distinctSize = distinct.Length;
        var multiplicity = new int[distinctSize];

        for (int i = 0; i < distinctSize; i++)
        {
            multiplicity[i] = input.Where(r => r == distinct[i]).Count();
        }

        var max = multiplicity.Max();

        int removed = 0;

        for (int i = 0; i < distinctSize; i++)
        {
            if (multiplicity[i] < max - 1)
            {
                removed = removed + multiplicity[i];
            }
        }

        int filteredSize = input.Length - removed;

        var filtered = new int[filteredSize];

        int j = 0;
        for (int i = 0; i < distinctSize; i++)
        {
            if (multiplicity[i] >= max - 1)
            {
                for (int k = 0; k < multiplicity[i]; k++)
                {
                    filtered[j+k] = distinct[i];
                }
                j = j+multiplicity[i];
            }
        }

        int maxValue = filtered[0];

        for (int i = 0; i < filteredSize; i++)
        {
            if (filtered[i]>maxValue)
            {
                maxValue = filtered[i];
            }
        }

        return maxValue*2;
    }



//Question Two
//2-User Class 



//Question Three
//3-John the Robot 




//Question Four
//4-Alexa Settings 





//Question Five
//5- Method Signature  




//Question Sigx
//6- Construction Game