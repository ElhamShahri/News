using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using News.Utilities.Convertor;

namespace News.Web.Models

{
    public class Page
    {
        public Page()
        {

        }
        [Key]
        public int PageID { get; set; }

        [ForeignKey("pageGroup")]
        [Display(Name = "گروه خبر")]
        public int GroupID { get; set; }

        [Display(Name = "عنوان صفحه")]
        [Required(ErrorMessage = "لطفا{0} را وارد نمایید")]
        [MaxLength(400)]
        public string PageTitle { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا{0} را وارد نمایید")]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "متن کامل")]
        [Required(ErrorMessage = "لطفا{0} را وارد نمایید")]
        [DataType(DataType.MultilineText)]
        public string PageText { get; set; }

        [Display(Name = "بازدید")]
        public int PageVisit { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string PageTags { get; set; }

        [Display(Name = "نمایش در اسلایدر")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime CreateDate { get; set; }

        //public string ToShamsi
        //{
        //    get
        //    {
        //        return DateConvertor.ToShamsi(CreateDate);
        //    }
        //}

        //Navigation Property
        public virtual PageGroup pageGroup { get; set; }
    }
}
