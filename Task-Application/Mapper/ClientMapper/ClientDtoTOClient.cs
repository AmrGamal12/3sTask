using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Dto;
using Task_Domain.Models;

namespace Task_Application.Mapper
{
    public class ClientDtoTOClient
    {
        public static Clients Map (ClientDto request )
        {
            var result = new Clients ();
            result.Name = request.Name;
            result.MobileNumber = request.MobileNumber;
            result.City=request.City;
            result.Country=request.Country;
            result.Email=request.Email;
            return result;
        }
    }
}
