using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDown1.Models
{
    public class GetDataDBContext : DbContext
    {
        public GetDataDBContext() : base("connection")
        {

        }
        public virtual  DbSet<tbl_Data> datas { get; set; }
    }
}