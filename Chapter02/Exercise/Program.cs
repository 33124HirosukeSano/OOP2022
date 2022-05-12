using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            /*List<Song> songs = new List<Song>();

            var song1 = new Song("Let it be","Beatles",243);
            songs.Add(song1);

            var song2 = new Song("Let it be", "Beatles", 243);
            songs.Add(song2);

            var song3 = new Song("Let it be", "Beatles", 243);
            songs.Add(song3);*/

            var songs = new Song[] {

                new Song("Let it be","Beatles",243),
                new Song("Bridge Over Troubled","Simon & Garfunkel",293),
                new Song("a","Aa",286),
                new Song("b","Bb",224),
                new Song("c","Cc",275),


            };
            PrintSongs(songs);

        }

        /*private static void PrintSongs(Song[] songs) {

            foreach (var song in songs) {

                Console.WriteLine("{0} {1} {2:mm\\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));


            }
        }
        private static void PrintSongs(List<Song> songs) {

            foreach (var song in songs) {

                Console.WriteLine("{0} {1} {2:mm\\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));


            }
        }*/


        private static void PrintSongs(IEnumerable<Song> songs) {

            foreach (var song in songs) {

                Console.WriteLine("{0} {1} {2:mm\\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));

            }
        }

    }
}
