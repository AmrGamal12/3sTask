﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Application.Mapper;
using Task_Domain.Models;

namespace Task_Application.Client
{
    public class Clientregister
    {
        public static Boolean addregister(ClientDto request)
        {
            try
            {
                var item = ClientDtoTOClient.Map(request);
                TaskDbContext db = new TaskDbContext();
                db.Client.Add(item);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
