using System.Security.Policy;
using System.Text;

namespace PizzaGUI
{
    public partial class Form1 : Form
    {
        static List<Pizza> pizzas = new List<Pizza>();
        static int counter = 1;
        static int reszoszzeg = 0;
        static int szallitasidij = 690;
        static int index = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            checkBox1.CheckedChanged += (s, e) => Szures();
            checkBox2.CheckedChanged += (s, e) => Szures();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            kosar.Click += Kosar_Click;
            rendeles.Click += Rendeles_Click;
        }

        private void Rendeles_Click(object? sender, EventArgs e)
        {
            
            DialogResult response = MessageBox.Show(
             text: $"Leadja a rendelést? \n Végösszeg: {vegossz.Text}",
             caption: "Rendelés",
             icon: MessageBoxIcon.Question,
             buttons: MessageBoxButtons.YesNo
             );
            if (response == DialogResult.Yes) 
            {
                using(StreamWriter iro = new StreamWriter("../../../forras/rendeles.txt"))
                {
                    iro.WriteLine($"{DateTime.Now};2  x {pizzas[index].Nev}; 1 x Diavola; Összesen: {vegossz.Text} Ft");
                }
                Application.Exit();
            }
        }

        private void Kosar_Click(object? sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            richTextBox1.Text += $"{textBox1.Text} x {pizzas[index].Nev} - {Ar.Text}\n";

            counter = int.Parse(textBox1.Text);
            
            reszoszzeg += pizzas[index].Ar * counter;
            reszossz.Text = reszoszzeg.ToString(); 

            if(reszoszzeg >= 8000)
            {
                kiszallitas.Text = "0 Ft";
                vegossz.Text = reszoszzeg.ToString();
            }
            else
            {
                kiszallitas.Text = "690 Ft";
                vegossz.Text = (reszoszzeg+szallitasidij).ToString();
            }
            
        }

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            Pizzanev.Text = $"{pizzas[index].Nev}";
            Ar.Text = $"{pizzas[index].Ar} Ft";
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Read();
            Write();
            Szures();
        }

        private void Write()
        {
            foreach (var p in pizzas)
            {
                listBox1.Items.Add(p.ToString());
            }
        }
        private void Szures()
        {
            var lista = pizzas.Where(p =>
                (!checkBox1.Checked || p.Vega) &&
                (!checkBox2.Checked || p.Csipos));

            listBox1.Items.Clear();
            foreach (var p in lista)
            {
                listBox1.Items.Add(p);
            }
        }
        private void Read()
        {
            using (StreamReader o = new StreamReader("../../../forras/pizzak.txt"))
            {
                o.ReadLine();
                while (!o.EndOfStream)
                {
                    string line = o.ReadLine();
                    pizzas.Add(new Pizza(line));
                }
            }
        }
    }
}
