﻿public class Message
{
    public int MessageId { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime SentAt { get; set; }
}
