﻿using codefirstdemo.CodeFirstModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstdemo.CodeFirstModel
{
    /// <summary>
    /// 课程实体
    /// </summary>
    public class Course
    {
        public Guid ID { get; set; }
        //课程名称
        public string Title { get; set; }
        //学分
        public double Credit { get; set; } = 1;
        public string CouresCode { get; set; }
        public int StudyPeriod { get; set; } = 0;
        //外键实体 用自定义的类作为属性
        public virtual Department Department { get; set; }

        public Course()
        {
            ID = Guid.NewGuid();
        }
    }
}
