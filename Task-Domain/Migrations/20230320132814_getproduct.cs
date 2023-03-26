using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Domain.Migrations
{
    /// <inheritdoc />
    public partial class getproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
         
            var sp = @"CREATE PROCEDURE [dbo].[GetProduct]
                    @myparam int,
                    @page_num int,
                    @page_size int
                as
                begin 
                    select y.Id , y.Name,y.Availablequantity,y.briefdescription,y.Price,y.Quantitylimit,y.Image,y.CategoryId from (select row_number() over(order by p.id) as [row_number]  ,  p.Id , p.Name ,p.Price ,p.Quantitylimit,p.Availablequantity ,p.briefdescription ,p.CategoryId,p.Image  from Product p
                          , Category c
                      Where (c.Id = @myparam or c.parentCategorysId = @myparam) and (P.CategoryId = C.Id)) y
                      where y.[row_number] <= @page_num*@page_size
                         and y.[ROW_NUMBER] >= (@page_num*10 -9)

                END";

            migrationBuilder.Sql(sp);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
