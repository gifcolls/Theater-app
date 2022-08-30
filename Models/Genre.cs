using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_GiselleF_301215601.Models
{
    [Flags] 
    enum Genre : short
    {
        Unreated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        Mystery = 8,
        Musical = 16,
        Horror = 32,
        Comedy = 64,
        Fantasy = 128,
        Animation = 256,
        Adventure = 512,

    }
}
