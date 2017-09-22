using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiDapper.Models;

namespace ApiDapper.Respositories.Interfaces
{
    interface IRawLogDatamiRepository 
    {
        List<dynamic> ListarTodos(int page);

        List<RawLogDatami> Obter(string campanha_id);
    }
}
