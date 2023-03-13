﻿namespace Dragon.Auth.Web.Sso.Data.App.ECommerce.Dto
{
    public class AddressTypeDto
    {
        public string Label { get; set; }
        public string Value { get; set; }

        public AddressTypeDto(string label, string value)
        {
            Label = label;
            Value = value;
        }
    }
}