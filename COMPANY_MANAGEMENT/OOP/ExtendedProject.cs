using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using static COMPANY_MANAGEMENT.OOP.ExtendedProject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace COMPANY_MANAGEMENT.OOP
{
    public enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        BehindSchedule,
        Cancelled
    }
    class ExtendedProject : Project
    {
        public Status Status {  get{ return StatusExtensions.ToStatus(Project_status); } set { Project_status = value.ToString(); } }

        public ExtendedProject() { }
        public ExtendedProject(string _id, string _name, DateTime _startDate, DateTime _endDate, string _description, Status _status)
        {
            this.ID = _id;
            this.Project_Name = _name;
            this.StartDate = _startDate;
            this.EndDate = _endDate;
            this.Project_description = _description;
            this.Status = _status;
        }
        ~ExtendedProject() { }
        public void UpdateStatus(Status newStatus)
        {
            this.Status = newStatus;
        }
        public string ToStringTaskStatus(Status status)
        {
            return status.ToString();
        }
        public Status GetStatus()
        {
            if (Tasks == null || Tasks.Count == 0)
            {
                return Status.NotStarted;
            }

            bool allTasksCompleted = Tasks.All(t => t.Task_status == Status.Completed.ToString());

            if (allTasksCompleted)
            {
                return Status.Completed;
            }

            bool anyTaskInProgress = Tasks.Any(t => t.Task_status == Status.InProgress.ToString());

            if (anyTaskInProgress)
            {
                return Status.InProgress;
            }

            bool anyTaskOnHold = Tasks.Any(t => t.Task_status == Status.OnHold.ToString());

            if (anyTaskOnHold)
            {
                return Status.OnHold;
            }

            if (EndDate < DateTime.Now)
            {
                return Status.BehindSchedule;
            }
            return Status.InProgress;
        }
        public List<Task> GetListTasks(string id_project)
        {
            TaskDAO tksDAO = new TaskDAO();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            conn.Open();
            string sql = String.Format("SELECT * FROM Tasks WHERE Project_ID = '{0}'", id_project);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Task> tasks = new List<Task>();
            while (reader.Read())
            {
                Task task = new Task();
                ExtendedTask ETask = new ExtendedTask();
                task.ID = reader.GetString(0);
                ETask.ID = task.ID;
                task.Task_Name = reader.GetString(1);
                ETask.Task_Name = task.Task_Name;
                task.StartDate = reader.GetDateTime(2);
                ETask.StartDate = task.StartDate;
                task.EndDate = reader.GetDateTime(3);
                ETask.EndDate = task.EndDate;
                task.Task_description = reader.GetString(4);
                ETask.Task_description = task.Task_description;
                task.Task_status = reader.GetString(5);
                ETask.Status = (Status)Enum.Parse(typeof(Status), reader.GetString(5));
                ETask.GetStatus();
                task.Task_status = ETask.Task_status;
                task.Project_ID = reader.GetString(6);
                ETask.Project_ID = task.Project_ID;
                tksDAO.Update(ETask);
                tasks.Add(task);
            }
            reader.Close();
            return tasks;
        }
    }
    static class StatusExtensions
    {
        public static Status ToStatus(this string value)
        {
            if (value == "NotStarted")
                return Status.NotStarted;
            else if (value == "BehindSchedule")
                return Status.BehindSchedule;
            else if (value == "Cancelled")
                return Status.Cancelled;
            else if (value == "Completed")
                return Status.Completed;
            else if (value == "InProgress")
                return Status.InProgress;
            else 
                return Status.OnHold;
        }
    }
}
