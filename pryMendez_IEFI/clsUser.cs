using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMendez_IEFI
{
    public class clsUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public bool Admin { get; set; }
        public List<string> Tasks { get; set; } = new List<string>();

        private DateTime? sessionStartTime;
        private TimeSpan sessionElapsedTime;

        public void StartSession()
        {
            sessionStartTime = DateTime.Now;
        }

        public void EndSession()
        {
            if (sessionStartTime.HasValue)
            {
                sessionElapsedTime = DateTime.Now - sessionStartTime.Value;
                string elapsedStr = sessionElapsedTime.ToString(@"hh\:mm\:ss");

                // Store in DB
                clsConnection db = new clsConnection();
                db.UpdateElapsedTime(this.Username, elapsedStr);

                ShowSessionTime();
                sessionStartTime = null;
            }
        }

        private void ShowSessionTime()
        {
            MessageBox.Show(
                $"Total time spent in the app: {sessionElapsedTime:hh\\:mm\\:ss}",
                "Session Time",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
