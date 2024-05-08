using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Y2_ADMS_Event_Integ_MidtermProj_PetShopInventory
{
    internal class SoundSystem
    {
        public void Initialize(string fileName, double volume)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"Sounds\", fileName);

            MediaPlayer media = new MediaPlayer();
            media.Open(new Uri(path));

            media.Play();
            media.Volume = Math.Max(0.0, Math.Min(5.0, volume));
        }
    }
}