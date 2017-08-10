﻿using System.ComponentModel;
using Models.Base;


namespace Models.Entities
{

    public class Manager : IBaseModel<long>
    {
        [Description("序号")]
        public long Id { get; set; }

        [Description("姓名")]
        public string Name { get; set; }


    }

}