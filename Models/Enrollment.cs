﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EduVerseFunction.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int CourseId { get; set; }

    public int UserId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public string PaymentStatus { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual UserProfile User { get; set; }
}