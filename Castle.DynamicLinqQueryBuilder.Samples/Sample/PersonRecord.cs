using System;
using System.ComponentModel.DataAnnotations;

namespace Castle.DynamicLinqQueryBuilder.Samples.Sample
{
    public class PersonRecord
    {
        [Display(Name = "名字")]
        public string FirstName { get; set; }
        [Display(Name = "姓")]
        public string LastName { get; set; }
        [Display(Name = "年龄")]
        public int Age { get; set; }
        [Display(Name = "出生日期")]
        public DateTime Birthday { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "城市")]
        public string City { get; set; }
        [Display(Name = "州")]
        public string State { get; set; }
        [Display(Name = "邮政编码")]
        public string ZipCode { get; set; }

    }
}