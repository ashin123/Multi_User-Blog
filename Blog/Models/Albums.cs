//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Albums
    {
        public Albums()
        {
            this.Photos = new HashSet<Photos>();
        }
    
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public string Description { get; set; }
        public string CoverPath { get; set; }
        public Nullable<int> PhotoNum { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public int UID { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual ICollection<Photos> Photos { get; set; }
    }
}
