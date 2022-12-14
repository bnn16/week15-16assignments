using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class User
    {
        private int MAX_SONGS_IN_FAV = 50;
        List<Song> Fav_song = new List<Song>();
        List<Song> SongAll = new List<Song>();
        public string name { get; private set; }
        private string email { get; set; }
        private string address { get; set; }

        public User(string name, string email, string address)
        {
            this.name = name;
            this.email = email;
            this.address = address;
        }
        public string toString()
        {
            return this.name;
        }

        public void AddToAllSong(Song song) {

                this.SongAll.Add(song);
            
        }
        public void AddSong(Song song)
        {
            if (Fav_song.Count > MAX_SONGS_IN_FAV)
            {
                return;
            }
            else
            {
                this.Fav_song.Add(song);
            }
        }

        public void RemoveSong(Song song)
        {
            if (Fav_song.Count == 0)
            {
                return;
            }
            else
            {
                this.Fav_song.Remove(song);
            }

        }

        public List<Song> GetAllSongs()
        {
            return this.SongAll;
        }

        public List<Song> getFavSong()
        {
            return this.Fav_song;
        }

    }
}
