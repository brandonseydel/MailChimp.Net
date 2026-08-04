using System;
using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Customer
{
    public Customer()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }

    [MailChimpJsonProperty("opt_in_status")]
    public bool OptInStatus { get; set; }

    [MailChimpJsonProperty("company")]
    public string Company { get; set; }

    [MailChimpJsonProperty("first_name")]
    public string FirstName { get; set; }

    [MailChimpJsonProperty("last_name")]
    public string LastName { get; set; }

    [MailChimpJsonProperty("orders_count")]
    public int? OrdersCount { get; set; }

    [MailChimpJsonProperty("total_spent")]
    public decimal? TotalSpent { get; set; }

    [MailChimpJsonProperty("address")]
    public Address Address { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [MailChimpJsonProperty("_links")]
    public ICollection<Link> Links { get; set; }
}
