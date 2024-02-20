namespace DLM.Arrays.UI
{
    public partial class frmArrays : Form
    {
        //Class level 1-D array
        //double[] dblGPAs = { 3.45, 4.0, 3.75, 3.66, 3.65, 2.8 };

        const int NUMBER_OF_GPAS = 500;
        double[] dblGPAs = new double[NUMBER_OF_GPAS];

        string[] strNames;
        DateTime[] dates;
        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnCreate1DArray_Click(object sender, EventArgs e)
        {
            double dblScore1;
            const int NUMBEROFELEMENTS = 6;

            //Declare the Array
            double[] dblScores = new double[NUMBEROFELEMENTS];

            //Set the Values
            dblScores[0] = 85;
            dblScores[1] = 90;
            dblScores[2] = 95;
            dblScores[4] = 88.7;
            dblScores[3] = 75;
            dblScores[5] = 44.5;

            //Display the values
            lbxInfo.Items.Add(dblScores[0].ToString());
            lbxInfo.Items.Add(dblScores[1].ToString());
            lbxInfo.Items.Add(dblScores[2].ToString());
            lbxInfo.Items.Add(dblScores[3].ToString());
            lbxInfo.Items.Add(dblScores[4].ToString());
            lbxInfo.Items.Add(dblScores[5].ToString());

        }

        private void DisplayContents(double[] data)
        {
            lbxInfo.Items.Clear();
            for (int index = 0; index < data.Length; index++)
            {
                //lbxInfo.Items.Add(index+1 + ") " + data[index].ToString("n2"));
                lbxInfo.Items.Add(string.Format("{0}) {1:n2}", index + 1, data[index]));
            }

            double dblMax = data.Max();
            double dblMin = data.Min();
            double dblAverage = data.Average();

            lbxInfo.Items.Add(string.Format("Max: {0:n2}", dblMax));
            lbxInfo.Items.Add(string.Format("Min: {0:n2}", dblMin));
            lbxInfo.Items.Add(string.Format("Average: {0:n2}", dblAverage));
        }

        private void DisplayContents(string[] data)
        {
            lbxInfo.Items.Clear();
            for (int index = 0; index < data.Length; index++)
            {
                lbxInfo.Items.Add(string.Format("{0}) {1}", index + 1, data[index]));
            }

        }

        private void DisplayContents(DateTime[] data)
        {
            lbxInfo.Items.Clear();
            for (int index = 0; index < data.Length; index++)
            {
                lbxInfo.Items.Add(string.Format("{0}) {1}", index + 1, data[index].ToShortDateString()));
            }

        }

        private void btnGPAs_Click(object sender, EventArgs e)
        {
            Random generator = new Random();

            for (int index = 0; index < dblGPAs.Length; index++)
            {
                double dblGPA = generator.NextDouble() * 4;
                dblGPAs[index] = dblGPA;
                lbxInfo.Items.Add(dblGPAs[index].ToString());
            }

            DisplayContents(dblGPAs);

        }
        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                int[] ages = new int[3];
                ages[0] = 33;
                ages[1] = 44;
                ages[2] = 55;

                lbxInfo.Items.Add(ages[0]);
                lbxInfo.Items.Add(ages[1]);
                lbxInfo.Items.Add(ages[2]);
                lbxInfo.Items.Add(ages[3]);

            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnDisplayNames_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                // Make space the array for some names
                int.TryParse(txtInfo.Text, out int numberOfNames);

                if (numberOfNames == 0)
                    throw new Exception("Please type in the number of names");

                strNames = new string[numberOfNames];

                Random generator = new Random();

                for (int index = 0; index < numberOfNames; index++)
                {
                    int letter1 = generator.Next(65, 91);
                    int letter2 = generator.Next(97, 123);
                    int letter3 = generator.Next(97, 123);
                    int letter4 = generator.Next(97, 123);

                    strNames[index] = ((char)letter1).ToString() +
                        ((char)letter2).ToString() +
                        ((char)letter3).ToString() +
                        ((char)letter4).ToString();
                }

                DisplayContents(strNames);
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnDisplayDates_Click(object sender, EventArgs e)
        {
            dates = new DateTime[25];
            int day;
            int month;
            int year;

            try
            {
                Random generator = new Random();
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                for (int index = 0; index < dates.GetUpperBound(0) + 1; index++)
                {
                    day = generator.Next(1, 32);
                    month = generator.Next(1, 13);
                    year = generator.Next(1950, DateTime.Now.Year);

                    //if its going to be a bad date, regenerate a new day
                    while (DateTime.DaysInMonth(year, month) < day)
                    {
                        day = generator.Next(1, 32);
                    }

                    DateTime newDate = new DateTime(year, month, day);
                    dates[index] = newDate;
                }

                DisplayContents(dates);
            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }
        private void frmArrays_Load(object sender, EventArgs e)
        {

        }
        private void btnSortNames_Click(object sender, EventArgs e)
        {
            Array.Sort(strNames);
            DisplayContents(strNames);
        }

        private void btnSortByNameDesc_Click(object sender, EventArgs e)
        {
            Array.Sort(strNames);
            Array.Reverse(strNames);
            DisplayContents(strNames);
        }

        private void btnSortGPAs_Click(object sender, EventArgs e)
        {
            Array.Sort(dblGPAs);
            DisplayContents(dblGPAs);
        }

        private void btnSortDates_Click(object sender, EventArgs e)
        {
            Array.Sort(dates);
            DisplayContents(dates);
        }
    }
}
