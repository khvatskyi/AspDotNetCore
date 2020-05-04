﻿using System;
using System.Collections.Generic;
using MediaPlayer.DAL.Interfaces;

namespace MediaPlayer.DAL.Entities
{
    public partial class Music : IEntity
    {
        public Music()
        {
            MusicPlaylists = new HashSet<MusicPlaylist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public int Year { get; set; }
        public string Album { get; set; }

        public virtual ICollection<MusicPlaylist> MusicPlaylists { get; set; }
    }
}
