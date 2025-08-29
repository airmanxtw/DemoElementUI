<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoElementUI.Default" %>
<%@ Register src="CaptchaImg.ascx" tagname="CaptchaImg" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h5>Content Page
    </h5>
    <uc1:CaptchaImg ID="CaptchaImg1" runat="server" />
   <my-btn></my-btn>
    <my-btn></my-btn>
    <my-btn></my-btn>
    <my-btn></my-btn>
    <my-btn></my-btn>
    <my-btn></my-btn>
    <my-btn></my-btn>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
   
</asp:Content>
