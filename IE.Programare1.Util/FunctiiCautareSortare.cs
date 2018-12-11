namespace IE.Programare1.Util
{
    public class FunctiiCautareSortare
    {
        public static void InsertionSort(string[] valori, bool descrescator)
        {
            string temp;
            int j;
            for(int i = 1; i < valori.Length; i++)
            {
                temp = valori[i];
                j = i - 1;

                while(j >= 0 && (descrescator ? valori[j].CompareTo(temp) < 0 : valori[j].CompareTo(temp) > 0))
                {
                    valori[j + 1] = valori[j];
                    j--;
                }

                if(i != j + 1)
                {
                    valori[j + 1] = temp;
                }
            }
        }

        public static void SelectionSort(string[] valori, bool descrescator)
        {
            for(int i = 0; i < valori.Length; i++)
            {
                int minMaxIdx = i;
                int j = i + 1;
                while(j < valori.Length)
                {
                    if(descrescator ? valori[minMaxIdx].CompareTo(valori[j]) < 0 : valori[minMaxIdx].CompareTo(valori[j]) > 0)
                    {
                        minMaxIdx = j;
                    }
                    j++;
                }

                if(minMaxIdx != i)
                {
                    string temp = valori[minMaxIdx];
                    valori[minMaxIdx] = valori[i];
                    valori[i] = temp;
                }
            }
        }

        public static void BubbleSort(string[] valori, bool descrescator)
        {
            string temp;
            bool ordonat;

            do
            {
                ordonat = true;
                for(int i = 0; i < valori.Length - 1; i++)
                {
                    bool conditieOrdonare = descrescator ? valori[i].CompareTo(valori[i + 1]) < 0 : valori[i].CompareTo(valori[i + 1]) > 0;
                    if(conditieOrdonare)
                    {
                        temp = valori[i];
                        valori[i] = valori[i + 1];
                        valori[i + 1] = temp;
                        ordonat = false;
                    }
                }
            } while(!ordonat);

        }

        public static int Cauta(string[] valori, string deGasit)
        {
            int min = 0;
            int max = valori.Length;
            int pivot = valori.Length / 2;
            bool gasit = false;
            while(max > min)
            {
                if(deGasit.CompareTo(valori[pivot]) > 0)
                {
                    min = pivot;
                }
                else if(deGasit.CompareTo(valori[pivot]) < 0)
                {
                    max = pivot;
                }
                else
                {
                    gasit = true;
                    break;
                }
                pivot = (max + min) / 2;
            }
            return gasit ? pivot : -1;

        }
    }
}
