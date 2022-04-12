using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetShop
{
    class EAN13Barcode
    {
        public static string Barcode13Digits = "";

        public static string EAN13(string chaine)
        {
            int i;
            int first;
            int checkSum = 0;
            string Barcode = "";
            bool tableA;

            if (Regex.IsMatch(chaine, "^\\d{12}$"))
            {
                for (i = 1; i < 12; i += 2)
                {
                    System.Diagnostics.Debug.WriteLine(chaine.Substring(i, 1));
                    checkSum += Convert.ToInt32(chaine.Substring(i, 1));
                }

                checkSum *= 3;

                for (i = 0; i < 12; i += 2)
                {
                    checkSum += Convert.ToInt32(chaine.Substring(i, 1));
                }

                chaine += (10 - checkSum % 10) % 10;

                Barcode13Digits = chaine.ToString();

                Barcode = chaine.Substring(0, 1) + (char)(65 + Convert.ToInt32(chaine.Substring(1, 1)));
                first = Convert.ToInt32(chaine.Substring(0, 1));

                for (i = 2; i <= 6; i++)
                {

                    tableA = false;

                    switch (i)
                    {
                        case 2:
                            if (first >= 0 && first <= 3) tableA = true;
                            break;
                        case 3:
                            if (first == 0 || first == 4 || first == 7 || first == 8) tableA = true;
                            break;
                        case 4:
                            if (first == 0 || first == 1 || first == 4 || first == 5 || first == 9) tableA = true;
                            break;
                        case 5:
                            if (first == 0 || first == 2 || first == 5 || first == 6 || first == 7) tableA = true;
                            break;
                        case 6:
                            if (first == 0 || first == 3 || first == 6 || first == 8 || first == 9) tableA = true;
                            break;
                    }

                    if (tableA)
                    {
                        Barcode += (char)(65 + Convert.ToInt32(chaine.Substring(i, 1)));

                    }
                    else
                    {
                        Barcode += (char)(75 + Convert.ToInt32(chaine.Substring(i, 1)));
                    }

                }

                Barcode += "*";

                for (i = 7; i <= 12; i++)
                {
                    Barcode += (char)(97 + Convert.ToInt32(chaine.Substring(i, 1)));
                }

                Barcode += "+";

            }

            return Barcode;
        }
    }
}
