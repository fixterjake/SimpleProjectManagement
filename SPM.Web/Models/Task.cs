﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SPM.Web.Models
{
    public class Task
    {
        [Key] public int Id { get; set; }

        public int ItemId { get; set; }
        public int SprintId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime Created { get; set; }

        /// <summary>
        ///     Returns string value of task status.
        /// </summary>
        /// <returns>String value of status</returns>
        public string GetStatusString()
        {
            return Status switch
            {
                TaskStatus.Pending => "Pending",
                TaskStatus.InProgress => "In Progress",
                TaskStatus.Blocked => "Blocked",
                TaskStatus.Complete => "Complete",
                _ => throw new ArgumentOutOfRangeException("")
            };
        }
    }

    public enum TaskStatus
    {
        Pending,
        InProgress,
        Blocked,
        Complete
    }
}