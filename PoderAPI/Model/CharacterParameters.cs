using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoderAPI.Model
{
    public class CharacterParameters
    {
        const int maxPageSize = 12;

        public int PageNumber { get; set; } = 1;

        public int _pageSize = 6;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
