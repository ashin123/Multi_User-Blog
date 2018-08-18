using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using Blog.Models;

namespace Blog.Validator
{
    public class TagValidation:AbstractValidator<Tags>
    {
        public TagValidation() 
        {
            RuleFor(u => u.TName).NotNull().Length(1, 30).WithMessage("标签名不为空且最长为30个字符");
        }
    }
}