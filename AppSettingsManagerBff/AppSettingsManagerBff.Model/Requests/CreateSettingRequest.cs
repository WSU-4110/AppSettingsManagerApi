﻿using System.Text.Json.Nodes;

namespace AppSettingsManagerBff.Model.Requests;

public class CreateSettingRequest
{
    public string SettingGroupId { get; set; }
    public string Input { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }
}
