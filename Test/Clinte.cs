using Microsoft.Graph.Groups.Item.Team.Channels.Item.SharedWithTeams.Item.AllowedMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Client;
using Task_Application.Dto;

namespace Test
{
    [TestFixture]
    public class Clinte
    {
        ClientDto request = new ClientDto()
        {
            Name="amr",
            Email="amamamam",
            MobileNumber=10292,
            City="cairo",
            Country="egypt"
        };
        [Test]
        public void RegisterClientTest()
        {
            Boolean expextedresult = Clientregister.addregister(request);
            Assert.AreEqual(true, expextedresult);

        }
    }
   
}