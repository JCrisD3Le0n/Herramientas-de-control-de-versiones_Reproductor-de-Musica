using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;//Esta biblioteca hace posible el hacer uso de audios
using NAudio;
using System.IO;//Biblioteca que permite el manejo, uso de entrada y salida de archivos
using TagLib;//Biblioteca para trabajar con metadatos de audio
namespace Tarea_de_investigacion_ReproductorMusical
{
    public partial class Form1 : Form
    {
        string rutaMusical = @"Musica\"; //Ruta del directorio que contiene la música
        private WaveOutEvent waveOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] canciones = Directory.GetFiles(rutaMusical, "*.mp3"); // Arreglo que contendrá la lista de nombres
            //La siguiente estructura enlista los elementos del arreglo canciones en el listBoxMusic
            foreach (string cancion in canciones)
            {
                string nombreCancion = Path.GetFileName(cancion);
                listBoxMusic.Items.Add(nombreCancion);
            }
            waveOut = new WaveOutEvent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //segundo comentario en la aplicacion 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Reproducir();
        }
        void Reproducir()
        {
            string nombreCancion = listBoxMusic.SelectedItem.ToString();
            string rutaCompleta = Path.Combine(rutaMusical, nombreCancion);
            if (waveOut != null)
            {
                waveOut.Stop(); // Detener la reproducción actual, si la hay
                AudioFileReader cancion = new AudioFileReader(rutaCompleta); //Variable que almacena el archivo de audio
                waveOut.Init(cancion);//Inicializa la instancia de reproducción.
                waveOut.Play();//Reproduce el audio
            }
        }

        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reproducir();
        }
    }
}
