namespace DLM.Arrays.UI
{
    public partial class frmArrays : Form
    {
        //Class level 1-D array
        //double[] dblGPAs = { 3.45, 4.0, 3.75, 3.66, 3.65, 2.8 };

        const int NUMBER_OF_GPAS = 500;
        double[] dblGPAs = new double[NUMBER_OF_GPAS];
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


    }
}
