using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Net.Http.Json;
//using NAudioDemo.Utils;


namespace ChatForm
{
    public partial class CahtForm : Form
    {
        private Voice2Text v2t { get; set; }

        // メンテナンス用のコントロールは作成不要とする。
        // 普通のフィールドでOK
        private string get_url
        {
            get
            {
                return this.txtGetUrl.Text;
            }
            set
            {
                this.txtGetUrl.Text = value;
            }
        }

        private string put_url
        {
            get
            {
                return this.txtPutUrl.Text;
            }
            set
            {
                this.txtPutUrl.Text = value;
            }
        }

        private string post_url
        {
            get
            {
                return this.txtPostUrl.Text;
            }
            set
            {
                this.txtPostUrl.Text = value;
            }
        }

        HttpClient client { get; set; }

        public CahtForm()
        {
            InitializeComponent();
            this.v2t = new Voice2Text();
            this.client = new HttpClient();
            get_url = "http://localhost:8000/get_message";
            put_url = "http://localhost:8000/push_message";
            post_url = "http://localhost:8000/convert_text";

            this.MonitorRefresh();
        }

        private void MonitorRefresh()
        {
            // メッセージをサーバーから取得
            HttpResponseMessage res = client.GetAsync(get_url).GetAwaiter().GetResult();
            ResponseType res_json = res.Content.ReadFromJsonAsync<ResponseType>().GetAwaiter().GetResult();

            // モニターに表示
            this.txtMonitor.Text = res_json.message;
        }

        private void MessagePush()
        {
            // メッセージをサーバーへ送信
            string send_msg = this.txtInput.Text;
            SendType send_json = new SendType();
            send_json.message = send_msg;
            client.PutAsJsonAsync<SendType>(put_url, send_json).GetAwaiter().GetResult();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 送信と現在のメッセージをサーバーから取得
            this.MessagePush();
            this.MonitorRefresh();
        }

        private void btnMic_MouseDown(object sender, MouseEventArgs e)
        {
            // ボタンを押している間録音
            this.v2t.RecordStart();
        }

        private void btnMic_MouseUp(object sender, MouseEventArgs e)
        {
            // 解析サーバーへ音声を送信してテキストを取得
            string msg = this.v2t.RecordStopAndGetText(post_url);
            this.txtInput.Text = msg;
        }
    }
}