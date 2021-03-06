﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiDapper.Models;
using ApiDapper.Respositories;

namespace ApiDapper.Controllers
{
    public class RawController : ApiController
    {
        private RawLogDatamiRepository _Repository;
        
        public RawController()
        {
            _Repository = new RawLogDatamiRepository();
        }
        // GET: api/Raw
        public List<dynamic> Get(int? page) => _Repository.ListarTodos(page ?? 1);

        // GET: api/Raw/5
 //       public List<RawLogDatami> Get(string id) => _Repository.Obter(id);
    }
}
