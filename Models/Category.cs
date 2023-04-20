using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Budget.Mvc.Models
{
    public class Category
    {
        public int Id { get; set; }

    
        public string Name { get; set; }
    }
}
