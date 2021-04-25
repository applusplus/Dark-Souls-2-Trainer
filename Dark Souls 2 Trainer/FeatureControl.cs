using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dark_Souls_2_Trainer
{
    public partial class FeatureControl : UserControl
    {
        SoulForm.ClickCallback clickCallback;
        SoulForm.CheckValidate checkValidate;

        private String Value { get; set; }

        public FeatureControl()
        {
            InitializeComponent();
        }

        private void callCallback(bool isFreeze = false)
        {
            try
            {
                if (checkValidate == null || checkValidate(Value, textValue)) 
                {
                    clickCallback(Value, isFreeze);
                }                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void butSet_Click(object sender, EventArgs e)
        {
            Value = textValue.Text;
            callCallback();
        }

        public void initControl(String description, SoulForm.ClickCallback clickCallback, SoulForm.CheckValidate checkValidate = null)
        {
            SetDescription(description);
            SetClickCallback(clickCallback);
            SetCheckValidate(checkValidate);
        }

        public void SetClickCallback(SoulForm.ClickCallback clickCallback)
        {
            this.clickCallback = clickCallback;
        }

        public void SetCheckValidate(SoulForm.CheckValidate checkValidate)
        {
            this.checkValidate = checkValidate;
        }

        public void SetDescription(String description)
        {
            labDescript.Text = description;
        }

        public void SetReadValue(String value)
        {
            labValue.Text = value;
        }

        public void SetValue(String value)
        {
            if (String.IsNullOrEmpty(textValue.Text) || textValue.Text == "-1" || ActiveControl != textValue)
            {
                textValue.Text = value;
            }
        }

        private void timerFreeze_Tick(object sender, EventArgs e)
        {
            callCallback(true);
        }

        private void checkFreeze_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                Value = textValue.Text;
                timerFreeze.Start();
            }
            else
            {
                timerFreeze.Stop();
            }
        }

        public void reset()
        {
            Value = "";
            SetValue("");
            checkFreeze.Checked = false;
            timerFreeze.Stop();
        }
    }
}
