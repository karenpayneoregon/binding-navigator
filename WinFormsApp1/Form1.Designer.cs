namespace WinFormsApp1;

partial class Form1
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
        CustomersBindingNavigator = new NavigatorLibrary.CoreBindingNavigator();
        CustomersDataGridView = new DataGridView();
        CustomersBindingNavigator.BeginInit();
        ((System.ComponentModel.ISupportInitialize)CustomersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // CustomersBindingNavigator
        // 
        CustomersBindingNavigator.ImageScalingSize = new Size(20, 20);
        CustomersBindingNavigator.Location = new Point(0, 0);
        CustomersBindingNavigator.Name = "CustomersBindingNavigator";
        CustomersBindingNavigator.Size = new Size(829, 27);
        CustomersBindingNavigator.TabIndex = 0;
        CustomersBindingNavigator.Text = "coreBindingNavigator1";
        // 
        // CustomersDataGridView
        // 
        CustomersDataGridView.AllowUserToAddRows = false;
        CustomersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        CustomersDataGridView.Location = new Point(12, 47);
        CustomersDataGridView.Name = "CustomersDataGridView";
        CustomersDataGridView.RowHeadersWidth = 51;
        CustomersDataGridView.Size = new Size(802, 338);
        CustomersDataGridView.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(829, 409);
        Controls.Add(CustomersDataGridView);
        Controls.Add(CustomersBindingNavigator);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CoreBindingNavigator";
        CustomersBindingNavigator.EndInit();
        ((System.ComponentModel.ISupportInitialize)CustomersDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NavigatorLibrary.CoreBindingNavigator CustomersBindingNavigator;
    private DataGridView CustomersDataGridView;
}
