﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.Domin.Servises.Communication
{
   
    public class SaveCategoryResponse1 : BaseResponse
        {
            public Category Category { get; private set; }

            private SaveCategoryResponse1(bool success, string message, Category category) : base(success, message)
            {
                Category = category;
            }

            /// <summary>
            /// Creates a success response.
            /// </summary>
            /// <param name="category">Saved category.</param>
            /// <returns>Response.</returns>
            public SaveCategoryResponse1(Category category) : this(true, string.Empty, category)
            { }

            /// <summary>
            /// Creates am error response.
            /// </summary>
            /// <param name="message">Error message.</param>
            /// <returns>Response.</returns>
            public SaveCategoryResponse1(string message) : this(false, message, null)
            { }
        }
    }

