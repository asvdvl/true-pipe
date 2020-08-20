using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace true_pipe
{
    public partial class Form1 : Form
    {
        Process inputProcess;
        Process outputProcess;
        FileStream inputProcessStream;
        FileStream outputProcessStream;
        private SettingsFields settings = new SettingsFields();

        private void LoadSettings() 
        {
            if (File.Exists(settings.XMLSettingsFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(SettingsFields));
                TextReader reader = new StreamReader(settings.XMLSettingsFileName);
                try
                {
                    settings = ser.Deserialize(reader) as SettingsFields;
                    reader.Close();
                }
                catch (InvalidOperationException)
                {
                    reader.Close();

                    if (File.Exists(settings.XMLSettingsFileName + ".old"))
                    {
                        File.Delete(settings.XMLSettingsFileName + ".old");
                    }
                    File.Copy(settings.XMLSettingsFileName, settings.XMLSettingsFileName + ".old");

                    MessageBox.Show($"Файл с настройками поврежден! Старый файл сохранен как {Path.GetFileName(settings.XMLSettingsFileName)}.old");
                    SaveSettings();
                }
            }
        }

        private void SaveSettings()
        {
            settings.InputFileName = textBoxExacutableFileInputPipe.Text;
            settings.OutputFileName = textBoxExacutableFileOutputPipe.Text;
            settings.InputArguments = textBoxArgumentsInputPipe.Text;
            settings.OutputArguments = textBoxArgumentsOutputPipe.Text;

            XmlSerializer ser = new XmlSerializer(typeof(SettingsFields));
            TextWriter writer = new StreamWriter(settings.XMLSettingsFileName);

            ser.Serialize(writer, settings);
            writer.Flush();
            writer.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SaveSettings();

            inputProcess = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = settings.InputFileName,
                    Arguments = settings.InputArguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = settings.InputNoWindow,
                }
            };
            inputProcess.Start();

            outputProcess = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = settings.OutputFileName,
                    Arguments = settings.OutputArguments,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    CreateNoWindow = settings.InputNoWindow,
                }
            };

            outputProcess.Start();

            inputProcessStream = inputProcess.StandardOutput.BaseStream as FileStream;
            outputProcessStream = outputProcess.StandardInput.BaseStream as FileStream;

            int lastRead;
            byte[] data;

            while (true)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] buffer = new byte[settings.bufferSize];
                    do
                    {
                        lastRead = inputProcessStream.Read(buffer, 0, buffer.Length);

                        int readToEnd;
                        while (lastRead < settings.bufferSize && lastRead > 0)
                        {
                            readToEnd = inputProcessStream.Read(buffer, 0, buffer.Length - lastRead);
                            if (readToEnd == 0)
                                break;
                            lastRead += readToEnd;
                        }
                        ms.Write(buffer, 0, lastRead);
                    } while (lastRead > 0 && settings.readLimit > ms.Length);
                    data = ms.ToArray();
                }

                if (data.Length == 0)
                {
                    outputProcessStream.Flush();
                    outputProcessStream.Close();
                    outputProcess.WaitForExit();
                    inputProcess.Close();
                    break;
                }

                try
                {
                    outputProcessStream.Write(data, 0, data.Length);
                }
                catch (IOException)     //catch close channel
                {
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            textBoxExacutableFileInputPipe.Text = settings.InputFileName;
            textBoxExacutableFileOutputPipe.Text = settings.OutputFileName;
            textBoxArgumentsInputPipe.Text = settings.InputArguments;
            textBoxArgumentsOutputPipe.Text = settings.OutputArguments;
            checkBoxInputNoWindow.Checked = settings.InputNoWindow;
            checkBoxOutputNoWindow.Checked = settings.OutputNoWindow;
        }

        private void checkBoxInputNoWindow_CheckedChanged(object sender, EventArgs e)
        {
            settings.InputNoWindow = checkBoxInputNoWindow.Checked;
        }

        private void checkBoxOutputNoWindow_CheckedChanged(object sender, EventArgs e)
        {
            settings.OutputNoWindow = checkBoxOutputNoWindow.Checked;
        }
    }

    public class SettingsFields
    {
        public String XMLSettingsFileName = Environment.CurrentDirectory + "\\settings.xml";
        public String InputFileName = "";
        public String OutputFileName = "";
        public String InputArguments = "";
        public String OutputArguments = "";
        public bool InputNoWindow = false;
        public bool OutputNoWindow = false;
        public int readLimit = 1 << 16;
        public int bufferSize = 1 << 8;
    }
}
