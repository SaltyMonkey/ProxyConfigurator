using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.IO;

namespace Configurator
{
    public partial class Form1 : Form
    {
        private JsonSettings currentSettings = new JsonSettings();

        private JsonSettings defaultSettings =
            new JsonSettings {region = "EU", updatelog = false};

        private string jsonPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\bin\config.json";

        public Form1()
        {
           
            InitializeComponent();
            if (!File.Exists(jsonPath))
            {
                if (MessageBox.Show("File not found. Generate it with default settings?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(jsonPath));
                    WriteData(jsonPath, defaultSettings);
                    syncObjects();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                currentSettings = ReadData(jsonPath);
            }

            FillUi();
        }

        private void FillUi()
        {
            switch (currentSettings.region)
            {
                case ("NA"):
                    RB_na.Checked = true; break;
                case ("EU"):
                    RB_eu.Checked = true; break;
                case ("RU"):
                    RB_ru.Checked = true; break;
                case ("KR"):
                    RB_kr.Checked = true; break;
                case ("TW"):
                    RB_tw.Checked = true; break;
                case ("SE"):
                    RB_se.Checked = true; break;
            }
            CB_updatelog.Checked = currentSettings.updatelog;
        }

        private void RB_na_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.Checked) currentSettings.region = "NA";
        }

        private void RB_eu_CheckedChanged(object sender, EventArgs e)
        {
            currentSettings.region = "EU";
        }

        private void RB_ru_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked) currentSettings.region = "RU";
        }

        private void RB_kr_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked) currentSettings.region = "KR";
        }

        private void RB_tw_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked) currentSettings.region = "TW";
        }

        private void RB_se_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked) currentSettings.region = "SE";
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            syncObjects();
            FillUi();
        }

        private JsonSettings DeserializeSettings(string rawData)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<JsonSettings>(rawData);
        }

        private string SerializeSettings(JsonSettings data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(data);
        }

        private void WriteData(string path, JsonSettings obj)
        {
            File.WriteAllText(path, SerializeSettings(obj));
        }

        private JsonSettings ReadData(string path)
        {
            return DeserializeSettings(File.ReadAllText(path));
        }

        private void B_apply_Click(object sender, EventArgs e)
        {
            WriteData(jsonPath, currentSettings);
            Application.Exit();
        }

        private void CB_updatelog_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            currentSettings.updatelog = cb.Checked;
        }

        private void syncObjects()
        {
            currentSettings.updatelog = defaultSettings.updatelog;
            currentSettings.region = defaultSettings.region;
        }
    }
}
