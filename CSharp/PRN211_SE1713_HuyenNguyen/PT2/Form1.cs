using Microsoft.Data.SqlClient;
using System.Data;

namespace PT2
{
    public partial class Form1 : Form
    {
        DataProvider dp = new DataProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load into type
            LoadWordType();

            // load into datagrid dictionary
            LoadDictionary();

        }

        private void LoadWordType()
        {
            List<string> data = new List<string>();
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM WordType"))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string typeName = dr.GetString(1).ToString();
                    WordType wordType = new WordType(id, typeName);
                    data.Add(typeName);
                }

                cbType.DataSource = data;
            }
        }

        private void LoadDictionary()
        {
            List<MyDictionary> data = new List<MyDictionary>();
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM Dictionary d JOIN WordType w ON d.ID = w.ID"))
            {
                //wordid, word, editdate, meaning, id, id, typename
                while (dr.Read())
                {
                    string wordId = dr.GetInt32(0).ToString();
                    string word = dr.GetString(1);
                    string editDate = dr.GetDateTime(2).ToString();
                    string meaning = dr.GetString(3);
                    string wtId = dr.GetInt32(4).ToString();
                    string typeName = dr.GetString(6);
                    WordType wt = new WordType(wtId, typeName);
                    MyDictionary d = new MyDictionary(wordId, word, editDate, meaning, typeName);
                    data.Add(d);

                }
                dgDictionary.DataSource = data;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgDictionary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtWord.Text = dgDictionary.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtMeaning.Text = dgDictionary.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cbType.Text = dgDictionary.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        private void lblMeaning_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Dictionary d JOIN WordType w ON d.ID = w.ID WHERE w.TypeName = @typeName ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@typeName", cbType.Text),
                new SqlParameter("@word", txtWord.Text),
                new SqlParameter("@meaning", txtMeaning.Text)
            };
            if (txtMeaning.Text.Length > 0)
            {
                searchQuery += " AND d.Meaning = @meaning";
            }
            if (txtWord.Text.Length > 0)
            {
                searchQuery += " AND d.Word = @word";
            }
            List<MyDictionary> list = new List<MyDictionary>();
            using (IDataReader dr = dp.executeQuery2(searchQuery, parameters))
            {
                while (dr.Read())
                {
                    string wordId = dr.GetInt32(0).ToString();
                    string word = dr.GetString(1);
                    string editDate = dr.GetDateTime(2).ToString();
                    string meaning = dr.GetString(3);
                    string wtId = dr.GetInt32(4).ToString();
                    string typeName = dr.GetString(6);
                    WordType wt = new WordType(wtId, typeName);
                    MyDictionary d = new MyDictionary(wordId, word, editDate, meaning, typeName);
                    list.Add(d);

                }
                setDgSource(list);
            }

        }

        private void setDgSource(List<MyDictionary> myDictionaries)
        {
            dgDictionary.DataSource = myDictionaries;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDictionary();
        }
    }
}