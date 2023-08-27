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

namespace Tarea_de_investigacion_ReproductorMusical
{
    public partial class Form1 : Form
    {
        
        private IWavePlayer cancion;//Variable de reproductor de audio
        private AudioFileReader audioFile;//Variable asignada para el archivo de audio
        private int indice;// Variable de control de las portadas del album
        private string rutaMusica;

        public Form1()
        {
            InitializeComponent();
            indice = 0;// Inicializar desde 0
            cancion = new WaveOutEvent();//Inicia evento de reproductor de audio
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private string tituloCancionActual = "";

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex != -1 && !string.IsNullOrEmpty(rutaMusica))
            {
                //Se comprueba si se selecciono una cacion y se hay una ruta existente de las canciones
                string selectedSong = Path.Combine(rutaMusica, listBoxMusic.SelectedItem + ".mp3");
                if (File.Exists(selectedSong))
                {
                    audioFile = new AudioFileReader(selectedSong);

                    cancion.Stop();
                    cancion.Dispose();
                    cancion = new WaveOutEvent();

                    cancion.Init(audioFile);
                    cancion.Play();

                    tituloCancionActual = listBoxMusic.SelectedItem.ToString();
                    lbltituloCancion.Text = "Reproduciendo: " + tituloCancionActual;

                    indice++;
                    if (indice >= 3)
                        indice = 0;
                    lblimagenes.ImageIndex = indice;//Se actualiza el indice de la portada
                }
                else
                {
                    MessageBox.Show("El archivo de música no se encuentra en la ruta especificada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una canción y especifica la ruta de canciones.");
            }


        }



        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
           

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cancion.Stop();
        }


        
            private void btnRuta_Click(object sender, EventArgs e)
            {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaMusica = folderDialog.SelectedPath;
                    ActualizarListaCanciones();
                }
            }
        
}

private void ActualizarListaCanciones()
        {
            if (!string.IsNullOrEmpty(rutaMusica))
            {
                string[] archivosMusica = Directory.GetFiles(rutaMusica, "*.mp3");
                listBoxMusic.Items.Clear();
                foreach (string archivo in archivosMusica)
                {
                    string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
                    listBoxMusic.Items.Add(nombreArchivo);
                }
            }
        }

private void trackBarSubirBajarVolumen_Scroll(object sender, EventArgs e)
        {
            if (cancion != null)
            {
                float nuevoVolumen = (float)trackBarSubirBajarVolumen.Value / trackBarSubirBajarVolumen.Maximum;
                cancion.Volume = nuevoVolumen;
            }
        }
private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
/*Grupo 7
 Integrantes: 


-Juan Cristobal De Leon Sanchez    DS23003

-Jose Leuis Hernandez Flores    HF23001

-Guadalupe Del Carmen Rivas Estrada      RE23003

-Ana Concepcion Romero Vale      RV19034

 
 */

