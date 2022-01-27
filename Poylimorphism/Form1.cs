namespace Poylimorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1Params_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValue(12);
            string messagesText = teacher.getValues();
            if(messagesText != null)
            {
                textBox1.Text = messagesText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValue(12, "Zouhair ETTARAK") ;
            string messagesText = teacher.getValues();
            if (messagesText != null)
            {
                textBox1.Text = messagesText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValue(12, "Zouhair ETTARAK", 12500);
            string messagesText = teacher.getValues();
            if (messagesText != null)
            {
                textBox1.Text = messagesText;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValue(12, "Zouhair ETTARAK", 5110, "Developper") ;
            string messagesText = teacher.getValues();
            if (messagesText != null)
            {
                textBox1.Text = messagesText;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee2 employee2 = new Employee2();
            string messageText = employee2.setValues(1, "Virtual Method setValue", 2517);
            textBox1.Text  = messageText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teacher2 teacher = new Teacher2();
            string messageText = teacher.setValues(2, "ovveride method SetValue", 5000);
            textBox1.Text = messageText;
        }
    }
}