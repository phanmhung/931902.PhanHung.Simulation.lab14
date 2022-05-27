using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab18
{
    public partial class Form1 : Form
    {
        Modell m = new Modell();
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                m.InitialData((double)lamda.Value, (double)mu.Value, (int)num.Value);
                timer1.Start();
            }
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            m.Statistics();
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            foreach (int i in m.Freq.Keys)
            {
                chart1.Series[0].Points.AddXY(i, m.Freq[i]);
            }
            foreach (int i in m.T.Keys)
            {
                chart2.Series[0].Points.AddXY(i, m.T[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double[] XY = m.Model();
            txQueue.Text = "There are " + XY[1] + " peopel in queue";
            if (XY[0] == 5)
            {
                txOperator.Text = "All operators are busy";
            }
            else
            {
                txOperator.Text =XY[0] + " operators are free";
            }
        }
    }
    class Customer
    {
        public double lambda;
        Random rnd = new Random();

        public Customer(double l)
        {
            lambda = l;
        }

        public double NextCustomer()
        {
            double A = rnd.NextDouble();
            return (-Math.Log(A) / lambda);
        }
    }
    class Modell
    {
        public double time = 0;
        double t;
        double d;
        Customer C;
        AgentOperator O;
        AgentQueue Q;
        public Dictionary<int, double> T;
        public Dictionary<int, double> Freq;
        Random rnd = new Random();

        public void InitialData(double l, double mu, int N)
        {
            C = new Customer(l);
            O = new AgentOperator(mu, N);
            Q = new AgentQueue();
        }

        public double[] Model()
        {
            t = C.NextCustomer();
            d = O.NextEvent();
            if (t < d)
            {
                O.NewCustomer(Q);
                time += t;
            }
            else
            {
                Q.QueueService(O);
                time += d;
            }
            double[] XY = new double[2] { O.x, Q.y };
            return XY;
        }

        public void Statistics()
        {
            Statistic statistic = new Statistic(C, Q, O);
            Freq = statistic.EmpiricalProbability(this, Q, O);
            T = statistic.Theory();
        }
    }
    class AgentOperator
    {
        public int x = 0;
        public double Mu;
        public int N;
        Random rnd = new Random();

        public AgentOperator(double mu, int n)
        {
            Mu = mu;
            N = n;
        }

        private double ExpRV(double parameter)
        {
            double A = rnd.NextDouble();
            return (-Math.Log(A) / parameter);
        }

        public double NextEvent()
        {
            if (x > 0)
            {
                return ExpRV(Mu * x);
            }
            else
            {
                return Double.PositiveInfinity;
            }
        }

        public void NewCustomer(AgentQueue Q)
        {
            if (x < N)
            {
                x++;
            }
            else
            {
                Q.y++;
            }
        }
    }
    class AgentQueue
    {
        public int y = 0;
        public void QueueService(AgentOperator O)
        {
            if (y == 0)
            {
                O.x -= 1;
            }
            else
            {
                y -= 1;
            }
        }
    }
    class Statistic
    {
        double Rho;
        int NumberOfOperators;
        double ISD;
        int N = 100;
        int k = 0;

        Dictionary<int, double> Freq = new Dictionary<int, double>();
        Dictionary<int, double> T;

        public Statistic(Customer C, AgentQueue Q, AgentOperator O)
        {
            Rho = C.lambda / O.Mu;
            NumberOfOperators = O.N;
            double temp = 0;
            for (int i = 0; i < NumberOfOperators; i++)
            {
                temp += Math.Pow(Rho, i) / Factorial(i);
            }
            double temp1 = Math.Pow(Rho, (NumberOfOperators + 1)) / Factorial(NumberOfOperators) * (NumberOfOperators - Rho);
            ISD = Math.Pow((temp + temp1), -1);
        }

        public Dictionary<int, double> EmpiricalProbability(Modell S, AgentQueue Q, AgentOperator O)
        {
            double t = S.time;
            while (k < N)
            {
                S.time = 0; Q.y = 0; O.x = 0;
                while (S.time < t)
                {
                    S.Model();
                }
                k++;
                try
                {
                    Freq.Add(O.x + Q.y, 0);
                }
                catch
                {
                    Console.WriteLine("Элемент уже существует");
                }
                finally
                {
                    Console.WriteLine("Исключение обработано");
                }
                Freq[O.x + Q.y]++;

            }
            foreach (int i in Freq.Keys.ToList())
            {
                Freq[i] /= N;
            }
            return Freq;
        }

        public Dictionary<int, double> Theory()
        {
            T = Freq;
            foreach (int i in T.Keys.ToList())
            {
                if (i < NumberOfOperators)
                {
                    T[i] = (Math.Pow(Rho, i) / Factorial(i)) * ISD;
                }
                else
                {
                    T[i] = (Math.Pow(Rho, i) / (Factorial(i) * Math.Pow(NumberOfOperators, i - NumberOfOperators))) * ISD;
                }
            }
            return T;
        }

        private int Factorial(int i)
        {
            int temp = 1;
            for (int j = 1; j <= i; j++)
            {
                temp *= j;
            }
            return temp;
        }
    }
}
