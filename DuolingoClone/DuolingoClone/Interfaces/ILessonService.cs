﻿using DuolingoClone.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoClone.Interfaces
{
    public interface ILessonService
    {
        Task<IList<LessonGroupModel>> GetLessonsGroup();
    }
}