using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace COMPANY_MANAGEMENT.OOP
{
    class ExtendedTask :Task
    {
        public Status Status { get { return StatusExtensions.ToStatus(Task_status); } set { Task_status = value.ToString(); } }

        public ExtendedTask() { }

        public ExtendedTask(string _id, string _name, DateTime _startDate, DateTime _endDate, string _description, Status _status, string _id_project)
        {
            this.ID = _id;
            this.Task_Name = _name;
            this.StartDate = _startDate;
            this.EndDate = _endDate;
            this.Task_description = _description;
            this.Status = _status;
            this.Project_ID = _id_project;
        }
        ~ExtendedTask() { }
        public void UpdateStatus(Status newStatus)
        {
            this.Status = newStatus;
        }
        public void GetStatus()
        {
            if (Status == Status.NotStarted)
            {
                DateTime today = DateTime.Today;
                if (today > EndDate)
                {
                    UpdateStatus(Status.BehindSchedule);
                }
                else if (today >= StartDate && today <= EndDate)
                {
                    if (today > EndDate)
                    {
                        UpdateStatus(Status.BehindSchedule);
                    }
                    else
                    {
                        UpdateStatus(Status.InProgress);
                    }
                }
                else
                {
                    UpdateStatus(Status.NotStarted);
                }
            }
        }
        public string ToStringTaskStatus(Status status)
        {
            return status.ToString();
        }
    }
}
