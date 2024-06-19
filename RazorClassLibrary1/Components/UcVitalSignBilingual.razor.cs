using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Components
{
    public partial class UcVitalSignBilingual
    {
        [Parameter]
        public string ID { get; set; }
        [Parameter]
        public int OrderIndex { get; set; }
        [Parameter]
        public string TyLeCanNang { get; set; }
        [Parameter]
        public DateTime ThoiGianDo { get; set; }

        private bool _enabled = true;
        [Parameter]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                _enabled = value;
                SetEnabled(value);
            }
        }

        private bool _showHeight;
        [Parameter]
        public bool ShowHeight
        {
            get => _showHeight;
            set => _showHeight = value;
        }

        private bool _showBMI;
        [Parameter]
        public bool ShowBMI
        {
            get => _showBMI;
            set => _showBMI = value;
        }

        private string _pulse;
        [Parameter]
        public string Pulse
        {
            get => _pulse;
            set => _pulse = value;
        }

        private string _temperature;

        [Parameter]
        public string Temperature
        {
            get => _temperature;
            set => _temperature = value;
        }

        private string _bloodPressure;
        [Parameter]
        public string BloodPressure
        {
            get => _bloodPressure;
            set => _bloodPressure = value;
        }

        private string _breath;
        [Parameter]
        public string Breath
        {
            get => _breath;
            set => _breath = value;
        }

        private string _height;
        [Parameter]
        public string Height
        {
            get => _height;
            set => _height = value;
        }

        private string _weight;
        [Parameter]
        public string Weight
        {
            get => _weight;
            set => _weight = value;
        }

        private string _bmi;
        [Parameter]
        public string BMI
        {
            get => _bmi;
            set
            {
                _bmi = value;
             }
        }

        private string _nutritionalClassification = "";
        [Parameter]
        public string NutritionalClassification
        {
            get => _nutritionalClassification;
            set => _nutritionalClassification = value;
        }
        public string BMIText { get; set; }
        public string ColorArgb { get; set; }
        private void SetBMI()
        {
            double? bmi = null;
            if (IsChangeBMI)
            {
                if (double.TryParse(Weight?.ToString(), out double weight) && double.TryParse(Height?.ToString(), out double height))
                {
                    height = height / 100;
                    if (height != 0)
                    {
                        bmi = Math.Round((weight / (height * height)), 2);
                    }
                }
            }

            string colorArgb = "";
            string nutritionalClassification = "";
            if (bmi == null)
            {
                // Do nothing
            }
            else if (bmi < 18.5)
            {
                colorArgb = "color-gay";
                nutritionalClassification = "Gầy";
            }
            else if (bmi < 25)
            {
                colorArgb = "color-binh-thuong";
                nutritionalClassification = "Bình thường";
            }
            else if (bmi < 30)
            {
                colorArgb = "color-hoi-beo";
                nutritionalClassification = "Hơi béo";
            }
            else if (bmi < 35)
            {
                colorArgb = "color-beo-phi-1";
                nutritionalClassification = "Béo phì 1";
            }
            else if (bmi < 40)
            {
                colorArgb = "color-beo-phi-2";
                nutritionalClassification = "Béo phì 2";
            }
            else
            {
                colorArgb = "color-beo-phi-3";
                nutritionalClassification = "Béo phì 3";
            }

            _bmi = bmi?.ToString();
            BMI = bmi?.ToString();
            ColorArgb = colorArgb;
            NutritionalClassification = nutritionalClassification;
            BMIText = $"<b>BMI: <color={colorArgb}>{_bmi} ({_nutritionalClassification})</color></b>";
        }

        private void SetEnabled(bool value)
        {
            // Assuming DxTextBox has an Enabled property
            // If not, you might need to handle this differently
        }

        public bool IsChangeBMI { get; set; } = true;

        private void OnHeightChanged(ChangeEventArgs e)
        {
            Height = e.Value.ToString();
            if (IsChangeBMI)
            {
                SetBMI();
            }
        }

        private void OnWeightChanged(ChangeEventArgs e)
        {
            Weight = e.Value.ToString();
            if (IsChangeBMI)
            {
                SetBMI();
            }
        }
    }
}
