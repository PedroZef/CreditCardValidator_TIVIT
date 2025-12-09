namespace CreditCardValidator;
using System;
using System.Drawing;
using System.Windows.Forms;

public class InputForm : Form
{
    private Label lblPrompt;
    private TextBox txtInput;
    private Button btnOK;
    private Button btnCancel;
    private Label lblFooter;

    public string InputValue { get; private set; }

    public InputForm(string title, string prompt)
    {
        InitializeComponent();
        this.Text = title;
        this.lblPrompt.Text = prompt;
        this.AcceptButton = this.btnOK;
        this.CancelButton = this.btnCancel;
    }

    private void InitializeComponent()
    {
        this.lblPrompt = new Label();
        this.txtInput = new TextBox();
        this.btnOK = new Button();
        this.btnCancel = new Button();
        this.lblFooter = new Label();
        
        this.SuspendLayout();

        // 
        // Form settings
        // 
        this.ClientSize = new Size(400, 180);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        
        // 
        // lblPrompt
        // 
        this.lblPrompt.AutoSize = true;
        this.lblPrompt.Location = new Point(12, 15);
        this.lblPrompt.Name = "lblPrompt";
        
        // 
        // txtInput
        // 
        this.txtInput.Location = new Point(12, 45);
        this.txtInput.Size = new Size(376, 23);
        this.txtInput.Name = "txtInput";

        // 
        // btnOK
        // 
        this.btnOK.Location = new Point(232, 85);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new Size(75, 23);
        this.btnOK.Text = "OK";
        this.btnOK.Click += (sender, e) => 
        {
            this.InputValue = this.txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        };

        // 
        // btnCancel
        // 
        this.btnCancel.Location = new Point(313, 85);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(75, 23);
        this.btnCancel.Text = "Cancelar";
        this.btnCancel.Click += (sender, e) => 
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        };

        // 
        // lblFooter
        // 
        this.lblFooter.Dock = DockStyle.Bottom;
        this.lblFooter.Font = new Font("Segoe UI", 10F);
        this.lblFooter.Name = "lblFooter";
        this.lblFooter.Size = new Size(400, 30);
        this.lblFooter.Text = "Desenvolvido por Pedro Zeferino da Silva";
        this.lblFooter.TextAlign = ContentAlignment.MiddleCenter;

        // 
        // InputForm
        // 
        this.Controls.Add(this.lblPrompt);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.btnOK);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.lblFooter);

        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
