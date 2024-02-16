namespace Pizza_Project
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaOrder));
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lablelToppings = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lablelSize = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelWheretoEat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lablelCrustType = new System.Windows.Forms.Label();
            this.btnPickOrder = new System.Windows.Forms.Button();
            this.btnRestOrder = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTotalPriceRes = new System.Windows.Forms.Label();
            this.labelWheretoEatRes = new System.Windows.Forms.Label();
            this.labelCrustTypeRes = new System.Windows.Forms.Label();
            this.labelToppingsRes = new System.Windows.Forms.Label();
            this.labelSizeRes = new System.Windows.Forms.Label();
            this.labelTotalPriceOrderSummary = new System.Windows.Forms.Label();
            this.labelWheretoEatOrderSummary = new System.Windows.Forms.Label();
            this.labelCrustTypeOrderSummary = new System.Windows.Forms.Label();
            this.labelToppingsOrderSummary = new System.Windows.Forms.Label();
            this.labelSizeOrderSummary = new System.Windows.Forms.Label();
            this.labelOrderSummary = new System.Windows.Forms.Label();
            this.panelPizzaComponent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelPizzaComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSmall.ForeColor = System.Drawing.Color.White;
            this.rbSmall.Location = new System.Drawing.Point(18, 44);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.Transparent;
            this.rbMedium.ForeColor = System.Drawing.Color.White;
            this.rbMedium.Location = new System.Drawing.Point(18, 81);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rbLarge.ForeColor = System.Drawing.Color.White;
            this.rbLarge.Location = new System.Drawing.Point(18, 118);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.BackColor = System.Drawing.Color.Transparent;
            this.rbThinkCrust.ForeColor = System.Drawing.Color.White;
            this.rbThinkCrust.Location = new System.Drawing.Point(18, 81);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(94, 20);
            this.rbThinkCrust.TabIndex = 4;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "Thick Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = false;
            this.rbThinkCrust.UseWaitCursor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.Color.Transparent;
            this.rbThinCrust.ForeColor = System.Drawing.Color.White;
            this.rbThinCrust.Location = new System.Drawing.Point(18, 43);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.UseWaitCursor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.BackColor = System.Drawing.Color.Transparent;
            this.chkExtraChees.ForeColor = System.Drawing.Color.White;
            this.chkExtraChees.Location = new System.Drawing.Point(19, 44);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(101, 20);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = false;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.Transparent;
            this.chkMushrooms.ForeColor = System.Drawing.Color.White;
            this.chkMushrooms.Location = new System.Drawing.Point(19, 80);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.BackColor = System.Drawing.Color.Transparent;
            this.chkTomato.ForeColor = System.Drawing.Color.White;
            this.chkTomato.Location = new System.Drawing.Point(19, 117);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(91, 20);
            this.chkTomato.TabIndex = 2;
            this.chkTomato.Text = "Tomatoes";
            this.chkTomato.UseVisualStyleBackColor = false;
            this.chkTomato.CheckedChanged += new System.EventHandler(this.chkTomato_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Transparent;
            this.chkOnion.ForeColor = System.Drawing.Color.White;
            this.chkOnion.Location = new System.Drawing.Point(157, 44);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.Transparent;
            this.chkOlives.ForeColor = System.Drawing.Color.White;
            this.chkOlives.Location = new System.Drawing.Point(157, 81);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.BackColor = System.Drawing.Color.Transparent;
            this.chkGreenPeppers.ForeColor = System.Drawing.Color.White;
            this.chkGreenPeppers.Location = new System.Drawing.Point(157, 117);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = false;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.rbTakeOut.ForeColor = System.Drawing.Color.White;
            this.rbTakeOut.Location = new System.Drawing.Point(157, 40);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 4;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = false;
            this.rbTakeOut.UseWaitCursor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.Color.Transparent;
            this.rbEatIn.ForeColor = System.Drawing.Color.White;
            this.rbEatIn.Location = new System.Drawing.Point(19, 40);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 3;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.UseWaitCursor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkGreenPeppers);
            this.panel1.Controls.Add(this.lablelToppings);
            this.panel1.Controls.Add(this.chkMushrooms);
            this.panel1.Controls.Add(this.chkOlives);
            this.panel1.Controls.Add(this.chkExtraChees);
            this.panel1.Controls.Add(this.chkOnion);
            this.panel1.Controls.Add(this.chkTomato);
            this.panel1.Location = new System.Drawing.Point(275, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 140);
            this.panel1.TabIndex = 6;
            // 
            // lablelToppings
            // 
            this.lablelToppings.AutoSize = true;
            this.lablelToppings.BackColor = System.Drawing.Color.Transparent;
            this.lablelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablelToppings.ForeColor = System.Drawing.Color.White;
            this.lablelToppings.Location = new System.Drawing.Point(3, 9);
            this.lablelToppings.Name = "lablelToppings";
            this.lablelToppings.Size = new System.Drawing.Size(77, 18);
            this.lablelToppings.TabIndex = 12;
            this.lablelToppings.Text = "Toppings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbLarge);
            this.panel2.Controls.Add(this.rbMedium);
            this.panel2.Controls.Add(this.rbSmall);
            this.panel2.Controls.Add(this.lablelSize);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 140);
            this.panel2.TabIndex = 7;
            // 
            // lablelSize
            // 
            this.lablelSize.AutoSize = true;
            this.lablelSize.BackColor = System.Drawing.Color.Transparent;
            this.lablelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablelSize.ForeColor = System.Drawing.Color.White;
            this.lablelSize.Location = new System.Drawing.Point(3, 9);
            this.lablelSize.Name = "lablelSize";
            this.lablelSize.Size = new System.Drawing.Size(41, 18);
            this.lablelSize.TabIndex = 10;
            this.lablelSize.Text = "Size";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelWheretoEat);
            this.panel3.Controls.Add(this.rbTakeOut);
            this.panel3.Controls.Add(this.rbEatIn);
            this.panel3.Location = new System.Drawing.Point(275, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 63);
            this.panel3.TabIndex = 8;
            // 
            // labelWheretoEat
            // 
            this.labelWheretoEat.AutoSize = true;
            this.labelWheretoEat.BackColor = System.Drawing.Color.Transparent;
            this.labelWheretoEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWheretoEat.ForeColor = System.Drawing.Color.White;
            this.labelWheretoEat.Location = new System.Drawing.Point(3, 9);
            this.labelWheretoEat.Name = "labelWheretoEat";
            this.labelWheretoEat.Size = new System.Drawing.Size(107, 18);
            this.labelWheretoEat.TabIndex = 13;
            this.labelWheretoEat.Text = "Where to Eat";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbThinkCrust);
            this.panel4.Controls.Add(this.rbThinCrust);
            this.panel4.Controls.Add(this.lablelCrustType);
            this.panel4.Location = new System.Drawing.Point(10, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 104);
            this.panel4.TabIndex = 9;
            // 
            // lablelCrustType
            // 
            this.lablelCrustType.AutoSize = true;
            this.lablelCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lablelCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablelCrustType.ForeColor = System.Drawing.Color.White;
            this.lablelCrustType.Location = new System.Drawing.Point(3, 9);
            this.lablelCrustType.Name = "lablelCrustType";
            this.lablelCrustType.Size = new System.Drawing.Size(90, 18);
            this.lablelCrustType.TabIndex = 11;
            this.lablelCrustType.Text = "Crust Type";
            // 
            // btnPickOrder
            // 
            this.btnPickOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnPickOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPickOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPickOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPickOrder.ForeColor = System.Drawing.Color.White;
            this.btnPickOrder.Location = new System.Drawing.Point(288, 423);
            this.btnPickOrder.Name = "btnPickOrder";
            this.btnPickOrder.Size = new System.Drawing.Size(101, 38);
            this.btnPickOrder.TabIndex = 10;
            this.btnPickOrder.Text = "Pick Order";
            this.btnPickOrder.UseVisualStyleBackColor = false;
            this.btnPickOrder.Click += new System.EventHandler(this.btnPickOrder_Click);
            // 
            // btnRestOrder
            // 
            this.btnRestOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnRestOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestOrder.ForeColor = System.Drawing.Color.White;
            this.btnRestOrder.Location = new System.Drawing.Point(470, 423);
            this.btnRestOrder.Name = "btnRestOrder";
            this.btnRestOrder.Size = new System.Drawing.Size(101, 38);
            this.btnRestOrder.TabIndex = 11;
            this.btnRestOrder.Text = "Rest Order";
            this.btnRestOrder.UseVisualStyleBackColor = false;
            this.btnRestOrder.Click += new System.EventHandler(this.btnRestOrder_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.labelTotalPriceRes);
            this.panel5.Controls.Add(this.labelWheretoEatRes);
            this.panel5.Controls.Add(this.labelCrustTypeRes);
            this.panel5.Controls.Add(this.labelToppingsRes);
            this.panel5.Controls.Add(this.labelSizeRes);
            this.panel5.Controls.Add(this.labelTotalPriceOrderSummary);
            this.panel5.Controls.Add(this.labelWheretoEatOrderSummary);
            this.panel5.Controls.Add(this.labelCrustTypeOrderSummary);
            this.panel5.Controls.Add(this.labelToppingsOrderSummary);
            this.panel5.Controls.Add(this.labelSizeOrderSummary);
            this.panel5.Controls.Add(this.labelOrderSummary);
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(635, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 309);
            this.panel5.TabIndex = 12;
            // 
            // labelTotalPriceRes
            // 
            this.labelTotalPriceRes.AutoSize = true;
            this.labelTotalPriceRes.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTotalPriceRes.Location = new System.Drawing.Point(114, 235);
            this.labelTotalPriceRes.Name = "labelTotalPriceRes";
            this.labelTotalPriceRes.Size = new System.Drawing.Size(93, 65);
            this.labelTotalPriceRes.TabIndex = 22;
            this.labelTotalPriceRes.Tag = "short";
            this.labelTotalPriceRes.Text = "$0";
            // 
            // labelWheretoEatRes
            // 
            this.labelWheretoEatRes.AutoSize = true;
            this.labelWheretoEatRes.BackColor = System.Drawing.Color.Transparent;
            this.labelWheretoEatRes.ForeColor = System.Drawing.Color.White;
            this.labelWheretoEatRes.Location = new System.Drawing.Point(130, 200);
            this.labelWheretoEatRes.Name = "labelWheretoEatRes";
            this.labelWheretoEatRes.Size = new System.Drawing.Size(41, 16);
            this.labelWheretoEatRes.TabIndex = 21;
            this.labelWheretoEatRes.Text = "NULL";
            // 
            // labelCrustTypeRes
            // 
            this.labelCrustTypeRes.AutoSize = true;
            this.labelCrustTypeRes.BackColor = System.Drawing.Color.Transparent;
            this.labelCrustTypeRes.ForeColor = System.Drawing.Color.White;
            this.labelCrustTypeRes.Location = new System.Drawing.Point(114, 165);
            this.labelCrustTypeRes.Name = "labelCrustTypeRes";
            this.labelCrustTypeRes.Size = new System.Drawing.Size(41, 16);
            this.labelCrustTypeRes.TabIndex = 20;
            this.labelCrustTypeRes.Text = "NULL";
            // 
            // labelToppingsRes
            // 
            this.labelToppingsRes.AutoSize = true;
            this.labelToppingsRes.BackColor = System.Drawing.Color.Transparent;
            this.labelToppingsRes.ForeColor = System.Drawing.Color.White;
            this.labelToppingsRes.Location = new System.Drawing.Point(45, 97);
            this.labelToppingsRes.Name = "labelToppingsRes";
            this.labelToppingsRes.Size = new System.Drawing.Size(86, 16);
            this.labelToppingsRes.TabIndex = 19;
            this.labelToppingsRes.Text = "No Toppings";
            // 
            // labelSizeRes
            // 
            this.labelSizeRes.AutoSize = true;
            this.labelSizeRes.BackColor = System.Drawing.Color.Transparent;
            this.labelSizeRes.ForeColor = System.Drawing.Color.White;
            this.labelSizeRes.Location = new System.Drawing.Point(64, 43);
            this.labelSizeRes.Name = "labelSizeRes";
            this.labelSizeRes.Size = new System.Drawing.Size(41, 16);
            this.labelSizeRes.TabIndex = 18;
            this.labelSizeRes.Text = "NULL";
            // 
            // labelTotalPriceOrderSummary
            // 
            this.labelTotalPriceOrderSummary.AutoSize = true;
            this.labelTotalPriceOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPriceOrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceOrderSummary.ForeColor = System.Drawing.Color.White;
            this.labelTotalPriceOrderSummary.Location = new System.Drawing.Point(23, 232);
            this.labelTotalPriceOrderSummary.Name = "labelTotalPriceOrderSummary";
            this.labelTotalPriceOrderSummary.Size = new System.Drawing.Size(95, 19);
            this.labelTotalPriceOrderSummary.TabIndex = 17;
            this.labelTotalPriceOrderSummary.Text = "Total Price : ";
            // 
            // labelWheretoEatOrderSummary
            // 
            this.labelWheretoEatOrderSummary.AutoSize = true;
            this.labelWheretoEatOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelWheretoEatOrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWheretoEatOrderSummary.ForeColor = System.Drawing.Color.White;
            this.labelWheretoEatOrderSummary.Location = new System.Drawing.Point(22, 197);
            this.labelWheretoEatOrderSummary.Name = "labelWheretoEatOrderSummary";
            this.labelWheretoEatOrderSummary.Size = new System.Drawing.Size(112, 19);
            this.labelWheretoEatOrderSummary.TabIndex = 16;
            this.labelWheretoEatOrderSummary.Text = "Where to Eat : ";
            // 
            // labelCrustTypeOrderSummary
            // 
            this.labelCrustTypeOrderSummary.AutoSize = true;
            this.labelCrustTypeOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelCrustTypeOrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrustTypeOrderSummary.ForeColor = System.Drawing.Color.White;
            this.labelCrustTypeOrderSummary.Location = new System.Drawing.Point(22, 162);
            this.labelCrustTypeOrderSummary.Name = "labelCrustTypeOrderSummary";
            this.labelCrustTypeOrderSummary.Size = new System.Drawing.Size(96, 19);
            this.labelCrustTypeOrderSummary.TabIndex = 15;
            this.labelCrustTypeOrderSummary.Text = "Curst Type : ";
            // 
            // labelToppingsOrderSummary
            // 
            this.labelToppingsOrderSummary.AutoSize = true;
            this.labelToppingsOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelToppingsOrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppingsOrderSummary.ForeColor = System.Drawing.Color.White;
            this.labelToppingsOrderSummary.Location = new System.Drawing.Point(19, 78);
            this.labelToppingsOrderSummary.Name = "labelToppingsOrderSummary";
            this.labelToppingsOrderSummary.Size = new System.Drawing.Size(86, 19);
            this.labelToppingsOrderSummary.TabIndex = 14;
            this.labelToppingsOrderSummary.Text = "Toppings : ";
            // 
            // labelSizeOrderSummary
            // 
            this.labelSizeOrderSummary.AutoSize = true;
            this.labelSizeOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelSizeOrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeOrderSummary.ForeColor = System.Drawing.Color.White;
            this.labelSizeOrderSummary.Location = new System.Drawing.Point(22, 41);
            this.labelSizeOrderSummary.Name = "labelSizeOrderSummary";
            this.labelSizeOrderSummary.Size = new System.Drawing.Size(48, 19);
            this.labelSizeOrderSummary.TabIndex = 11;
            this.labelSizeOrderSummary.Text = "Size : ";
            // 
            // labelOrderSummary
            // 
            this.labelOrderSummary.AutoSize = true;
            this.labelOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderSummary.ForeColor = System.Drawing.Color.White;
            this.labelOrderSummary.Location = new System.Drawing.Point(3, 7);
            this.labelOrderSummary.Name = "labelOrderSummary";
            this.labelOrderSummary.Size = new System.Drawing.Size(127, 18);
            this.labelOrderSummary.TabIndex = 13;
            this.labelOrderSummary.Text = "Order Summary\r\n";
            // 
            // panelPizzaComponent
            // 
            this.panelPizzaComponent.BackColor = System.Drawing.Color.Transparent;
            this.panelPizzaComponent.Controls.Add(this.panel4);
            this.panelPizzaComponent.Controls.Add(this.panel3);
            this.panelPizzaComponent.Controls.Add(this.panel2);
            this.panelPizzaComponent.Controls.Add(this.panel1);
            this.panelPizzaComponent.ForeColor = System.Drawing.Color.Transparent;
            this.panelPizzaComponent.Location = new System.Drawing.Point(13, 120);
            this.panelPizzaComponent.Name = "panelPizzaComponent";
            this.panelPizzaComponent.Size = new System.Drawing.Size(579, 297);
            this.panelPizzaComponent.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Caveat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 103);
            this.label2.TabIndex = 15;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Caveat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(404, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 103);
            this.label3.TabIndex = 16;
            this.label3.Text = "Your";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Caveat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(572, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 103);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pizza";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(872, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 443);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-170, -74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(863, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 487);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPizzaComponent);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnRestOrder);
            this.Controls.Add(this.btnPickOrder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelPizzaComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lablelSize;
        private System.Windows.Forms.Label lablelCrustType;
        private System.Windows.Forms.Label lablelToppings;
        private System.Windows.Forms.Label labelWheretoEat;
        private System.Windows.Forms.Button btnPickOrder;
        private System.Windows.Forms.Button btnRestOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelOrderSummary;
        private System.Windows.Forms.Label labelTotalPriceOrderSummary;
        private System.Windows.Forms.Label labelWheretoEatOrderSummary;
        private System.Windows.Forms.Label labelCrustTypeOrderSummary;
        private System.Windows.Forms.Label labelToppingsOrderSummary;
        private System.Windows.Forms.Label labelSizeOrderSummary;
        private System.Windows.Forms.Label labelTotalPriceRes;
        private System.Windows.Forms.Label labelWheretoEatRes;
        private System.Windows.Forms.Label labelCrustTypeRes;
        private System.Windows.Forms.Label labelToppingsRes;
        private System.Windows.Forms.Label labelSizeRes;
        private System.Windows.Forms.Panel panelPizzaComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

