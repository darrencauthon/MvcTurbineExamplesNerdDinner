<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<NerdDinner.Accounts.Models.RegisterInputModel>" %>

<asp:Content ID="Title" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>

<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Create a New Account</h2>
    <p>
        Use the form below to create a new account. 
    </p>
    <p>
        Passwords are required to be a minimum of <%=Html.Encode(ViewData["PasswordLength"])%> characters in length.
    </p>
    <%= Html.ValidationSummary() %>

    <% using (Html.BeginForm()) { %>
        <div>
            <fieldset>
                <legend>Account Information</legend>
                <p>
                    <%=Html.LabelFor(x=>x.UserName) %>
                    <%= Html.EditorFor(x=>x.UserName) %>
                    <%=Html.ValidationMessageFor(x=>x.UserName) %>
                </p>
                <p>
                    <%=Html.LabelFor(x=>x.Email) %>
                    <%= Html.EditorFor(x=>x.Email) %>
                    <%=Html.ValidationMessageFor(x=>x.Email) %>
                </p>
                <p>
                    <%=Html.LabelFor(x => x.Password)%>
                    <%= Html.EditorFor(x => x.Password)%>
                    <%=Html.ValidationMessageFor(x=>x.Password) %>
                </p>
                <p>
                    <%=Html.LabelFor(x => x.ConfirmPassword)%>
                    <%= Html.EditorFor(x => x.ConfirmPassword)%>
                    <%=Html.ValidationMessageFor(x=>x.ConfirmPassword) %>
                </p>
                <p>
                    <input type="submit" value="Register" />
                </p>
            </fieldset>
        </div>
    <% } %>
</asp:Content>
