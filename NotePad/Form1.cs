namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ���θ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        string filename = "";

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. ����ڿ��� �� ������ �����ϰ� �� 
            this.openFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
            openFileDialog1.ShowDialog();
            

            //1-1 ������ ���ϸ��� ������ ����
            filename = openFileDialog1.FileName;

            //2. ������ ������ �д´�.
            string Data = System.IO.File.ReadAllText(filename);
            //3, ȭ�鿡 ǥ�� �Ѵ�.
            tbContents.Text = Data;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���ϸ��� �ԷµǾ� ������ 
            if (filename != "")
            {
                //1. ����ڿ��� ������ ������ ���� �ϰ� ��
                this.saveFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
                this.saveFileDialog1.ShowDialog();
                
                //2. ������ ���� �Ѵ�.
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                //3. ���ϸ��� ���
                filename = saveFileDialog1.FileName;

            }
            else
            {
                //�ش� ���ϸ����� ���� ������ ����

                //2. ������ ���� �Ѵ�.
                System.IO.File.WriteAllText(filename, tbContents.Text);
            }



        }

        private void �ٸ��̸���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. ����ڿ��� ������ ������ ���� �ϰ� ��
            this.saveFileDialog1.Filter = "�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
            this.saveFileDialog1.ShowDialog();
           
            //2. ������ ���� �Ѵ�.
            System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ���α׷� ����
            Close();
        }

        private void �ڵ��ٹٲ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.WordWrap = !tbContents.WordWrap;

           // if (tbContents.WordWrap == true)
           // {
           //     tbContents.WordWrap = false;
           // }
           // else
           // {
           //     tbContents.WordWrap = true;
           // }
        }

        private void �۲�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. ����ڿ��� ������ ������ ���� �ϰ� ��
            this.fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font;

         }

        private void ����ǥ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            statusStrip1.Visible = ����ǥ����ToolStripMenuItem.Checked;
        }

        private void �޸�������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout f = new fAbout();
            f.ShowDialog();
        }
    }
}