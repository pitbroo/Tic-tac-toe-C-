using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolko_i_krzyzyk
{
    public static class InfoFromComputer
    {
        public static string getRandomInfo()
        {
            string[] info = new string[8] {
                "Teraz ja wygram! \r\n", 
                "Dobrze Ci idzie! \r\n", 
                "Nie masz dosyć? \r\n",
                "Teraz na pewno mi się uda! \r\n",
                "Niezły ruch \r\n",
                "Gdzie się tego nauczyłeś? \r\n",
                "Na pewno wygram tę rundę \r\n",
                "Nie masz ze mną szans! \r\n"};

            Random random = new Random();
            return info[random.Next(0, info.Length)];
        }
        
    }
}
