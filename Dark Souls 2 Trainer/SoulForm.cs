using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Dark_Souls_2_Trainer.Controls;
using IgroGadgets.Memory;

namespace Dark_Souls_2_Trainer
{
    public partial class SoulForm : Form
    {
        public delegate void ClickCallback(string value, bool isFreeze);
        public delegate bool CheckValidate(string value, TextBox textBox);
        public delegate int ReadMemoryDel(IntPtr address);
        public delegate bool WriteMemoryDel(IntPtr address, int value);

        private const string GAME_NAME = "DarkSoulsII";
        public const int DEFAULT_START_ADDRESS = 0x905A4D;

        private static SignatureEntity InfItemsHolder = new SignatureEntity(DEFAULT_START_ADDRESS, 0x4C4B40, new byte[] { 0x66, 0x29, 0x5E, 0x18, 0x56, 0x8B, 0xCF, 0x33, 0xDB, 0xE8, 0x0, 0x0, 0x0, 0x0, 0x5F, 0x5E }, "xxxxxxxxxx????xx", 0);
        private static SignatureEntity InfSoulsHolder = new SignatureEntity(DEFAULT_START_ADDRESS, 0x4C4B40, new byte[] { 0x2B, 0xC2, 0xEB, 0x02, 0x33, 0xC0, 0x80, 0xB9 }, "xxxxxxxx", 0);
        private static SignatureEntity InfSpellsHolder = new SignatureEntity(DEFAULT_START_ADDRESS, 0x4C4B40, new byte[] { 0x88, 0x43, 0x18, 0xE8, 0x1F, 0xEA, 0xFF, 0xFF, 0x8B, 0x45, 0xFC, 0x5F, 0x5E, 0x5B, 0x8B, 0xE5 }, "xxxx????xxxxxxxx", 0);
        private static SignatureEntity InfHealthHolder = new SignatureEntity(DEFAULT_START_ADDRESS, 0x4C4B40, new byte[] { 0x89, 0x8E, 0x00, 0x00, 0x00, 0x00, 0x8B, 0x02, 0x50, 0xE8, 0x00, 0x00, 0x00, 0x00 }, "xx????xxxx????", 0);
        

        private static int[] Slot1Offsets = new int[] { 0x115A58C, 0x88, 0x484, 0x18 }; //3. offset + 4 = next slot
        private const int SLOTS_INDEX = 3;
        private const int SLOTS_OFFSET = 0x4;
        private static int[][] SlotsOffsets = new int[][] { Slot1Offsets,
                                                             createOffset(Slot1Offsets, SLOTS_INDEX, SLOTS_OFFSET),
                                                             createOffset(Slot1Offsets, SLOTS_INDEX, SLOTS_OFFSET * 2),
                                                             createOffset(Slot1Offsets, SLOTS_INDEX, SLOTS_OFFSET * 3)
                                                            };

        private static int[] createOffset(int[] offsets, int index, int offset)
        {
            int[] newOffsets = new int[offsets.Length];
            for (int i = 0; i < offsets.Length; i++ )
            {
                newOffsets[i] = offsets[i] + (i == index-1 ? offset : 0);
            }
            return newOffsets;
        }
        
        private ProcessMemory processMemory;
        private int baseAddress;

        private FeatureControl[] slotControls;

        private static AddressEntity<int> SoulsAddress = new AddressEntity<int>(new int[] { 0x011593F4, 0x74, 0x378, 0xE8 });
        private static AddressEntity<int> GainedSoulsAddress = new AddressEntity<int>(new int[] { 0x011593F4, 0x74, 0x378, 0xf0 });
        private static AddressEntity<int> TorchAddress = new AddressEntity<int>(new int[] { 0x11593F4, 0x60, 0x8, 0x8, 0x14, 0x8, 0x0 });
        private static AddressEntity<int> MaxHealthAddress = new AddressEntity<int>(new int[] { 0x11593F4, 0x74, 0x104 });
        private static AddressEntity<int> HealthAddress = new AddressEntity<int>(new int[] { 0x11593F4, 0x74, 0xfc });
        private static AddressEntity<int> MaxStaminaAddress = new AddressEntity<int>(new int[] { 0x11593F4, 0x74, 0x148 });
        private static AddressEntity<int> StaminaAddress = new AddressEntity<int>(new int[] { 0x11593F4, 0x74, 0x140 });
        //private IntPtr ChosenItemAddress;
        private static AddressEntity<int>[] SlotsAddress = new AddressEntity<int>[SlotsOffsets.Length];
        private static AddressEntity<int> InfItemsAddress = new AddressEntity<int>(new IntPtr(DEFAULT_START_ADDRESS + 0x1F4702));
        private static AddressEntity<int> InfSpellsAddress = new AddressEntity<int>(new IntPtr(DEFAULT_START_ADDRESS + 0x23C069));
        private static AddressEntity<int> InfSoulsAddress = new AddressEntity<int>(new IntPtr(DEFAULT_START_ADDRESS + 0x3BD2B3));
        private static AddressEntity<int> InfHealthAddress = new AddressEntity<int>(new IntPtr(DEFAULT_START_ADDRESS + 0x203431));        

