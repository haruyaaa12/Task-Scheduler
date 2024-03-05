namespace CodeChum
{
    partial class TaskScheduler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            TaskName = new TextBox();
            DatePicker = new DateTimePicker();
            label3 = new Label();
            lblToDoList = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 56);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 157);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Task Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(67, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // TaskName
            // 
            TaskName.Location = new Point(67, 191);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(246, 27);
            TaskName.TabIndex = 3;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(67, 88);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 27);
            DatePicker.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 56);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "TO DO:";
            // 
            // lblToDoList
            // 
            lblToDoList.AutoSize = true;
            lblToDoList.Location = new Point(505, 88);
            lblToDoList.Name = "lblToDoList";
            lblToDoList.Size = new Size(0, 20);
            lblToDoList.TabIndex = 6;
            // 
            // TaskScheduler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 400);
            Controls.Add(lblToDoList);
            Controls.Add(label3);
            Controls.Add(DatePicker);
            Controls.Add(TaskName);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskScheduler";
            Text = "TaskScheduler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdd;
        private TextBox TaskName;
        private DateTimePicker DatePicker;
        private Label label3;
        private Label lblToDoList;
    }
}
