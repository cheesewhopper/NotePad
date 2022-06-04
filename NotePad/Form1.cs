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

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        string filename = "";

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 사용자에게 열 파일을 선택하게 함 
            this.openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();
            

            //1-1 선택한 파일명을 변수에 저장
            filename = openFileDialog1.FileName;

            //2. 파일의 내용을 읽는다.
            string Data = System.IO.File.ReadAllText(filename);
            //3, 화면에 표시 한다.
            tbContents.Text = Data;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //파일명이 입력되어 있으면 
            if (filename != "")
            {
                //1. 사용자에게 저장할 파일을 선택 하게 함
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();
                
                //2. 파일을 저장 한다.
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
                //3. 파일명을 기억
                filename = saveFileDialog1.FileName;

            }
            else
            {
                //해당 파일명으로 현재 내용을 저장

                //2. 파일을 저장 한다.
                System.IO.File.WriteAllText(filename, tbContents.Text);
            }



        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 사용자에게 저장할 파일을 선택 하게 함
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            this.saveFileDialog1.ShowDialog();
           
            //2. 파일을 저장 한다.
            System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 프로그램 종료
            Close();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. 사용자에게 저장할 파일을 선택 하게 함
            this.fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font;

         }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            statusStrip1.Visible = 상태표시줄ToolStripMenuItem.Checked;
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout f = new fAbout();
            f.ShowDialog();
        }
    }
}