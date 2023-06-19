namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonMemoryShow = new System.Windows.Forms.Button();
            this.buttonMemorySub = new System.Windows.Forms.Button();
            this.buttonMemoryAdd = new System.Windows.Forms.Button();
            this.buttonMemoryR = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.textHistory = new System.Windows.Forms.TextBox();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BackColor = System.Drawing.SystemColors.MenuText;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.Window;
            this.result.HideSelection = false;
            this.result.Location = new System.Drawing.Point(9, 81);
            this.result.MaxLength = 32;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(236, 47);
            this.result.TabIndex = 33;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // buttonErase
            // 
            this.buttonErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonErase.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonErase.FlatAppearance.BorderSize = 0;
            this.buttonErase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonErase.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonErase.ForeColor = System.Drawing.Color.Black;
            this.buttonErase.Location = new System.Drawing.Point(193, 210);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(61, 59);
            this.buttonErase.TabIndex = 57;
            this.buttonErase.Text = "ы";
            this.buttonErase.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(131, 210);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(61, 59);
            this.buttonClear.TabIndex = 56;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearEntry.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonClearEntry.FlatAppearance.BorderSize = 0;
            this.buttonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearEntry.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.ForeColor = System.Drawing.Color.Black;
            this.buttonClearEntry.Location = new System.Drawing.Point(70, 210);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(61, 59);
            this.buttonClearEntry.TabIndex = 55;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMod.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonMod.FlatAppearance.BorderSize = 0;
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMod.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.ForeColor = System.Drawing.Color.Black;
            this.buttonMod.Location = new System.Drawing.Point(9, 210);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(61, 59);
            this.buttonMod.TabIndex = 54;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = false;
            // 
            // buttonDivision
            // 
            this.buttonDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDivision.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDivision.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.ForeColor = System.Drawing.Color.Black;
            this.buttonDivision.Location = new System.Drawing.Point(193, 271);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(61, 59);
            this.buttonDivision.TabIndex = 53;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSqrt.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSqrt.FlatAppearance.BorderSize = 0;
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSqrt.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSqrt.ForeColor = System.Drawing.Color.Black;
            this.buttonSqrt.Location = new System.Drawing.Point(131, 271);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(61, 59);
            this.buttonSqrt.TabIndex = 52;
            this.buttonSqrt.Text = "√x";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSquare.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSquare.FlatAppearance.BorderSize = 0;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSquare.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.ForeColor = System.Drawing.Color.Black;
            this.buttonSquare.Location = new System.Drawing.Point(70, 271);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(61, 59);
            this.buttonSquare.TabIndex = 51;
            this.buttonSquare.Text = "x² ";
            this.buttonSquare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInverse.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonInverse.FlatAppearance.BorderSize = 0;
            this.buttonInverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInverse.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInverse.ForeColor = System.Drawing.Color.Black;
            this.buttonInverse.Location = new System.Drawing.Point(9, 271);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(61, 59);
            this.buttonInverse.TabIndex = 50;
            this.buttonInverse.Text = "1/x";
            this.buttonInverse.UseVisualStyleBackColor = false;
            this.buttonInverse.Click += new System.EventHandler(this.buttonInverse_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResult.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonResult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonResult.FlatAppearance.BorderSize = 2;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.ForeColor = System.Drawing.Color.Black;
            this.buttonResult.Location = new System.Drawing.Point(193, 515);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(61, 59);
            this.buttonResult.TabIndex = 49;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoint.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPoint.FlatAppearance.BorderSize = 0;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPoint.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.ForeColor = System.Drawing.Color.Black;
            this.buttonPoint.Location = new System.Drawing.Point(131, 515);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(61, 59);
            this.buttonPoint.TabIndex = 48;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZero.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonZero.FlatAppearance.BorderSize = 0;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZero.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.ForeColor = System.Drawing.Color.Black;
            this.buttonZero.Location = new System.Drawing.Point(70, 515);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(61, 59);
            this.buttonZero.TabIndex = 47;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNegative.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonNegative.FlatAppearance.BorderSize = 0;
            this.buttonNegative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNegative.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNegative.ForeColor = System.Drawing.Color.Black;
            this.buttonNegative.Location = new System.Drawing.Point(9, 515);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(61, 59);
            this.buttonNegative.TabIndex = 46;
            this.buttonNegative.Text = "±";
            this.buttonNegative.UseVisualStyleBackColor = false;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(193, 454);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(61, 59);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThree.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThree.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.ForeColor = System.Drawing.Color.Black;
            this.buttonThree.Location = new System.Drawing.Point(131, 454);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(61, 59);
            this.buttonThree.TabIndex = 44;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTwo.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.ForeColor = System.Drawing.Color.Black;
            this.buttonTwo.Location = new System.Drawing.Point(70, 454);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(61, 59);
            this.buttonTwo.TabIndex = 43;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOne.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOne.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.ForeColor = System.Drawing.Color.Black;
            this.buttonOne.Location = new System.Drawing.Point(9, 454);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(61, 59);
            this.buttonOne.TabIndex = 42;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSub.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSub.FlatAppearance.BorderSize = 0;
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSub.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.Color.Black;
            this.buttonSub.Location = new System.Drawing.Point(193, 393);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(61, 59);
            this.buttonSub.TabIndex = 41;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSix.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSix.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.ForeColor = System.Drawing.Color.Black;
            this.buttonSix.Location = new System.Drawing.Point(131, 393);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(61, 59);
            this.buttonSix.TabIndex = 40;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFive.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFive.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.ForeColor = System.Drawing.Color.Black;
            this.buttonFive.Location = new System.Drawing.Point(70, 393);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(61, 59);
            this.buttonFive.TabIndex = 39;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFour.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFour.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.ForeColor = System.Drawing.Color.Black;
            this.buttonFour.Location = new System.Drawing.Point(9, 393);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(61, 59);
            this.buttonFour.TabIndex = 38;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiplication.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonMultiplication.FlatAppearance.BorderSize = 0;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMultiplication.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.ForeColor = System.Drawing.Color.Black;
            this.buttonMultiplication.Location = new System.Drawing.Point(193, 332);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(61, 59);
            this.buttonMultiplication.TabIndex = 37;
            this.buttonMultiplication.Text = "x";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNine.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNine.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.ForeColor = System.Drawing.Color.Black;
            this.buttonNine.Location = new System.Drawing.Point(131, 332);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(61, 59);
            this.buttonNine.TabIndex = 36;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEight.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEight.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.ForeColor = System.Drawing.Color.Black;
            this.buttonEight.Location = new System.Drawing.Point(70, 332);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(61, 59);
            this.buttonEight.TabIndex = 35;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeven.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeven.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.ForeColor = System.Drawing.Color.Black;
            this.buttonSeven.Location = new System.Drawing.Point(9, 332);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(61, 59);
            this.buttonSeven.TabIndex = 34;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonMemoryShow
            // 
            this.buttonMemoryShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMemoryShow.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonMemoryShow.FlatAppearance.BorderSize = 0;
            this.buttonMemoryShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryShow.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryShow.ForeColor = System.Drawing.Color.White;
            this.buttonMemoryShow.Location = new System.Drawing.Point(193, 156);
            this.buttonMemoryShow.Name = "buttonMemoryShow";
            this.buttonMemoryShow.Size = new System.Drawing.Size(42, 35);
            this.buttonMemoryShow.TabIndex = 62;
            this.buttonMemoryShow.Text = "MS";
            this.buttonMemoryShow.UseVisualStyleBackColor = false;
            // 
            // buttonMemorySub
            // 
            this.buttonMemorySub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMemorySub.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonMemorySub.FlatAppearance.BorderSize = 0;
            this.buttonMemorySub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemorySub.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemorySub.ForeColor = System.Drawing.Color.White;
            this.buttonMemorySub.Location = new System.Drawing.Point(149, 156);
            this.buttonMemorySub.Name = "buttonMemorySub";
            this.buttonMemorySub.Size = new System.Drawing.Size(42, 35);
            this.buttonMemorySub.TabIndex = 61;
            this.buttonMemorySub.Text = "M-";
            this.buttonMemorySub.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryAdd
            // 
            this.buttonMemoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMemoryAdd.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonMemoryAdd.FlatAppearance.BorderSize = 0;
            this.buttonMemoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryAdd.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryAdd.ForeColor = System.Drawing.Color.White;
            this.buttonMemoryAdd.Location = new System.Drawing.Point(105, 156);
            this.buttonMemoryAdd.Name = "buttonMemoryAdd";
            this.buttonMemoryAdd.Size = new System.Drawing.Size(42, 35);
            this.buttonMemoryAdd.TabIndex = 60;
            this.buttonMemoryAdd.Text = "M+";
            this.buttonMemoryAdd.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryR
            // 
            this.buttonMemoryR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMemoryR.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonMemoryR.FlatAppearance.BorderSize = 0;
            this.buttonMemoryR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryR.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryR.ForeColor = System.Drawing.Color.White;
            this.buttonMemoryR.Location = new System.Drawing.Point(61, 156);
            this.buttonMemoryR.Name = "buttonMemoryR";
            this.buttonMemoryR.Size = new System.Drawing.Size(42, 35);
            this.buttonMemoryR.TabIndex = 59;
            this.buttonMemoryR.Text = "MR";
            this.buttonMemoryR.UseVisualStyleBackColor = false;
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMemoryClear.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonMemoryClear.FlatAppearance.BorderSize = 0;
            this.buttonMemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemoryClear.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemoryClear.ForeColor = System.Drawing.Color.White;
            this.buttonMemoryClear.Location = new System.Drawing.Point(17, 156);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(42, 35);
            this.buttonMemoryClear.TabIndex = 58;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = false;
            // 
            // textHistory
            // 
            this.textHistory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHistory.Location = new System.Drawing.Point(9, 46);
            this.textHistory.Name = "textHistory";
            this.textHistory.Size = new System.Drawing.Size(245, 29);
            this.textHistory.TabIndex = 63;
            this.textHistory.Click += new System.EventHandler(this.ButtonNum_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHistory.BackColor = System.Drawing.SystemColors.MenuText;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHistory.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(223, 12);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(31, 28);
            this.buttonHistory.TabIndex = 64;
            this.buttonHistory.Text = "Story";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(260, 584);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.textHistory);
            this.Controls.Add(this.buttonMemoryShow);
            this.Controls.Add(this.buttonMemorySub);
            this.Controls.Add(this.buttonMemoryAdd);
            this.Controls.Add(this.buttonMemoryR);
            this.Controls.Add(this.buttonMemoryClear);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.result);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximumSize = new System.Drawing.Size(276, 623);
            this.MinimumSize = new System.Drawing.Size(276, 623);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonMemoryShow;
        private System.Windows.Forms.Button buttonMemorySub;
        private System.Windows.Forms.Button buttonMemoryAdd;
        private System.Windows.Forms.Button buttonMemoryR;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.TextBox textHistory;
        private System.Windows.Forms.Button buttonHistory;
    }
}

