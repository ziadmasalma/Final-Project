﻿namespace WebApplication1.Models;

public class EventAddEntitycs
{
    public int ActivityID { get; set; }
    public string ActivityName { get; set; }
    public string LocationOfActivity { get; set; }
    public DateTime ActivityExecutionTime { get; set; }
    public DateTime DateImplementationActivity { get; set; }

    public string EntityResponsibleActivity { get; set; }

    public string? ActivityDescription { get; set; }

    public int NumberParticipateActivity { get; set; }

    public int StudentID { get; set; }




}
