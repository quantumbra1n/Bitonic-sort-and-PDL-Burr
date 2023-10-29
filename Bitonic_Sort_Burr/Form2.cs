using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace BitonicSortBurr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            tabControlProgram.Visible = false;
            tabControlProgram.Enabled = false;
            tabControlProgram.Location = new Point(5, 5);
            panel_autorization.Location = new Point(75, 86);

            Color DARK_BLUE = Color.FromArgb(0, 34, 51);
            Color BRIGHT_BLUE = Color.FromArgb(61, 195, 241);
            BackColor = DARK_BLUE;
            ForeColor = BRIGHT_BLUE;

            tabPageSort.BackColor = DARK_BLUE;
            tabPageEvaluation.BackColor = DARK_BLUE;

            textBoxName.BackColor = DARK_BLUE;
            textBoxRegName.BackColor = DARK_BLUE;
            textBoxPassword.BackColor = DARK_BLUE;
            textBoxRegPass.BackColor = DARK_BLUE;
            textBoxRegTooPass.BackColor = DARK_BLUE;
            textBox_n.BackColor = DARK_BLUE;
            textBox_A.BackColor = DARK_BLUE;
            textBox_B.BackColor = DARK_BLUE;
            textBox_C.BackColor = DARK_BLUE;
            textBox_D.BackColor = DARK_BLUE;
            textBox_t.BackColor = DARK_BLUE;
            textBox_cr.BackColor = DARK_BLUE;
            textBox_perm.BackColor = DARK_BLUE;
            textBox_v.BackColor = DARK_BLUE;
            textBox_m.BackColor = DARK_BLUE;
            textBox1_xi.BackColor = DARK_BLUE;
            textBox_yi.BackColor = DARK_BLUE;
            textBox2_xi.BackColor = DARK_BLUE;
            textBox_xi2.BackColor = DARK_BLUE;
            textBox_xy.BackColor = DARK_BLUE;
            textBox1_a0.BackColor = DARK_BLUE;
            textBox1_a1.BackColor = DARK_BLUE;
            textBox2_a0.BackColor = DARK_BLUE;
            textBox2_a1.BackColor = DARK_BLUE;
            textBox_sigma2x.BackColor = DARK_BLUE;
            textBox_epsilon.BackColor = DARK_BLUE;
            textBox_r.BackColor = DARK_BLUE;
            textBox_R2.BackColor = DARK_BLUE;
            textBox_elasticity.BackColor = DARK_BLUE;
            textBox_beta.BackColor = DARK_BLUE;

            checkBoxShowPass.BackColor = DARK_BLUE;
            checkBox2ShowPass.BackColor = DARK_BLUE;

            numericUpDown1.BackColor = DARK_BLUE;

            dataGridView1.BackgroundColor = DARK_BLUE;
            dataGridViewSource.BackgroundColor = DARK_BLUE;
            dataGridViewSorted.BackgroundColor = DARK_BLUE;
            dataGridViewSample.BackgroundColor = DARK_BLUE;

            dataGridView1.Columns[0].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = BRIGHT_BLUE;

            dataGridViewSource.Columns["ColumnSourceNumber"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSource.Columns["ColumnSourceNumber"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridViewSource.Columns["ColumnSourceElement"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSource.Columns["ColumnSourceElement"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;

            dataGridViewSorted.Columns["ColumnSortedNumber"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSorted.Columns["ColumnSortedNumber"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridViewSorted.Columns["ColumnSortedElement"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSorted.Columns["ColumnSortedElement"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;

            dataGridViewSample.Columns["ColumnSampleNumber"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSample.Columns["ColumnSampleNumber"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridViewSample.Columns["ColumnSampleTime"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSample.Columns["ColumnSampleTime"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridViewSample.Columns["ColumnSampleArraySize"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSample.Columns["ColumnSampleArraySize"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridViewSample.Columns["ColumnSampleX2"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSample.Columns["ColumnSampleX2"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;
            dataGridViewSample.Columns["ColumnSampleXY"].DefaultCellStyle.BackColor = DARK_BLUE;
            dataGridViewSample.Columns["ColumnSampleXY"].DefaultCellStyle.ForeColor = BRIGHT_BLUE;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = DARK_BLUE;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = BRIGHT_BLUE;
            dataGridViewSource.ColumnHeadersDefaultCellStyle.ForeColor = DARK_BLUE;
            dataGridViewSource.ColumnHeadersDefaultCellStyle.BackColor= BRIGHT_BLUE;
            dataGridViewSorted.ColumnHeadersDefaultCellStyle.ForeColor = DARK_BLUE;
            dataGridViewSorted.ColumnHeadersDefaultCellStyle.BackColor = BRIGHT_BLUE;
            dataGridViewSample.ColumnHeadersDefaultCellStyle.ForeColor = DARK_BLUE;
            dataGridViewSample.ColumnHeadersDefaultCellStyle.BackColor = BRIGHT_BLUE;

            dataGridView1.GridColor = BRIGHT_BLUE;
            dataGridViewSource.GridColor = BRIGHT_BLUE;
            dataGridViewSorted.GridColor = BRIGHT_BLUE;
            dataGridViewSample.GridColor = BRIGHT_BLUE;

            numericUpDown1.ForeColor = BRIGHT_BLUE;

            textBoxName.ForeColor = BRIGHT_BLUE;
            textBoxRegName.ForeColor = BRIGHT_BLUE;
            textBoxPassword.ForeColor = BRIGHT_BLUE;
            textBoxRegPass.ForeColor = BRIGHT_BLUE;
            textBoxRegTooPass.ForeColor = BRIGHT_BLUE;
            textBox_n.ForeColor = BRIGHT_BLUE;
            textBox_A.ForeColor = BRIGHT_BLUE;
            textBox_B.ForeColor = BRIGHT_BLUE;
            textBox_C.ForeColor = BRIGHT_BLUE;
            textBox_D.ForeColor = BRIGHT_BLUE;
            textBox_t.ForeColor = BRIGHT_BLUE;
            textBox_cr.ForeColor = BRIGHT_BLUE;
            textBox_perm.ForeColor = BRIGHT_BLUE;
            textBox_v.ForeColor = BRIGHT_BLUE;
            textBox_m.ForeColor = BRIGHT_BLUE;
            textBox1_xi.ForeColor = BRIGHT_BLUE;
            textBox_yi.ForeColor = BRIGHT_BLUE;
            textBox2_xi.ForeColor = BRIGHT_BLUE;
            textBox_xi2.ForeColor = BRIGHT_BLUE;
            textBox_xy.ForeColor = BRIGHT_BLUE;
            textBox1_a0.ForeColor = BRIGHT_BLUE;
            textBox1_a1.ForeColor = BRIGHT_BLUE;
            textBox2_a0.ForeColor = BRIGHT_BLUE;
            textBox2_a1.ForeColor = BRIGHT_BLUE;
            textBox_sigma2x.ForeColor = BRIGHT_BLUE;
            textBox_epsilon.ForeColor = BRIGHT_BLUE;
            textBox_r.ForeColor = BRIGHT_BLUE;
            textBox_R2.ForeColor = BRIGHT_BLUE;
            textBox_elasticity.ForeColor = BRIGHT_BLUE;
            textBox_beta.ForeColor = BRIGHT_BLUE;

            groupBox1.ForeColor = BRIGHT_BLUE;
            groupBox2.ForeColor = BRIGHT_BLUE;
            groupBox3.ForeColor = BRIGHT_BLUE;
            groupBox4.ForeColor = BRIGHT_BLUE;
            groupBox5.ForeColor = BRIGHT_BLUE;

            button_log_in.BackColor = BRIGHT_BLUE;
            button_go_register.BackColor = BRIGHT_BLUE;
            button_register.BackColor = BRIGHT_BLUE;
            button_go_back_log_in.BackColor= BRIGHT_BLUE;
            button_sort.BackColor = BRIGHT_BLUE;
            button_calculation.BackColor = BRIGHT_BLUE;
            button_clear.BackColor = BRIGHT_BLUE;
            button_clear2.BackColor = BRIGHT_BLUE;
            button_admin.BackColor = BRIGHT_BLUE;
            button_exit1.BackColor = BRIGHT_BLUE;
            button_exit2.BackColor = BRIGHT_BLUE;
            button_exit3.BackColor = BRIGHT_BLUE;
            button_exit4.BackColor = BRIGHT_BLUE;

            button_log_in.ForeColor = DARK_BLUE;
            button_go_register.ForeColor = DARK_BLUE;
            button_register.ForeColor= DARK_BLUE;
            button_go_back_log_in.ForeColor= DARK_BLUE;
            button_sort.ForeColor = DARK_BLUE;
            button_calculation.ForeColor = DARK_BLUE;
            button_clear.ForeColor = DARK_BLUE;
            button_clear2.ForeColor = DARK_BLUE;
            button_admin.ForeColor = DARK_BLUE;
            button_exit1.ForeColor = DARK_BLUE;
            button_exit2.ForeColor = DARK_BLUE;
            button_exit3.ForeColor = DARK_BLUE;
            button_exit4.ForeColor = DARK_BLUE;

            chart1.BackColor = DARK_BLUE;
            chart1.Series[0].Color = BRIGHT_BLUE;
            chart1.ChartAreas[0].BackColor = DARK_BLUE;
            chart1.ChartAreas[0].BorderColor = Color.White;
            chart1.ChartAreas[0].Axes[0].LineColor = Color.White;
            chart1.ChartAreas[0].Axes[1].LineColor = Color.White;
            chart1.ChartAreas[0].Axes[2].LineColor = Color.White;
            chart1.ChartAreas[0].Axes[3].LineColor = Color.White;
            chart1.ChartAreas[0].Axes[0].LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].Axes[1].LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].Axes[2].LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].Axes[3].LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].Axes[2].MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].Axes[3].MajorGrid.LineColor = Color.White;
        }
        // Функция записи имени, пароля и текущего времени в лог-файл и в таблицу
        public void in_log_file(string name, string password, string datetime)
        {
            string path = "logfile.log"; // Путь к лог-файлу

            // Добавляем имя, пароль и время в лог-файл
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                sw.WriteLine(name); // Запись имени
                sw.WriteLine(password); // Запись пароля
                sw.WriteLine(datetime);
                sw.WriteLine("");
                sw.Close();
            }
            dataGridView1.Rows.Add(name, password, datetime);
            dataGridView1.ClearSelection();
        }

        // Функция вывода данных лог-файла в таблицу
        public void out_log_file()
        {
            string path = "logfile.log"; // Путь к лог-файлу

            // Построчно читаем файл
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string password = sr.ReadLine();
                        string datetime = sr.ReadLine();
                        dataGridView1.Rows.Add(line, password, datetime); // Добавляем логи в таблицу
                    }
                }
            }
            dataGridView1.ClearSelection();
        }
        private void button_log_in_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                if (!string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    if (textBoxPassword.Text.Length >= 8)
                    {
                        // Добавляем в лог-файл имя, пароль и текущее время
                        in_log_file(textBoxName.Text.ToString(), textBoxPassword.Text.ToString(), DateTime.Now.ToString());
                        string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBase.mdb"; // Строка соединения
                        OleDbConnection oleDbConnection = new OleDbConnection(connectionString); // Создаем соединение

                        // Выполняем запрос к базе данных
                        oleDbConnection.Open(); // Открываем соединение
                        string query = "SELECT * FROM reg_users"; // Строка запроса
                        OleDbCommand dbCommand = new OleDbCommand(query, oleDbConnection);
                        OleDbDataReader Reader = dbCommand.ExecuteReader(); // Считываем данные

                        bool log_in = false;

                        // Определяем пользователя в базе данных
                        if (Reader.HasRows == true) // Проверка на наличие таблицы
                        {
                            while (Reader.Read())
                            {
                                if (textBoxName.Text == Reader["user"].ToString())
                                {
                                    if (textBoxPassword.Text == Reader["password"].ToString())
                                    {
                                        log_in = true; // Пользователь есть в базе данных
                                        panel_autorization.Visible = false;
                                        panel_autorization.Enabled = false;
                                        panel_autorization.Location = new Point(755, 573);
                                        tabControlProgram.Enabled = true;
                                        tabControlProgram.Visible = true;
                                        textBox_n.Focus();
                                        Reader.Close();
                                        break;
                                    }
                                }
                            }
                            if (!log_in) // Если пользователя нет в базе данных
                            {
                                errorProvider1.SetError(textBoxName, "Неверное имя");
                                errorProvider1.SetError(textBoxPassword, "Неверный пароль");
                                MessageBox.Show("Ошибка аутентификации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Reader.Close();
                            }
                        }
                        else MessageBox.Show("Не удалось подключиться к таблице", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); Reader.Close();
                    }
                    else errorProvider1.SetError(textBoxPassword, "Пароль должен содержать минимум 8 символов");
                }
                else
                {
                    errorProvider1.SetError(textBoxPassword, "Заполните данные");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                    errorProvider1.SetError(textBoxPassword, "Заполните данные");
                errorProvider1.SetError(textBoxName, "Заполните данные");
            }
        }

        private void button_go_register_Click(object sender, EventArgs e)
        {
            panel_registration.Enabled = true;
            panel_autorization.Enabled = false;
            panel_autorization.Visible = false;
            panel_registration.Visible = true;
            panel_registration.Location = new Point(75, 86);
            textBoxRegName.Focus();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRegName.Text))
            {
                if (!string.IsNullOrEmpty(textBoxRegPass.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxRegTooPass.Text))
                    {
                        if (textBoxRegPass.Text.Length >= 8 && textBoxRegTooPass.Text.Length >= 8)
                        {
                            if (textBoxRegTooPass.Text == textBoxRegPass.Text)
                            {
                                // Создание соединения
                                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBase.mdb"; // Строка соединения
                                OleDbConnection oleDbConnection = new OleDbConnection(connectionString); // Создаем соединение

                                // Выполняем запрос к БД
                                oleDbConnection.Open(); // Открывает соединение
                                string query = "SELECT * FROM reg_users"; // Строка запроса
                                OleDbCommand dbCommand = new OleDbCommand(query, oleDbConnection); // Команда
                                OleDbDataReader Reader = dbCommand.ExecuteReader(); // Считываем данные

                                bool login_exist = false;
                                if (Reader.HasRows == true)
                                {
                                    while (Reader.Read())
                                    {
                                        // Если введенный пользователь уже существует в БД
                                        if (Reader["user"].ToString() == textBoxRegName.Text) 
                                        {
                                            login_exist = true;
                                            Reader.Close();
                                            break;
                                        }
                                    }

                                    if (!login_exist)
                                    {
                                        // Добавляем зарегистрированного пользователя в лог-файл
                                        string log = textBoxRegName.Text.ToString();
                                        string pass = textBoxRegPass.Text.ToString();
                                        DateTime now = DateTime.Now;
                                        in_log_file(log, pass, now.ToString());

                                        // Добавляем зарегистрированного пользователя в БД
                                        string queryReg = "INSERT INTO reg_users VALUES ('" + log + "', '" + pass + "', '" + now.ToString("dd.MM.yyyy") + "')";
                                        OleDbCommand cmd = new OleDbCommand(queryReg, oleDbConnection);

                                        if (cmd.ExecuteNonQuery() == 0)
                                            MessageBox.Show("Ошибка регистрации", "Ошибка");
                                        else
                                        {
                                            MessageBox.Show("Регистрация прошла успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            panel_registration.Visible = false;
                                            panel_registration.Enabled = false;
                                            tabControlProgram.Enabled = true;
                                            tabControlProgram.Visible = true;
                                            textBox_n.Focus();
                                        }
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(textBoxRegName, "Ведите другое имя");
                                        MessageBox.Show("Такой пользователь уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(textBoxRegTooPass, "Неверный пароль");
                                errorProvider1.SetError(textBoxRegPass, "Неверный пароль");
                                MessageBox.Show("Неверный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(textBoxRegTooPass, "Пароль должен содержать минимум 8 символов");
                            errorProvider1.SetError(textBoxRegPass, "Пароль должен содержать минимум 8 символов");
                        }
                    }
                    else
                        errorProvider1.SetError(textBoxRegTooPass, "Заполните данные"); 
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxRegTooPass.Text))
                        errorProvider1.SetError(textBoxRegTooPass, "Заполните данные");
                    errorProvider1.SetError(textBoxRegPass, "Заполните данные");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxRegPass.Text))
                    errorProvider1.SetError(textBoxRegPass, "Заполните данные");
                if (string.IsNullOrEmpty(textBoxRegTooPass.Text))
                    errorProvider1.SetError(textBoxRegTooPass, "Заполните данные");
                errorProvider1.SetError(textBoxRegName, "Заполните данные");
            }
        }

        private void button_go_back_log_in_Click(object sender, EventArgs e)
        {
            panel_registration.Visible = false;
            panel_registration.Enabled = false;
            panel_autorization.Enabled = true;
            panel_autorization.Visible = true;
            panel_autorization.Location = new Point(75, 86);
            textBoxName.Focus();
        }

        // Датчик случайных чисел
        public double get_Burr(double A, double B, double C, double D)
        {
            double root, u;
            Random rand = new Random();
            int num = rand.Next();
            u = (double)num / 32767 + 1; // RAND_MAX = 32767
            root = A + B * Math.Pow((Math.Pow(u, -1 / D + 1) - 1), -1 / C);
            return root;
        }
        // Bitonic sort
        // Сравнивает и меняет местами элементы
        static void compare_and_swap(double[] array, int i, int j, int direction, ref UInt64 c, ref UInt64 m)
        {
            ++c; // Счетчик сравнений
            int k = array[i] > array[j] ? 1 : 0;

            // Если порядок элементов не соответствует направлению сортировки
            if (direction == k)
            {
                // Меняем местами элементы
                double tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
                ++m; // Счетчик перестановок
            }
        }

        /*Рекурсивно сортирует битонную последовательность
           direction = 1, если в порядке возрастания или 0, если в порядке убывания
           Сортируемая последовательность начинается с индекса start
           count - количество сортируемых элементов*/
        static void bitonic_merge(double[] array, int start, int count, int direction, ref UInt64 c, ref UInt64 m)
        {
            if (count > 1)
            {
                int k = count / 2;
                for (int i = start; i < start + k; i++)
                {
                    compare_and_swap(array, i, i + k, direction, ref c, ref m);
                }
                bitonic_merge(array, start, k, direction, ref c, ref m);
                bitonic_merge(array, start + k, k, direction, ref c, ref m);
            }
        }

        /*Эта функция сначала создает битонную последовательность путем рекурсивной
        сортировки ее двух половин в противоположных направлениях сортировки (левая половина возрастает, правая убывает), а затем
        вызывает bitonic_merge, чтобы переставить их направлении возрастания*/
        static void bitonic_sort(double[] array, int start, int count, int direction, ref UInt64 c, ref UInt64 m)
        {
            if (count > 1)
            {
                int k = count / 2;

                // Сортируем левую часть в порядке возрастания
                bitonic_sort(array, start, k, 1, ref c, ref m);

                // Сортируем правую часть в порядке убывания
                bitonic_sort(array, start + k, k, 0, ref c, ref m);

                // Объединяем в последовательность и сортируем в порядке возрастания
                bitonic_merge(array, start, count, direction, ref c, ref m);
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_n.Text) ||
                string.IsNullOrEmpty(textBox_A.Text) ||
                string.IsNullOrEmpty(textBox_B.Text) ||
                string.IsNullOrEmpty(textBox_C.Text) ||
                string.IsNullOrEmpty(textBox_D.Text))
            {
                MessageBox.Show("Не все данные заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n, dir = 1;
                double A, B, C, D;
                UInt64 c = 0, m = 0;
                n = Convert.ToInt32(textBox_n.Text);
                A = Convert.ToDouble(textBox_A.Text);
                B = Convert.ToDouble(textBox_B.Text);
                C = Convert.ToDouble(textBox_C.Text);
                D = Convert.ToDouble(textBox_D.Text);

                if (D <= 100)
                {
                    if (A > 0)
                    {
                        if (B > 0)
                        {
                            if (C > 0)
                            {
                                double[] Array = new double[n];

                                dataGridViewSource.Rows.Clear();
                                dataGridViewSorted.Rows.Clear();

                                // Заполняем исходный массив случайными числами по вероятностному закону распределения Burr
                                for (int i = 0; i < n; ++i)
                                {
                                    Array[i] = get_Burr(A, B, C, D);
                                    dataGridViewSource.Rows.Add(i, Array[i]);
                                }
                                dataGridViewSource.ClearSelection();
                                Stopwatch stopWatch = new Stopwatch();
                                stopWatch.Start();
                                bitonic_sort(Array, 0, n, dir, ref c, ref m); // Сортируем массив
                                stopWatch.Stop();
                                TimeSpan t = stopWatch.Elapsed;
                                textBox_t.Text = t.Milliseconds.ToString("n");

                                // Выводим упорядоченный массив в таблицу
                                for (int i = 0; i < n; ++i)
                                {
                                    dataGridViewSorted.Rows.Add(i, Array[i]);
                                }
                                dataGridViewSorted.ClearSelection();

                                textBox_cr.Text = Convert.ToString(c);
                                textBox_perm.Text = Convert.ToString(m);
                            }
                            else
                                errorProvider1.SetError(textBox_C, "Значение должно быть больше 0");
                        }
                        else
                        {
                            if (C <= 0)
                                errorProvider1.SetError(textBox_C, "Значение должно быть больше 0");
                            errorProvider1.SetError(textBox_B, "Значение должно быть больше 0");
                        }
                    }
                    else
                    {
                        if (B <= 0)
                            errorProvider1.SetError(textBox_B, "Значение должно быть больше 0");
                        if (C <= 0)
                            errorProvider1.SetError(textBox_C, "Значение должно быть больше 0");
                        errorProvider1.SetError(textBox_A, "Значение должно быть больше 0");
                    }
                }
                else
                {
                    if (A <= 0)
                        errorProvider1.SetError(textBox_A, "Значение должно быть больше 0");
                    if (B <= 0)
                        errorProvider1.SetError(textBox_B, "Значение должно быть больше 0");
                    if (C <= 0)
                        errorProvider1.SetError(textBox_C, "Значение должно быть больше 0");
                    errorProvider1.SetError(textBox_D, "Значение должно быть меньше либо равно 100");
                }
            }
        }
        
        private void button_clear1_Click(object sender, EventArgs e)
        {
            textBox_n.Text = "";
            textBox_A.Text = "";
            textBox_B.Text = "";
            textBox_C.Text = "";
            textBox_D.Text = "";
            textBox_t.Text = "";
            textBox_cr.Text = "";
            textBox_perm.Text = "";
            dataGridViewSource.Rows.Clear();
            dataGridViewSorted.Rows.Clear();
        }

        private void button_calculation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_v.Text))
            {
                MessageBox.Show("Задайте объём выборки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridViewSample.Rows.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                UInt64 c = 0, m = 0, n = 0, sum_xi = 0, sum_yi = 0, sum_yi2 = 0, sum_xi2 = 0, sum_xy = 0, v = Convert.ToUInt64(textBox_v.Text);
                double A, B, C, D, a0, a1, r, R2, elasticity, beta, sigma_x, sigma_y, epsilon, sum_xy_caret = 0, sum_ycareti_yi = 0, sum_yi_linyi = 0, sum_yi_caret = 0, sum_yi2_caret = 0;
                double[] lin_regression_yi = new double[v];
                Random rnd = new Random();

                // Заполнение таблицы
                for (int i = 0; i < (int)v; ++i)
                {
                    n += 3000;
                    double[] Array = new double[n];
                    A = rnd.NextDouble();
                    B = rnd.NextDouble();
                    C = rnd.NextDouble();
                    D = rnd.NextDouble();

                    // Заполняем исходный массив случайными числами по вероятностному закону распределения Burr
                    for (int j = 0; j < (int)n; ++j)
                    {
                        Array[i] = get_Burr(A, B, C, D);
                    }

                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    bitonic_sort(Array, 0, (int)n, 1, ref c, ref m); // Сортируем массив
                    stopWatch.Stop();
                    int t = stopWatch.Elapsed.Milliseconds;

                    // Заполняем строку в таблице
                    dataGridViewSample.Rows.Add(i + 1, n, t, n * n, (int)n*t);

                    chart1.Series[0].Points.AddXY(n, t);
                }
                dataGridViewSample.ClearSelection();
                chart1.Visible = true;
                
                for (int i = 0; i < (int)v; ++i)
                {
                    sum_xi += Convert.ToUInt64(dataGridViewSample[1, i].Value);
                    sum_yi += Convert.ToUInt64(dataGridViewSample[2, i].Value);
                    sum_xi2 += Convert.ToUInt64(dataGridViewSample[3, i].Value);
                    sum_xy += Convert.ToUInt64(dataGridViewSample[4, i].Value);
                    sum_yi2 += Convert.ToUInt64(dataGridViewSample[2, i].Value) * Convert.ToUInt64(dataGridViewSample[2, i].Value);
                }

                textBox_m.Text = textBox_v.Text;
                textBox1_xi.Text = sum_xi.ToString();
                textBox2_xi.Text = sum_xi.ToString();
                textBox_yi.Text = sum_yi.ToString();
                textBox_xi2.Text = sum_xi2.ToString();
                textBox_xy.Text = sum_xy.ToString();

                if (textBox_v.Text == "1")
                {
                    MessageBox.Show("Бесконечное число решений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Вычисления по формулам
                    a1 = ((double)v * (double)sum_xy - (double)sum_yi * (double)sum_xi)
                        / ((double)v * (double)sum_xi2 - Math.Pow((double)sum_xi, 2));

                    a0 = ((double)sum_yi * (double)sum_xi2 - (double)sum_xy * (double)sum_xi)
                        / ((double)v * (double)sum_xi2 - Math.Pow((double)sum_xi, 2));

                    for (int i = 0; i < (int)v; ++i)
                    {
                        lin_regression_yi[i] = a0 + a1 * Convert.ToDouble(dataGridViewSample[1, i].Value);
                        chart1.Series[1].Points.AddXY(Convert.ToDouble(dataGridViewSample[1, i].Value), lin_regression_yi[i]);
                        sum_ycareti_yi += Math.Abs(Convert.ToDouble(dataGridViewSample[2, i].Value) - lin_regression_yi[i]);
                        sum_yi_linyi += Math.Pow(Convert.ToDouble(dataGridViewSample[2, i].Value) - lin_regression_yi[i], 2);
                        sum_yi_caret += lin_regression_yi[i];
                        sum_yi2_caret += Math.Pow(lin_regression_yi[i], 2);
                        sum_xy_caret += lin_regression_yi[i] * Convert.ToDouble(dataGridViewSample[1, i].Value);
                    }

                    r = ((double)v * sum_xy_caret - (double)sum_xi * sum_yi_caret)
                        / (Math.Sqrt(((double)v * (double)sum_xi2 - (double)sum_xi2) * ((double)v * sum_yi2_caret - sum_yi_caret * sum_yi_caret)));

                    R2 = Math.Abs(r * r);
                    elasticity = a1 * ((double)sum_xi / (double)v) / (sum_yi_caret / (double)v);
                    sigma_x = Math.Sqrt(Math.Pow((double)sum_xi - ((double)sum_xi / (double)v), 2) / (double)v);
                    sigma_y = Math.Sqrt(Math.Pow(sum_yi_caret - (sum_yi_caret / (double)v), 2) / (double)v);
                    epsilon = 100 * sum_ycareti_yi / (double)sum_yi;
                    beta = a1 * (sigma_x / sigma_y);
                    if (beta >= 1)
                        beta = 1;

                    textBox1_a0.Text = a0.ToString();
                    textBox2_a0.Text = a0.ToString();
                    textBox1_a1.Text = a1.ToString();
                    textBox2_a1.Text = a1.ToString();
                    textBox_r.Text = r.ToString();
                    textBox_R2.Text = R2.ToString();
                    textBox_elasticity.Text = elasticity.ToString();
                    textBox_beta.Text = beta.ToString();
                    textBox_sigma2x.Text = Convert.ToString(sum_yi_linyi / (double)v);
                    textBox_epsilon.Text = epsilon.ToString();
                }
            }
        }

        private void button_clear2_Click(object sender, EventArgs e)
        {
            textBox_v.Text = "";
            textBox_m.Text = "";
            textBox1_xi.Text = "";
            textBox2_xi.Text = "";
            textBox_yi.Text = "";
            textBox_xi2.Text = "";
            textBox_xy.Text = "";
            textBox1_a0.Text = "";
            textBox2_a0.Text = "";
            textBox1_a1.Text = "";
            textBox2_a1.Text = "";
            textBox_r.Text = "";
            textBox_R2.Text = "";
            textBox_elasticity.Text = "";
            textBox_beta.Text = "";
            textBox_sigma2x.Text = "";
            textBox_epsilon.Text = "";
            dataGridViewSample.Rows.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox_n.Text = Convert.ToString(Math.Pow(2, (int)numericUpDown1.Value));
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, null);
            errorProvider1.SetError(textBoxPassword, null);

            // Выводим логи из файла в таблицу
            dataGridView1.Rows.Clear();
            out_log_file();

            // Добавляем имя, пароль и время в лог-файл
            in_log_file(textBoxName.Text.ToString(), textBoxPassword.Text.ToString(), DateTime.Now.ToString());
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
        }
        private void pictureBoxSortInfo_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBoxCompInfo_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_n.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true; // Запрещено водить 0 первым символом
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Разрешены только Backspace и цифры
            }
        }

        private void textBox_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; // Заменяем точку на запятую
            }
            if (e.KeyChar == ',')
            {
                if (textBox_A.Text.Length == 0)
                {
                    e.Handled = true; // Нельзя поставить запятую первой
                }
                if (textBox_A.Text.IndexOf(',') != -1)
                {
                    e.Handled = true; // Запятая уже стоит
                }
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.') 
            {
                e.Handled = true;
            }
        }

        private void textBox_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; // Заменяем точку на запятую
            }
            if (e.KeyChar == ',')
            {
                if (textBox_B.Text.Length == 0)
                {
                    e.Handled = true; // Нельзя поставить запятую первой
                }
                if (textBox_B.Text.IndexOf(',') != -1)
                {
                    e.Handled = true; // Запятая уже стоит
                }
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.') 
            {
                e.Handled = true;
            }
        }

        private void textBox_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') 
            {
                e.KeyChar = ','; // Заменяем точку на запятую
            }
            if (e.KeyChar == ',')
            {
                if (textBox_C.Text.Length == 0)
                {
                    e.Handled = true; // Нельзя поставить запятую первой
                }
                if (textBox_C.Text.IndexOf(',') != -1)
                {
                    e.Handled = true; // Запятая уже стоит
                }
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.') 
            {
                e.Handled = true;
            }
        }

        private void textBox_D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; // Заменяем точку на запятую
            }
            if (e.KeyChar == ',')
            {
                if (textBox_D.Text.Length == 0)
                {
                    e.Handled = true; // Нельзя поставить запятую первой
                }
                if (textBox_D.Text.IndexOf(',') != -1)
                {
                    e.Handled = true; // Запятая уже стоит
                }
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBox_v_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_v.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true; // Запрещено водить 0 первым символом
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, null);
            if (textBoxName.Text == "admin" && textBoxPassword.Text == "12345678")
                button_admin.Visible = true;
            else
            {
                button_admin.Visible = false;
                dataGridView1.Visible = false;
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPassword, null);
            if (textBoxName.Text == "admin" && textBoxPassword.Text == "12345678") // Права администратора
                button_admin.Visible = true;
            else
            {
                button_admin.Visible = false;
                dataGridView1.Visible = false;
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void textBoxRegName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxRegName, null);
        }

        private void textBoxRegPass_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxRegPass, null);
        }

        private void textBoxRegTooPass_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxRegTooPass, null);
        }

        private void checkBox2ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2ShowPass.Checked)
            {
                textBoxRegPass.UseSystemPasswordChar = false;
                textBoxRegTooPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxRegPass.UseSystemPasswordChar = true;
                textBoxRegTooPass.UseSystemPasswordChar = true;
            }
        }

        private void textBox_D_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_D, null);
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_A, null);
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_B, null);
        }

        private void textBox_C_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_C, null);
        }
    }
}
