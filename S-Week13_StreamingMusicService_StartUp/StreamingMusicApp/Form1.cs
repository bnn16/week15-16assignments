using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        //made by bogdan
        public Form1()
        {
            InitializeComponent();
        }
        List<User> Users = new List<User>();
        List<string> names = new List<string>();

        private void addSong(object sender, EventArgs e)
        {
            Song addNew = new Song(Int32.Parse(musidId.Text), ArtistName.Text, SongTitle.Text, Int32.Parse(Duration.Text));

            foreach (var foo in Users)
            {
                if (foo.name == UserList.Text)
                {
                    foo.AddToAllSong(addNew);
                    AllSongs.Items.Add(addNew.GetInfo());
                    break;
                }
            }

        }

        private void Add_User(object sender, EventArgs e)
        {
            User addNewUser = new User(nameInput.Text, EmailInput.Text, AddressInput.Text);
            Users.Add(addNewUser);
            UserList.Items.Add(addNewUser.toString());
        }

        private void onUserChange(object sender, EventArgs e)
        {
            AllSongs.Items.Clear();
            FavSongs.Items.Clear();
            for (int foo = 0; foo < Users.Count; foo++)
            {
                if (Users[foo].name == UserList.Text)
                {
                    var list = Users[foo].GetAllSongs();
                    foreach (var song in list)
                    {
                        AllSongs.Items.Add(song.GetInfo());
                    }
                    var new_list = Users[foo].getFavSong();
                    foreach (var song in new_list)
                    {
                        FavSongs.Items.Add(song.GetInfo());
                    }
                    break;
                }
            }
        }

        private void AddToFav(object sender, EventArgs e)
        {
            for (int foo = 0; foo < Users.Count; foo++)
            {
                if (Users[foo].name == UserList.Text)
                {
                    var list = Users[foo].GetAllSongs();
                    var new_list = Users[foo].getFavSong();
                    if (!new_list.Contains(list[AllSongs.SelectedIndex])) { 
                    Users[foo].AddSong(list[AllSongs.SelectedIndex]);
                        foreach (var song in new_list)
                            if (!FavSongs.Items.Contains(song.GetInfo()))
                            {
                                FavSongs.Items.Add(song.GetInfo());
                            }
 
                    }
                  
                    break;
                }

            }
        }

        private void RemoveFromFav(object sender, EventArgs e)
        {
            List<object> toRemove = new List<object>();
            for (int foo = 0; foo < Users.Count; foo++)
            {
                if (Users[foo].name == UserList.Text)
                {
                    var list = Users[foo].getFavSong();

                    for (int i = FavSongs.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        FavSongs.Items.RemoveAt(FavSongs.SelectedIndices[i]);
                        Users[foo].RemoveSong(list[i]);
                    }
                    break;
                }

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}