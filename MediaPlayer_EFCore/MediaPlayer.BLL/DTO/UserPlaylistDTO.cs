﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.BLL.DTO
{
    public class UserPlaylistDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PlaylistName { get; set; }
    }
}
