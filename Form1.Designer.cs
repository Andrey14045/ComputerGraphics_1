namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вОттенкахСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иатричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаусовскаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеВДвиженииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальныеВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cтеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cерыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cтруктурныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.cтруктурныйЭлементToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.иатричныеToolStripMenuItem,
            this.матМорфологияToolStripMenuItem,
            this.горизонтальныеВолныToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem,
            this.переносToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.cтеклоToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem,
            this.cерыйМирToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.вОттенкахСерогоToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркостьToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // вОттенкахСерогоToolStripMenuItem
            // 
            this.вОттенкахСерогоToolStripMenuItem.Name = "вОттенкахСерогоToolStripMenuItem";
            this.вОттенкахСерогоToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.вОттенкахСерогоToolStripMenuItem.Text = "В оттенках серого";
            this.вОттенкахСерогоToolStripMenuItem.Click += new System.EventHandler(this.вОттенкахСерогоToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.яркостьToolStripMenuItem_Click);
            // 
            // иатричныеToolStripMenuItem
            // 
            this.иатричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.гаусовскаяToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.фильтрПрюиттаToolStripMenuItem,
            this.размытиеВДвиженииToolStripMenuItem});
            this.иатричныеToolStripMenuItem.Name = "иатричныеToolStripMenuItem";
            this.иатричныеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.иатричныеToolStripMenuItem.Text = "Матричные";
            this.иатричныеToolStripMenuItem.Click += new System.EventHandler(this.иатричныеToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // гаусовскаяToolStripMenuItem
            // 
            this.гаусовскаяToolStripMenuItem.Name = "гаусовскаяToolStripMenuItem";
            this.гаусовскаяToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.гаусовскаяToolStripMenuItem.Text = "Гаусовская";
            this.гаусовскаяToolStripMenuItem.Click += new System.EventHandler(this.гаусовскаяToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.фильтрСобеляToolStripMenuItem.Text = "ФильтрСобеля";
            this.фильтрСобеляToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляToolStripMenuItem_Click);
            // 
            // фильтрПрюиттаToolStripMenuItem
            // 
            this.фильтрПрюиттаToolStripMenuItem.Name = "фильтрПрюиттаToolStripMenuItem";
            this.фильтрПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.фильтрПрюиттаToolStripMenuItem.Text = "ФильтрПрюитта";
            this.фильтрПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.фильтрПрюиттаToolStripMenuItem_Click);
            // 
            // размытиеВДвиженииToolStripMenuItem
            // 
            this.размытиеВДвиженииToolStripMenuItem.Name = "размытиеВДвиженииToolStripMenuItem";
            this.размытиеВДвиженииToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.размытиеВДвиженииToolStripMenuItem.Text = "РазмытиеВДвижении";
            this.размытиеВДвиженииToolStripMenuItem.Click += new System.EventHandler(this.размытиеВДвиженииToolStripMenuItem_Click);
            // 
            // горизонтальныеВолныToolStripMenuItem
            // 
            this.горизонтальныеВолныToolStripMenuItem.Name = "горизонтальныеВолныToolStripMenuItem";
            this.горизонтальныеВолныToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.горизонтальныеВолныToolStripMenuItem.Text = "ГоризонтальныеВолны";
            this.горизонтальныеВолныToolStripMenuItem.Click += new System.EventHandler(this.горизонтальныеВолныToolStripMenuItem_Click);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.идеальныйОтражательToolStripMenuItem.Text = "ИдеальныйОтражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.идеальныйОтражательToolStripMenuItem_Click);
            // 
            // переносToolStripMenuItem
            // 
            this.переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            this.переносToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.переносToolStripMenuItem.Text = "Перенос";
            this.переносToolStripMenuItem.Click += new System.EventHandler(this.переносToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // cтеклоToolStripMenuItem
            // 
            this.cтеклоToolStripMenuItem.Name = "cтеклоToolStripMenuItem";
            this.cтеклоToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cтеклоToolStripMenuItem.Text = "Cтекло";
            this.cтеклоToolStripMenuItem.Click += new System.EventHandler(this.cтеклоToolStripMenuItem_Click);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.медианныйФильтрToolStripMenuItem.Text = "МедианныйФильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сужениеToolStripMenuItem,
            this.расширениеToolStripMenuItem,
            this.открытиеToolStripMenuItem,
            this.закрытиеToolStripMenuItem,
            this.topHatToolStripMenuItem});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.матМорфологияToolStripMenuItem.Text = "МатМорфология";
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сужениеToolStripMenuItem.Text = "Сужение";
            this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.сужениеToolStripMenuItem_Click);
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расширениеToolStripMenuItem.Text = "Расширение";
            this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.расширениеToolStripMenuItem_Click);
            // 
            // открытиеToolStripMenuItem
            // 
            this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытиеToolStripMenuItem.Text = "Открытие";
            this.открытиеToolStripMenuItem.Click += new System.EventHandler(this.открытиеToolStripMenuItem_Click);
            // 
            // закрытиеToolStripMenuItem
            // 
            this.закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            this.закрытиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытиеToolStripMenuItem.Text = "Закрытие";
            this.закрытиеToolStripMenuItem.Click += new System.EventHandler(this.закрытиеToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topHatToolStripMenuItem.Text = "TopHat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 312);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(759, 22);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.линейноеРастяжениеToolStripMenuItem.Text = "ЛинейноеРастяжение";
            this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
            // 
            // cерыйМирToolStripMenuItem
            // 
            this.cерыйМирToolStripMenuItem.Name = "cерыйМирToolStripMenuItem";
            this.cерыйМирToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cерыйМирToolStripMenuItem.Text = "CерыйМир";
            this.cерыйМирToolStripMenuItem.Click += new System.EventHandler(this.cерыйМирToolStripMenuItem_Click);
            // 
            // cтруктурныйЭлементToolStripMenuItem
            // 
            this.cтруктурныйЭлементToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x5ToolStripMenuItem});
            this.cтруктурныйЭлементToolStripMenuItem.Name = "cтруктурныйЭлементToolStripMenuItem";
            this.cтруктурныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.cтруктурныйЭлементToolStripMenuItem.Text = "Cтруктурный Элемент";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x3ToolStripMenuItem.Text = "3x3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x5ToolStripMenuItem.Text = "5x5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иатричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гаусовскаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вОттенкахСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cтеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переносToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальныеВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеВДвиженииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cерыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cтруктурныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
    }
}

