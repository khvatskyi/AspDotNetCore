﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.BLL.DTOs.UserDTO
{
    public class UserViewDTO
    {
        public UserViewDTO(string Id)
        {
            id = Id;
        }

        private readonly string id;

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string UserName { get; set; }

        public byte[] Photo { get; set; }
    }
}
