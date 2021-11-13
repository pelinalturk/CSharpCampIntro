using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulator
{
    class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime SalesDate { get; set; }
        public int Price { get; set; }
    }
}
