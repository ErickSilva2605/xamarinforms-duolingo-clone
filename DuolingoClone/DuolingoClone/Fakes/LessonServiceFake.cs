﻿using DuolingoClone.Enums;
using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuolingoClone.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        public async Task<IList<LessonGroupModel>> GetLessonsGroup()
        {
            return await Task.Run(() =>
            {
                return new List<LessonGroupModel>
                {
                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Introdução", "4")
                        }
                     },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Saudações", "4"),
                            GetNewLesson("Viagem", string.Empty)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Bônus", string.Empty),
                            GetNewLesson("Bônus", string.Empty),
                            GetNewLesson("Bônus", string.Empty)
                        }
                    }
                };
            });
        }

        private LessonModel GetNewLesson(string name, string level)
        {
            return new LessonModel
            {
                Name = name,
                Level= level
            };
        }
    }
}
