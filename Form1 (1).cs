namespace Prog122b {
    public partial class Form1 : Form {
        public Form1()
            { InitializeComponent(); }
        private void button2_Click(object sender, EventArgs e) {
            for (int lcv = 0; lcv <= 40; lcv++) {
                listBox1.Items.Add(lcv + "\t\t" + lcv * 4);
            }
        }
        private void button1_Click(object sender, EventArgs e) { listBox1.Items.Clear(); }
        private void button3_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