        private static bool searchOnce = false;
        private static bool readValueOnce = false;
        private static bool lockDamage = false;
        

        public SoulForm()
        {
            InitializeComponent();
            InitCombobox();

            baseAddress = DEFAULT_START_ADDRESS;

            slotControls = new FeatureControl[] { featureSlot1, featureSlot2, featureSlot3, featureSlot4 };

            featureSouls.initControl("Souls:", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(SoulsAddress, value, processMemory.ReadMemoryInt, processMemory.WriteMemoryInt, isFreeze); });
            featureGainedSouls.initControl("Gained Souls:", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(GainedSoulsAddress, value, processMemory.ReadMemoryInt, processMemory.WriteMemoryInt, isFreeze); });
            featureTorchlight.initControl("Torchlight (seconds):", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(TorchAddress, value, ReadFloat, WriteFloat, isFreeze); });
            featureMaxHealth.initControl("Max Health:", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(MaxHealthAddress, value, processMemory.ReadMemoryInt, processMemory.WriteMemoryInt, isFreeze); });
            featureHealth.initControl("Health:", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(HealthAddress, value, processMemory.ReadMemoryInt, processMemory.WriteMemoryInt, isFreeze); });
            featureMaxStamina.initControl("Max Stamina:", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(MaxStaminaAddress, value, ReadFloat, WriteFloat, isFreeze); });
            featureStamina.initControl("Stamina:", (ClickCallback)delegate(string value, bool isFreeze) { writeValue(StaminaAddress, value, ReadFloat, WriteFloat, isFreeze); });
            //featureChosenItem.initControl("Chosen Item:", (ClickCallback)delegate(string value) { writeValue(ChosenItemAddress, value, processMemory.ReadMemoryByte, processMemory.WriteMemoryByte); });
            initSlots();
        }

        public void InitCombobox() 
        {
            comboNullDmgOnHP.Items.Add(new ComboboxItem("50%", 50));
            comboNullDmgOnHP.Items.Add(new ComboboxItem("40%", 40));
            comboNullDmgOnHP.Items.Add(new ComboboxItem("30%", 30));
            comboNullDmgOnHP.Items.Add(new ComboboxItem("20%", 20));
            comboNullDmgOnHP.Items.Add(new ComboboxItem("10%", 10));
            comboNullDmgOnHP.Items.Add(new ComboboxItem("5%", 5));
            comboNullDmgOnHP.SelectedIndex = 3;
        }

        private void initSlots()
        {
            string name = "{0}:";
            int slotsCount = SlotsOffsets.Length;
            for (int i = 0; i < slotsCount; i++)
            {
                int index = i;
                SlotsAddress[index] = new AddressEntity<int>(SlotsOffsets[index]);
                slotControls[index].initControl(string.Format(name, index + 1), (ClickCallback)delegate(string value, bool isFreeze) { writeValue(SlotsAddress[index], value, processMemory.ReadMemoryByte, processMemory.WriteMemoryInt, isFreeze); }, (CheckValidate)CheckItemValidate);
            }
        }

        private void readValues()
        {
            if(processMemory == null)
            {
                processMemory = new ProcessMemory(GAME_NAME);
            }
            readAndFill(SoulsAddress, featureSouls, processMemory.ReadMemoryInt);
            readAndFill(GainedSoulsAddress, featureGainedSouls, processMemory.ReadMemoryInt);
            readAndFill(TorchAddress, featureTorchlight, ReadFloat);
            readAndFill(MaxHealthAddress, featureMaxHealth, processMemory.ReadMemoryInt);
            readAndFill(HealthAddress, featureHealth, processMemory.ReadMemoryInt);
            readAndFill(MaxStaminaAddress, featureMaxStamina, ReadFloat);
            readAndFill(StaminaAddress, featureStamina, ReadFloat);
            readItemSlotsValues();
        }

        private void readItemSlotsValues()
        {
            for (int i = 0; i < SlotsAddress.Length; i++)
            {
                readAndFill(SlotsAddress[i], slotControls[i], processMemory.ReadMemoryByte, true);
            }
        }

        private void readAndFill(AddressEntity<int> addressEntity, FeatureControl featureControl, ReadMemoryDel readMemoryDel, bool forceUpdate = false)
        {
            if (processMemory != null)
            {
                if (addressEntity.Address.ToInt32() < 1 || addressEntity.Value < 0 || forceUpdate)
                {
                    addressEntity.Address = processMemory.ReadPointer(baseAddress, addressEntity.Offsets);                    
                }
                if (addressEntity.Address.ToInt32() > 1)
                {
                    int tmpValue = readMemoryDel(addressEntity.Address);
                    featureControl.SetReadValue(tmpValue.ToString());
                    if (/*readValueOnce || (addressEntity.Value < 1 && tmpValue > addressEntity.Value)*/tmpValue != addressEntity.Value)
                    {
                        featureControl.SetValue(tmpValue.ToString());
                        readValueOnce = false;
                    }
                    addressEntity.Value = tmpValue;
                }                
            }
        }

        private int ReadFloat(IntPtr address)
        {
            return Convert.ToInt32(Math.Round(processMemory.ReadMemoryFloat(address)));
        }

        /*private void writeInt(string value, bool isFreeze, AddressEntity<int> addressEntity)
        {
            writeValue(addressEntity, value, processMemory.ReadMemoryInt, processMemory.WriteMemoryInt, isFreeze);
        }

        private void writeFloat(string value, bool isFreeze, AddressEntity<int> addressEntity)
        {
            writeValue(addressEntity, value, ReadFloat, WriteFloat, isFreeze); 
        }*/

        private void writeValue(AddressEntity<int> addressEntity, string value, ReadMemoryDel readMemoryDel, WriteMemoryDel writeMemoryDel, bool isFreeze)
        {            
            try
            {
                int iValue = Int32.Parse(value);
                int readValue = readMemoryDel(addressEntity.Address);
                if (readValue != iValue)
                {
                    writeMemoryDel(addressEntity.Address, iValue);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private bool WriteFloat(IntPtr address, int value)
        {
            float fValue = Convert.ToSingle(value);
            return processMemory.WriteMemoryFloat(address, fValue);
        }

        public bool CheckItemValidate(string value, TextBox textBox)
        {
            bool result = true;
            int iValue = Int32.Parse(value);
            if (iValue > 99)
            {
                result = false;
                textBox.Text = value = "99";
                MessageBox.Show(this, "Max value of an Item is 99!", "Warning");
            }
            else if (iValue < 1)
            {
                result = false;
                textBox.Text = value = "1";
                MessageBox.Show(this, "Min value of an Item is 1!", "Warning");
            }
            return result;
        }

        private void timerProcessWait_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(GAME_NAME);
            if (processes.Length > 0)
            {
                if (!searchOnce) 
                {
                    scanSigs(processes[0]);
                    labStatusInfo.Text = "The game is runnign!";
                    labStatusInfo.ForeColor = Color.Green;
                    enableControls(true);
                    searchOnce = true;
                }                
                readValues();                
            }
            else
            {
                labStatusInfo.Text = "Waiting for the game...";
                labStatusInfo.ForeColor = Color.Red;
                enableControls(false);
                CleanUp();
                searchOnce = false;
            }
         
        }

        private void scanSigs(Process process)
        {
            IntPtr tmpAddr = InfItemsHolder.ScanSignature(process);
            InfItemsAddress.Address = tmpAddr.ToInt32() > 0 ? tmpAddr : InfItemsAddress.Address;
            tmpAddr = InfSoulsHolder.ScanSignature(process);
            InfSoulsAddress.Address = tmpAddr.ToInt32() > 0 ? tmpAddr : InfSoulsAddress.Address;
            tmpAddr = InfSpellsHolder.ScanSignature(process);
            InfSpellsAddress.Address = tmpAddr.ToInt32() > 0 ? tmpAddr : InfSpellsAddress.Address;
            tmpAddr = InfHealthHolder.ScanSignature(process);
            InfHealthAddress.Address = tmpAddr.ToInt32() > 0 ? tmpAddr : InfHealthAddress.Address;
        }

        private void enableControls(bool enable)
        {
            featureTorchlight.Enabled = enable;
            featureMaxHealth.Enabled = false;
            featureHealth.Enabled = enable;
            featureMaxStamina.Enabled = false;
            featureStamina.Enabled = enable;
            groupItems.Enabled = enable;
            groupSouls.Enabled = enable;
            checkInfSpells.Enabled = enable;
            groupItemSlots.Enabled = enable;
            butUpdate.Enabled = enable;
            groupTestFeature.Enabled = enable;
        }

        private void CleanUp()
        {
            int slotsCount = SlotsOffsets.Length;
            checkInfSpells.Checked = false;
            checkSoulsReverse.Checked = false;
            radioItemsOff.Checked = true;
            featureSouls.reset();
            featureGainedSouls.reset();
            featureTorchlight.reset();
            featureMaxHealth.reset();
            featureHealth.reset();
            featureMaxStamina.reset();
            featureStamina.reset();
            checkInfHeath.Checked = false;
            for (int i = 0; i < slotControls.Length; i++)
            {
                slotControls[i].reset();
            }
            if (processMemory != null)
            {
                processMemory.Dispose();
                processMemory = null;
            }
            lockDamage = false;
        }

        private void SoulForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanUp();
        }

        private void checkInfSpells_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                byte[] threeNop = new byte[] { 0x90, 0x90, 0x90 };
                processMemory.WriteMemory(InfSpellsAddress.Address, threeNop);
            }
            else
            {
                byte[] resore = new byte[] { 0x88, 0x43, 0x18 };
                processMemory.WriteMemory(InfSpellsAddress.Address, resore);
            }
        }

        private void radioItemsOff_CheckedChanged(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                byte[] resore = new byte[] { 0x66, 0x29, 0x5E, 0x18 };
                processMemory.WriteMemory(InfItemsAddress.Address, resore);                
            }
        }

        private void radioItemsNoCons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                byte[] fourNop = new byte[] { 0x90, 0x90, 0x90, 0x90 };
                processMemory.WriteMemory(InfItemsAddress.Address, fourNop);
            }
        }

        private void radioItemsReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                byte[] reverseToAdd = new byte[] { 0x66, 0x01, 0x5E, 0x18 };
                processMemory.WriteMemory(InfItemsAddress.Address, reverseToAdd);
            }
        }

        private void checkSoulsReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                byte[] subToAdd = new byte[] { 0x01, 0xD0 };
                processMemory.WriteMemory(InfSoulsAddress.Address, subToAdd);
            }
            else
            {
                byte[] resore = new byte[] { 0x2B, 0xC2 };
                processMemory.WriteMemory(InfSoulsAddress.Address, resore);
            }
        }

        private void checkInfHeath_CheckedChanged(object sender, EventArgs e)
        {
            setTakenDamage(((CheckBox)sender).Checked);
        }

        private void checkNullDmgOnHP_CheckedChanged(object sender, EventArgs e)
        {
            timerCheckHP.Enabled = (((CheckBox)sender).Checked);
            setTakenDamage(((CheckBox)sender).Checked);
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SlotsAddress.Length; i++ )
            {
                SlotsAddress[i].Value = -1;
            }
            SoulsAddress.Value = -1;
            GainedSoulsAddress.Value = -1;
            TorchAddress.Value = -1;
            HealthAddress.Value = -1;
            StaminaAddress.Value = -1;
        }

        private void SoulForm_Load(object sender, EventArgs e)
        {
            ActiveControl = checkSoulsReverse;
        }

        private void timerCheckHP_Tick(object sender, EventArgs e)
        {
            try
            {
                int maxHP = processMemory.ReadMemoryInt(MaxHealthAddress.Address);
                if(maxHP > 0)
                {
                    int health = processMemory.ReadMemoryInt(HealthAddress.Address);
                    if (!lockDamage && (health / (maxHP / 100) <= (comboNullDmgOnHP.SelectedItem as ComboboxItem).Value) )
                    {
                        setTakenDamage(true);
                    }
                    else if (lockDamage && (health / (maxHP / 100)) >= 70)
                    {
                        setTakenDamage(false);
                    }
                }
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }            
        }

        private void setTakenDamage(bool freeze)
        {            
            if (freeze)
            {
                byte[] sixNop = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                processMemory.WriteMemory(InfHealthAddress.Address, sixNop);
            }
            else
            {
                byte[] resore = new byte[] { 0x89, 0x8E, 0xFC, 0x00, 0x00, 0x00, };
                processMemory.WriteMemory(InfHealthAddress.Address, resore);
            }
            lockDamage = freeze;
        }        
    }
}
