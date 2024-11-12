using System;
using System.Collections.Generic;
//-----------------------------------
using System.IO;
using System.Windows.Forms;

namespace GameUserSettings_Creator
{
    public partial class Settings_for_resolutions : Form
    {
        // Variable para almacenar la ruta del archivo seleccionado
        private string archivoSeleccionado = string.Empty;

        public Settings_for_resolutions()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Obtiene la ruta base de AppData\Local para el usuario actual
            string rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            // Construye la ruta completa
            string rutaCarpeta = Path.Combine(rutaBase, @"VALORANT\Saved\Config");

            // Configuración para el OpenFileDialog
            using (OpenFileDialog OpenFolderD = new OpenFileDialog())
            {
                OpenFolderD.InitialDirectory = rutaCarpeta; // Establece la ruta inicial de búsqueda
                OpenFolderD.Filter = "INI files (*.ini)|*.ini"; // Solo muestra archivos .ini
                OpenFolderD.Title = "Select a .ini configuration file"; // Mensaje

                // Abre el cuadro de diálogo y verifica si el usuario selecciona un archivo
                if (OpenFolderD.ShowDialog() == DialogResult.OK)
                {
                    // Aquí puedes usar el archivo seleccionado
                    archivoSeleccionado = OpenFolderD.FileName;

                    try
                    {
                        // Lee todas las líneas del archivo
                        string[] lineas = File.ReadAllLines(archivoSeleccionado);

                        // Diccionario para almacenar los valores de las claves deseadas
                        Dictionary<string, string> valores = new Dictionary<string, string>
                        {
                            { "DefaultMonitorDeviceID=", "" },
                            { "LastConfirmedDefaultMonitorDeviceID=", "" },
                            { "ResolutionSizeX=", "" },
                            { "ResolutionSizeY=", "" },
                            { "LastUserConfirmedResolutionSizeX=", "" },
                            { "LastUserConfirmedResolutionSizeY=", "" }
                        };

                        // Busca y extrae cada valor en el archivo
                        foreach (string linea in lineas)
                        {
                            foreach (var clave in valores.Keys)
                            {
                                if (linea.StartsWith(clave))
                                {
                                    valores[clave] = linea.Substring(clave.Length);
                                    break;
                                }
                            }
                        }

                        // Asigna los valores a los labels
                        lblMonitor.Text = valores["DefaultMonitorDeviceID="];
                        lblRes.Text = valores["ResolutionSizeX="] + "x" + valores["ResolutionSizeY="];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Verifica si los campos de resolución están vacíos
            if (string.IsNullOrWhiteSpace(txtResX.Text) || string.IsNullOrWhiteSpace(txtResY.Text))
            {
                MessageBox.Show("Please complete the resolution fields before upgrading.");
                return; // Sale del método si falta información
            }

            // Verifica si se seleccionó un archivo previamente
            if (!string.IsNullOrEmpty(archivoSeleccionado))
            {
                try
                {
                    // Obtiene los valores de resolución de los campos de texto
                    string NameMonitor = lblMonitor.Text;
                    string resolutionX = txtResX.Text;
                    string resolutionY = txtResY.Text;

                    // Contenido a escribir en el archivo, línea por línea
                    string[] contenido = new string[]
                    {
                "[/Script/ShooterGame.ShooterGameUserSettings]",
                $"DefaultMonitorDeviceID={NameMonitor}",
                "DefaultMonitorIndex=0",
                $"LastConfirmedDefaultMonitorDeviceID={NameMonitor}",
                "LastConfirmedDefaultMonitorIndex=0",
                "bShouldLetterbox=False",
                "bLastConfirmedShouldLetterbox=False",
                "bUseVSync=False",
                "bUseDynamicResolution=False",
                $"ResolutionSizeX={resolutionX}",
                $"ResolutionSizeY={resolutionY}",
                $"LastUserConfirmedResolutionSizeX={resolutionX}",
                $"LastUserConfirmedResolutionSizeY={resolutionY}",
                "WindowPosX=0",
                "WindowPosY=0",
                "LastConfirmedFullscreenMode=2",
                "PreferredFullscreenMode=0",
                "AudioQualityLevel=0",
                "LastConfirmedAudioQualityLevel=0",
                "FrameRateLimit=0.000000",
                "DesiredScreenWidth=1280",
                "DesiredScreenHeight=720",
                "LastUserConfirmedDesiredScreenWidth=1280",
                "LastUserConfirmedDesiredScreenHeight=720",
                "LastRecommendedScreenWidth=-1.000000",
                "LastRecommendedScreenHeight=-1.000000",
                "LastCPUBenchmarkResult=-1.000000",
                "LastGPUBenchmarkResult=-1.000000",
                "LastGPUBenchmarkMultiplier=1.000000",
                "bUseHDRDisplayOutput=False",
                "HDRDisplayOutputNits=1000",
                "FullscreenMode=2",
                "",
                "[/Script/Engine.GameUserSettings]",
                "bUseDesiredScreenHeight=False",
                "",
                "[Internationalization.AssetGroupCultures]",
                "Mature=en-US",
                "",
                "[ScalabilityGroups]",
                "sg.ResolutionQuality=100.000000",
                "sg.ViewDistanceQuality=3",
                "sg.AntiAliasingQuality=3",
                "sg.ShadowQuality=3",
                "sg.PostProcessQuality=3",
                "sg.TextureQuality=0",
                "sg.EffectsQuality=3",
                "sg.FoliageQuality=3",
                "sg.ShadingQuality=3",
                "",
                "[ShaderPipelineCache.CacheFile]",
                "LastOpened=ShooterGame"
                    };

                    // Sobrescribe el archivo con el contenido especificado
                    File.WriteAllLines(archivoSeleccionado, contenido);

                    MessageBox.Show("The file has been updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must first select a file.");
            }
        }


        private void txtResX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Bloquear la tecla si no es un número o retroceso
            }

            // Limitar la longitud a 5 caracteres
            if (txtResX.Text.Length >= 5 && e.KeyChar != (char)8)
            {
                e.Handled = true; // Bloquear la tecla si se alcanzaron los 5 caracteres
            }
        }

        private void txtResY_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Bloquear la tecla si no es un número o retroceso
            }

            // Limitar la longitud a 5 caracteres
            if (txtResY.Text.Length >= 5 && e.KeyChar != (char)8)
            {
                e.Handled = true; // Bloquear la tecla si se alcanzaron los 5 caracteres
            }
        }
    }
}
