using EntityLayer.Entities.Interfaces;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Entities.Concrete
{
    public class Category :IBaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //For use this mapping u should add System.ComponentModel namespacess.
        public int Id { get; set; }

        //In this row i express the special properties what we ask from users.
        [Required(ErrorMessage = "Must type a title")]
        [MinLength(2, ErrorMessage = "Minimum lenght is 2")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only allowed letters")]
        public string Name { get; set; }

        //These came from IBaseEntity.
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.active;
        public Status Status { get => _status; set => _status = value; }

        public List<Product> Products { get; set; }
    }
}
