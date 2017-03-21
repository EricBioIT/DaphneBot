﻿using System;
using System.Linq;
using System.Web.UI;

namespace HelloBot.Forms
{
    public partial class Users : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DaphneBotEntities ctx = new DaphneBotEntities())
            {
                foreach (var VARIABLE in ctx.Users)
                {
                    resultStr.Text += $"<tr>" +
                            $"<td data-title='ID'>{VARIABLE.id}</td>" +
                            $"<td data-title='team-name' >{VARIABLE.Team.teamName}</td>" +
                            $"<td data-title='team-name' >{VARIABLE.userName}</td>" +
                            $"<td data-title='team-name' >{VARIABLE.fullName}</td>" +
                        $"</tr>";

                }
            }
        }
       
    }
}