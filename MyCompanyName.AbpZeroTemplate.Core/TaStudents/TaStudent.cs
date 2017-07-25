using Abp.Domain.Entities;
using MyCompanyName.AbpZeroTemplate.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.TaStudents
{
    #region 创建学生表实体
    public class TaStudent : Entity<long>
    {
        //学生姓名
        public const int MaxNameLength = 20;
        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }
        //学生性别
        public const int MaxSexLength = 10;
        [Required]
        [MaxLength(MaxSexLength)]
        public virtual string Sex { get; set; }
        //学生生日
        public virtual DateTime Birthdate { get; set; }
        //学生学校编号
        public long? SchoolId { get; set; }
        //[ForeignKey("SchoolId")]//外键        
        //学生年级
        public const int MaxGradeLength = 20;
        [Required]
        [MaxLength(MaxGradeLength)]
        public virtual string Grade { get; set; }
        //学生家庭地址
        public const int MaxHomeAddressLength = 50;
        [Required]
        [MaxLength(MaxHomeAddressLength)]
        public virtual string HomeAddress { get; set; }
        //学生描述
        public const int MaxDescriptionLength = 500;
        [Required]
        [MaxLength(MaxDescriptionLength)]
        public virtual string Description { get; set; }
        //学生照片地址
        public const int MaxPhotoUrlLength = 100;
        [Required]
        [MaxLength(MaxPhotoUrlLength)]
        public virtual string PhotoUrl { get; set; }
        //是否删除(软删除)
        //public interface ISoftDelete
        //{
        //    int IsDelete { get; set; }
        //}
        public virtual int IsDelete { get; set; }
        //修改时间 (当前时间)
        public virtual DateTime ModifyTime { get; set; }
        public TaStudent(string name, string sex, DateTime birthdate, long schoolId, string grade, string homeAddress, string description, string photoUrl)
        {
            Name = name;
            Sex = sex;
            Birthdate = birthdate;
            SchoolId = schoolId;
            Grade = grade;
            HomeAddress = homeAddress;
            Description = description;
            PhotoUrl = photoUrl;
        }
        public TaStudent()
        {
            ModifyTime = DateTime.Now;
        }
        public TaStudent(int isDelete)
        {
            IsDelete = isDelete;
        }

    }
    #endregion
}
