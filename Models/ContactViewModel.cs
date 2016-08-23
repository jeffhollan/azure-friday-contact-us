using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace azure_friday.Models
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }

        // public string Type { get; set; }

        // [JsonIgnore]
        // public List<SelectListItem> Types { get; } = new List<SelectListItem>
        // {
        //     new SelectListItem { Value = "Comment", Text = "Comment" },
        //     new SelectListItem { Value = "Issue", Text = "Issue" },
        //     new SelectListItem { Value = "Request", Text = "Request"  },
        // };
    }
}