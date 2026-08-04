using MailChimp.Net.Models;
using System;
using System.Collections.Generic;

namespace MailChimp.Net.Core;


public class ReplicateResponse
{
    public ReplicateResponse()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("type")]
    public string Type { get; set; }

    [MailChimpJsonProperty("create_time")]
    public DateTime CreateTime { get; set; }

    [MailChimpJsonProperty("archive_url")]
    public string ArchiveUrl { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("emails_sent")]
    public int EmailsSent { get; set; }

    [MailChimpJsonProperty("send_time")]
    public string SendTime { get; set; }

    [MailChimpJsonProperty("content_type")]
    public string ContentType { get; set; }

    [MailChimpJsonProperty("recipients")]
    public Recipient Recipients { get; set; }

    [MailChimpJsonProperty("settings")]
    public Setting Settings { get; set; }

    [MailChimpJsonProperty("tracking")]
    public Tracking Tracking { get; set; }

    [MailChimpJsonProperty("delivery_status")]
    public DeliveryStatus DeliveryStatus { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
