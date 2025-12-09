namespace CreditCardValidator;
public class FormScreen : Form
{
    private System.Windows.Forms.Timer timer;

    private readonly Label _lblFooter = new()
    {
        Text = "© 2025 - Pedro Zeferino da Silva",
        Font = new Font("Segoe UI", 10F),
        Name = "lblFooter",
        Size = new Size(800, 30),
        Dock = DockStyle.Bottom,
        TextAlign = ContentAlignment.MiddleCenter
    };

    public FormScreen()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.timer = new System.Windows.Forms.Timer();
        var pictureBox = new PictureBox();
        var lblFooter = new Label();

        this.SuspendLayout();

        // 
        // pictureBox
        // 
        pictureBox.Dock = DockStyle.Fill;
        pictureBox.Image = Image.FromFile("resources/slogan.jpg");
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Name = "pictureBox";
        pictureBox.TabIndex = 1;
        pictureBox.TabStop = false;

        // 
        // lblFooter
        // 
        lblFooter.Dock = DockStyle.Bottom;
        lblFooter.Font = new Font("Segoe UI", 10F);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(800, 30);
        lblFooter.Text = "Pedro Zeferino da Silva";
        lblFooter.TextAlign = ContentAlignment.MiddleCenter;
        lblFooter.TabIndex = 0;

        // 
        // SplashScreen
        // 
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(pictureBox);
        this.Controls.Add(lblFooter);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = "SplashScreen";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "SplashScreen";
        this.Load += new EventHandler(this.SplashScreen_Load);
        this.ResumeLayout(false);

        // 
        // timer
        // 
        this.timer.Interval = 3000;
        this.timer.Tick += new EventHandler(this.timer_Tick);
    }

    private void SplashScreen_Load(object? sender, EventArgs e)
    {
        timer.Start();
    }

    private void timer_Tick(object? sender, EventArgs e)
    {
        timer.Stop();
        this.Close();
    }
}
